import { createStore, applyMiddleware, compose, combineReducers } from 'redux';
import thunk from 'redux-thunk';
import { routerReducer } from 'react-router-redux';
import * as Store from './store';

export default function configureStore(initialState?: Store.IApplicationState) {
    const windowIfDefined = typeof window === 'undefined' ? null : window as any;

    const rootReducer = buildRootReducer(Store.reducers);

    const composeEnhancers = windowIfDefined.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;
    const store = createStore(rootReducer, {}, composeEnhancers(
        applyMiddleware(thunk)
    ));

    // Enable Webpack hot module replacement for reducers
    if (module.hot) {
        module.hot.accept('./store', () => {
            const nextRootReducer = require<typeof Store>('./store');
            store.replaceReducer(buildRootReducer(nextRootReducer.reducers));
        });
    }

    return store;
}

function buildRootReducer(allReducers) {
    return combineReducers<Store.IApplicationState>(Object.assign({}, allReducers, { routing: routerReducer }));
}