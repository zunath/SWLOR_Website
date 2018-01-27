import * as React from 'react';
import { Link } from 'react-router-dom';

export default class Skills extends React.Component<any, any> {

    render() {
        return (
            <div>
                <h2 className="center">Skills & Abilities</h2>
                <div className="row">
                    <div className="col-12">
                        <p className="center">
                            Star Wars: Legends of the Old Republic offers 15+ new skills and over 100 new abilities for your character to learn.
                            <br />
                            <br />
                            We offer a freeform character progression system - pick and choose what skills to learn, what abilities to learn, and the direction for your character.
                            <br />
                            <br />
                            All of this is accomplished with SWLOR's very unrestrictive <Link to="/classes">class system</Link>.
                            <br />
                            <br />
                            Interested in learning more? <a href="https://www.dropbox.com/s/dggnhblb53ygit8/SWLOTR_SkillTree.pdf?dl=1">Download the comprehensive skill tree </a> and start planning your character today!
                        </p>
                    </div>
                </div>
            </div>
        );



    }
}
