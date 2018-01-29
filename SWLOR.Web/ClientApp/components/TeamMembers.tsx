import * as React from 'react';
import zunathAvatar from '../images/zunath-avatar.png';
import redCrayonAvatar from '../images/redcrayon-avatar.png';
import projectIrohAvatar from '../images/projectiroh-avatar.png';

export default class TeamMembers extends React.Component<any, any> {

    render() {
        return (
            <div>
                <h2 className="center">Team Members</h2>
                <hr />

                <div className="row"> 
                    <div className="offset-2 col-10">
                        <h4>Zunath (Admin / Development)</h4>
                    </div>
                </div>

                <div className="row">
                    <div className="col-2">
                        <div className="center">
                            <img className="img-fluid" src={zunathAvatar} alt="Zunath's Avatar" />
                        </div>
                    </div>
                    <div className="col-10">
                        <p>
                            Zunath has been working in NWN for over 15 years and has built a large number of projects during that time.
                            <br />
                            <br />
                            Some of his prior projects include: Revenge of the Dead, Forever Quest, Solar Odyssey Online, and Cyberpunk Zombie Survival. He also currently helps build features for NWNX and offers community support on Discord.
                            <br />
                            <br />
                            He serves as one of the project leads (along with RedCrayon) and handles most development related tasks for Star Wars: LOR.
                            <br />
                            <br />
                            Zunath hates speaking about himself in third person and writing autobiographies.
                        </p>
                    </div>
                </div>
                <hr />

                <div className="row">
                    <div className="offset-2 col-10">
                        <h4>RedCrayon (Admin / Lore / DM)</h4>
                    </div>
                </div>

                <div className="row">
                    <div className="col-2">
                        <div className="center">
                            <img className="img-fluid" src={redCrayonAvatar} alt="RedCrayon's Avatar" />
                        </div>
                    </div>
                    <div className="col-10">
                        <p>
                            Hello! My name is Laura, or RedCrayon if you're nasty. 
                            <br />
                            <br />
                            Three things you need to know about me: 
                            <ol>
                                <li>
                                    I'm from Liverpool, UK, so I represent the Euro massive DM-wise.
                                </li>
                                <li>
                                    I've been roleplaying for about 17 years now on and off.
                                </li>
                                <li>
                                    My favourite breed of pig is sausages.
                                </li>
                            </ol>
                            I have been a huge Star Wars fan since I wore out our taped-from-the-TV <i>Empire Strikes Back</i> as a kid, and I've never looked back.
                            <br />
                            <br />
                            I'm hoping to see all of you in game, where we can carve out our own little slice of The Old Republic!
                        </p>
                    </div>
                </div>
                <hr />

                <div className="row">
                    <div className="offset-2 col-10">
                        <h4>pieman102 (Lore / DM)</h4>
                    </div>
                </div>

                <div className="row">
                    <div className="col-2">
                        <div className="center">
                            <img className="img-fluid" src={projectIrohAvatar} alt="ProjectIroh's Avatar" />
                        </div>
                    </div>
                    <div className="col-10">
                        <p>
                            Hello, I am pieman102, but you can just call me Sean if you like.  I am an English-teacher-to-be with an emphasis on creative writing. It's safe to say I vastly enjoy making new stories!
                            <br />
                            <br />
                            I have been DMing since 2nd edition DnD and have been an avid Star Wars fan for as long as I can remember.  My goal will be to get people active and meeting character goals as well as forming stories worthy of telling other players.
                            <br />
                            <br />
                            Let’s get out in that big universe and make something special!
                        </p>

                    </div>
                </div>
            </div>
        );



    }
}
