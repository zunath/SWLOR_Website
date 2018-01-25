import * as React from 'react';

export default class NotFound extends React.Component<any, any> {

    render() {
        return (
            <div>
                <div className="row">
                    We're sorry but we weren't able to find that page.
                </div>
                
                <div className="row">&nbsp;</div>
                <div className="row"> 
                    <a className="btn btn-primary" href="/">Go Home</a>
                </div>
                
            </div>
        );



    }
}
