import * as React from 'react';

export default class Home extends React.Component {
    render() {
        return (
            <div>
                <div className="row">
                    <div className="embed-responsive embed-responsive-21by9">
                        <iframe className="embed-responsive-item" src="http://localhost:54908/Intro" />
                    </div>
                </div>
                <div className="row">&nbsp;</div>
                <div className="row">
                    <div className="col-4 offset-8">
                        <a href="https://codepen.io/TimPietrusky/pen/eHGfj" target="_blank">Animation: Tim Pietrusky</a>
                    </div>
                </div>
            </div>
        );



    }
}
