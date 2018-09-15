import * as React from 'react';
import { Carousel } from 'react-responsive-carousel';
import { Link } from 'react-router-dom';
import SS1 from '../images/Freescape_SS1.jpg';
import SS2 from '../images/Freescape_SS2.jpg';
import SS3 from '../images/Freescape_SS3.jpg';
import SS4 from '../images/Freescape_SS4.jpg';
import SS5 from '../images/Freescape_SS5.jpg';
import SS6 from '../images/Freescape_SS6.jpg';

export default class Home extends React.Component {
    render() {
        return (
            <div>

                <h1 className="center">Welcome to Freescape!</h1>
                <h3 className="center">A Neverwinter Nights: Enhanced Edition Server</h3>

                <div className="row">
                    <div className="col">
                        <div className="card border-primary mb-3">
                            <div className="card-header">About Freescape</div>
                            <div className="card-body">
                                <div className="card-text">
                                    Freescape is a persistent world entirely driven by players. We give you the tools - you make the world!
                                    <br />
                                    <ul>
                                        <li><Link to="/skills">Skill-based progression</Link></li>
                                        <li><Link to="/perks">Custom perks & magic system</Link></li>
                                        <li><Link to="/lore">Unique setting</Link></li>
                                        <li>Expansive sandbox</li>
                                        <li><Link to="/survival">Survival gameplay</Link></li>
                                        <li>Player-built bases</li>
                                        <li>And much more!</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col">
                        <div className="card border-primary mb-3">
                            <div className="card-header">Connection Info</div>
                            <div className="card-body">
                                <div className="card-text">
                                    Direct Connect: TBA
                                    <br />
                                    Downloads: <Link to="/downloads">Click Here</Link>
                                </div>
                            </div>
                        </div>

                        <div className="card border-primary mb-3">
                            <div className="card-header">Buy Neverwinter Nights: Enhanced Edition</div>
                            <div className="card-body">
                                <div className="card-text">
                                    Buy on Steam: <a href="http://store.steampowered.com/app/704450/Neverwinter_Nights_Enhanced_Edition/" target="_blank">Click Here</a>
                                    <br />
                                    Buy from Beamdog: <a href="https://www.beamdog.com/products/neverwinter-nights-enhanced-edition#signup-form" target="_blank">Click Here</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>



                <Carousel>
                    <div>
                        <img src={SS4} alt="Screenshot 1" className="img-fluid" />
                    </div>
                    <div>
                        <img src={SS1} alt="Screenshot 2" className="img-fluid" />
                    </div>
                    <div>
                        <img src={SS5} alt="Screenshot 3" className="img-fluid" />
                    </div>
                    <div>
                        <img src={SS2} alt="Screenshot 4" className="img-fluid" />
                    </div>
                    <div>
                        <img src={SS6} alt="Screenshot 5" className="img-fluid" />
                    </div>
                    <div>
                        <img src={SS3} alt="Screenshot 6" className="img-fluid" />
                    </div>
                </Carousel>

            </div>
        );



    }
}
