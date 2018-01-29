import * as React from 'react';
import { Link } from 'react-router-dom';

export default class Classes extends React.Component<any, any> {

    render() {
        return (
            <div>
                <h2 className="center">Classes</h2>

                <div className="row">
                    <p className="center">
                        Star Wars: Legends of the Old Republic offers three distinct classes. These classes are much more freeform than vanilla Neverwinter Nights.
                        <br />
                        <br />
                        The majority of your character development will come through which skills and feats you select. Your class determines which "flavor" of skills and feats are available.
                        <br />
                        <br />
                        Below, you'll find a brief synopsis on each of the classes and some examples of skills. <Link to="/skills">Refer to the skills page for more information on those.</Link>
                    </p>
                </div>

                <div className="row">
                    <div className="col-10 offset-1">
                        <div id="accordion">
                            <div className="card">
                                <div className="card-header" id="headingOne">
                                    <h5 className="mb-0">
                                        <button className="btn btn-link" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                            Force Enabled (Light Side)
                                        </button>
                                    </h5>
                                </div>

                                <div id="collapseOne" className="collapse show" aria-labelledby="headingOne" data-parent="#accordion">
                                    <div className="card-body">
                                        <div className="row">
                                            <div className="col-12">
                                                <h5>Description:</h5>
                                            </div>
                                        </div>
                                        
                                        <div className="row">
                                            <p>
                                            This class is capable of accessing <Link to="http://starwars.wikia.com/wiki/The_Force" target="_blank"> the Force.</Link> This particular style is aligned with the Light Side and serves <Link to="http://starwars.wikia.com/wiki/Galactic_Republic/Legends" target="_blank">the Galactic Republic.</Link>
                                            <br />
                                            Players have access to abilities such as: Deliverance, Force Jump, Force Push, and Force Concealment.
                                            <br />
                                            In addition, the ability to craft and use higher tier lightsabers becomes available to you.
                                            <br />
                                            By contrast, you are prevented from using higher tier vibroblades, staves, blasters, and rifles. You also are unable to create explosives.
                                            <br />
                                            </p>

                                        </div>

                                        <div className="row">&nbsp;</div>

                                        <div className="row">
                                            <div className="col-12">
                                                <h5>Available Skills:</h5>
                                            </div>
                                        </div>
                                        <div className="row">
                                            <div className="col-6">
                                                <ul>
                                                    <li>Melee Combat</li>
                                                    <li>Ranged Combat</li>
                                                    <li>Defense</li>
                                                    <li>Stealth</li>
                                                    <li>Force Control</li>
                                                    <li>Force Alteration</li>
                                                    <li>Force Sense</li>
                                                </ul>
                                            </div>
                                            <div className="col-6">
                                                <ul>
                                                    <li>Electronics</li>
                                                    <li>Manufacturing</li>
                                                    <li>Architecture</li>
                                                    <li>Harvesting</li>
                                                    <li>Medicine</li>
                                                    <li>Speech</li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="card">
                                <div className="card-header" id="headingTwo">
                                    <h5 className="mb-0">
                                        <button className="btn btn-link collapsed" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                                            Force Enabled (Dark Side)
                                        </button>
                                    </h5>
                                </div>
                                <div id="collapseTwo" className="collapse" aria-labelledby="headingTwo" data-parent="#accordion">
                                    <div className="card-body">
                                        <div className="row">
                                            <div className="col-12">
                                                <h5>Description:</h5>
                                            </div>
                                        </div>

                                        <div className="row">
                                            <p>
                                                This class is capable of accessing <Link to="http://starwars.wikia.com/wiki/The_Force" target="_blank">the Force.</Link> This particular style is aligned with the Dark Side and serves <Link to="http://starwars.wikia.com/wiki/Sith" target="_blank">the Sith.</Link>
                                                <br />
                                                Players have access to abilities such as: Dark Heal, Force Lightning, Force Choke, and Force Concealment.
                                                <br />
                                                In addition, the ability to craft and use higher tier lightsabers becomes available to you.
                                                <br />
                                                By contrast, you are prevented from using higher tier vibroblades, staves, blasters, and rifles. You also are unable to create explosives.
                                            </p>

                                        </div>

                                        <div className="row">&nbsp;</div>

                                        <div className="row">
                                            <div className="col-12">
                                                <h5>Available Skills:</h5>
                                            </div>
                                        </div>
                                        <div className="row">
                                            <div className="col-6">
                                                <ul>
                                                    <li>Melee Combat</li>
                                                    <li>Ranged Combat</li>
                                                    <li>Defense</li>
                                                    <li>Stealth</li>
                                                    <li>Force Control</li>
                                                    <li>Force Alteration</li>
                                                    <li>Force Sense</li>
                                                </ul>
                                            </div>
                                            <div className="col-6">
                                                <ul>
                                                    <li>Electronics</li>
                                                    <li>Manufacturing</li>
                                                    <li>Architecture</li>
                                                    <li>Harvesting</li>
                                                    <li>Medicine</li>
                                                    <li>Speech</li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="card">
                                <div className="card-header" id="headingThree">
                                    <h5 className="mb-0">
                                        <button className="btn btn-link collapsed" data-toggle="collapse" data-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                                            Normal
                                        </button>
                                    </h5>
                                </div>
                                <div id="collapseThree" className="collapse" aria-labelledby="headingThree" data-parent="#accordion">
                                    <div className="card-body">
                                        <div className="row">
                                            <div className="col-12">
                                                <h5>Description:</h5>
                                            </div>
                                        </div>

                                        <div className="row">
                                            <p>
                                                This class is incapable of accessing <Link to="http://starwars.wikia.com/wiki/The_Force" target="_blank">the Force</Link> and are not aligned with either side of the conflict.
                                                <br />
                                                Players have access to abilities such as: Kolto, Jet Pack, Concussive Blast, and Displacing Generator.
                                                <br />
                                                In addition, you are able to use higher tier vibroblades, staves, blasters, and rifles.
                                                <br />
                                                By contrast, you are prevented from using or crafting higher tier lightsabers.
                                            </p>

                                        </div>

                                        <div className="row">&nbsp;</div>

                                        <div className="row">
                                            <div className="col-12">
                                                <h5>Available Skills:</h5>
                                            </div>
                                        </div>
                                        <div className="row">
                                            <div className="col-6">
                                                <ul>
                                                    <li>Melee Combat</li>
                                                    <li>Ranged Combat</li>
                                                    <li>Defense</li>
                                                    <li>Stealth</li>
                                                    <li>Tactical Healing</li>
                                                    <li>Tactical Devices</li>
                                                    <li>Tactical Enhancements</li>
                                                </ul>
                                            </div>
                                            <div className="col-6">
                                                <ul>
                                                    <li>Electronics</li>
                                                    <li>Manufacturing</li>
                                                    <li>Architecture</li>
                                                    <li>Harvesting</li>
                                                    <li>Medicine</li>
                                                    <li>Speech</li>
                                                </ul>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );



    }
}
