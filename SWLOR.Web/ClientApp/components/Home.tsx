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
                <div className="row">&nbsp;</div>
                <div className="row">
                    <div className="col-4 offset-8">
                        <a href="https://codepen.io/TimPietrusky/pen/eHGfj" target="_blank">Video Credit: Tim Pietrusky</a>
                    </div>
                </div>
                
                <div className="container">
                    <div className="row">&nbsp;</div>
                    <footer>
                        <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
                            <span>
                                Star Wars: Legends of the Old Republic is a free mod developed for Neverwinter Nights. Star Wars, the Expanded Universe, all logos, characters, artwork, stories, information, names, and other elements associated thereto, are sole and exclusive property of Lucasfilm Limited. We are a completely free, open source non-profit project and operate under the definition of "fair use" under United States copyright laws.
                            </span>
                        </nav>
                    </footer>
                </div>
            </div>);



    }
}
