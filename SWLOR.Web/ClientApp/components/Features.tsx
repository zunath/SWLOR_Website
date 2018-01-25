import * as React from 'react';
import * as dotnetify from 'dotnetify';
import { Link } from 'react-router-dom'

export default class Features extends React.Component<any, any> {
    vm: any;
    
    constructor(props: any) {
        super(props);
        this.vm = dotnetify.react.connect('FeaturesViewModel', this);
        this.state = { Skills: [], Abilities: [], Professions: [] }
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }

    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-3"></div>
                    <div className="col-9">
                        <h2 className="center">Features</h2>
                    </div>
                </div>

                <hr />

                <div className="row">&nbsp;</div>

                <div className="row">
                    <div className="col-3">

                        <div className="sidebar">
                            <h4 className="center">Quick Links</h4>
                            <div className="list-group" id="topics">
                                <a href="/features#story" className="list-group-item list-group-item-action"> 
                                    Story
                                </a>
                                <a href="/features#crafting" className="list-group-item list-group-item-action">
                                    Crafting
                                </a>

                            </div>
                        </div>
                        

                    </div>

                    <div className="col-9">
                        <div data-spy="scroll" data-target="#topics" data-offset="0">

                            <h4 className="center" id="story">Story</h4>
                            <p>
                                Story to be added.
                            </p>
                            

                            <hr />
                            
                            <h4 className="center" id="crafting">Crafting</h4>
                            <p>
                                Crafting to be added.
                            </p>
                            
                            <hr />
                            
                        </div>

                    </div>

                </div>

            </div>
        );



    }
}
