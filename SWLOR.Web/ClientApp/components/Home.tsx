import * as React from 'react';

export default class Home extends React.Component<any, any> {

    constructor(props: any) {
        super(props);
    }
    
    render() {


        return (
            <div>
                <div className="row">
                    <div className="embed-responsive embed-responsive-21by9">
                        <iframe className="embed-responsive-item" src="http://www.starwarsnwn.com/Intro" />
                    </div>
                </div>
            </div>);



    }
}
