import * as React from 'react';
import { Link } from 'react-router-dom';
import Crawl from 'react-star-wars-crawl';

export default class Home extends React.Component<any, any> {
    render() {
        return (
            <div>

                <h1 className="center">Welcome to Star Wars: Legends of the Old Republic!</h1>
                <h3 className="center">A NeverWinter Nights Server</h3>
                <h5 className="center">
                    Direct Connect: swlor.eastus.cloudapp.azure.com:5121 <Link to="/downloads"><i>(Download Files)</i></Link>
                </h5>

                <Crawl
                    title="Episode IV"
                    subTitle="A New Hope">
                    <div>
                        It is a period of civil war. 
                        <br />
                        <br /> 
                        Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. 
                        <br />
                        <br />
                        During the battle, Rebel spies managed to steal secret plans to the Empire's ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. '
                        <br />
                        <br />
                        Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy...
                    </div>
                </Crawl>

            </div>
        );



    }
}
