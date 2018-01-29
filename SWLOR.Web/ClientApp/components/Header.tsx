import * as React from 'react';
import { Link } from 'react-router-dom';
import * as dotnetify from 'dotnetify';
import Logout from './Logout';
import * as Logo from '../images/swollogo2.png';

export default class Header extends React.Component<any, any> {
    vm: any;
    dispatchState: any;

    constructor(props: any) {
        super(props);
        this.vm = dotnetify.react.connect('HeaderViewModel', this);
        this.dispatchState = state => this.vm.$dispatch(state);

        this.state = { Username: '', Role: 0 }

        this.confirmLogout = this.confirmLogout.bind(this);
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }

    confirmLogout() {
        window.location.replace('/Authorization/Logout');
    }

    render() {

        const self = this;
        function renderAdmin() {

            if (self.state.Role === 1 || self.state.Role === 2) {
                return <li className="nav-item">
                    <Link className="nav-link" to="/Admin">
                        <i className="fa fa-cogs " /> Admin
                    </Link>
                </li>;
            }
            return '';
        }

        return (
            <div>
                <Logout callback={this.confirmLogout} />

                <div className="center">
                    <Link className="navbar-brand" to="/">
                        <img className="navbar-brand img-fluid" src={Logo} alt="logo" />
                    </Link>
                </div>

                <div className="row">
                    <div className="col-7 offset-2">

                        <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
                            <div className="navbar">
                                <ul className="navbar-nav">

                                    <li>
                                        <Link className="nav-link" to="/home">
                                            <i className="fa fa-home" /> Home
                                        </Link>
                                    </li>
                                    <li className="nav-item dropdown">
                                        <Link id="loreDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                            <i className="fa fa-space-shuttle" /> Lore
                                        </Link>
                                        <div className="dropdown-menu">
                                            <Link className="dropdown-item" to="/story">
                                                <i className="fa fa-book" /> Story
                                    </Link>
                                            <Link className="dropdown-item" to="/races">
                                                <i className="fa fa-male" /> Races
                                    </Link>
                                        </div>
                                    </li>
                                    <li className="nav-item dropdown">
                                        <Link id="gameplayDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                            <i className="fa fa-gamepad" /> Gameplay
                                        </Link>
                                        <div className="dropdown-menu">
                                            <Link className="dropdown-item" to="/classes">
                                                <i className="fa fa-shield" /> Classes
                                    </Link>
                                            <Link className="dropdown-item" to="/skills">
                                                <i className="fa fa-bolt" /> Skills & Abilities
                                    </Link>
                                        </div>
                                    </li>
                                    <li className="nav-item dropdown">
                                        <Link id="serverInfoDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                            <i className="fa fa-info" /> Server Info
                                        </Link>
                                        <div className="dropdown-menu">
                                            <Link className="dropdown-item" to="/downloads">
                                                <i className="fa fa-download" /> Downloads
                                            </Link>
                                            <Link className="dropdown-item" to="/connection-info">
                                                <i className="fa fa-plug" /> Connection Info
                                            </Link>
                                        </div>
                                    </li>
                                    <li className="nav-item">
                                        <Link className="nav-link" to="https://discord.gg/g7PzMaM" target="_blank">
                                            <i className="fa fa-commenting-o " /> Discord (Chat)
                                        </Link>
                                    </li>
                                    <li className="nav-item dropdown">
                                        <Link id="serverInfoDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                            <i className="fa fa-code" /> Source Code
                                        </Link>
                                        <div className="dropdown-menu">
                                            <a className="dropdown-item" href="https://github.com/zunath/Star-Wars-Legends-of-the-Old-Republic-NWN" target="_blank">
                                                <i className="fa fa-code" /> Server Source Code
                                            </a>
                                            <a className="dropdown-item" href="https://github.com/zunath/Star-Wars-Legends-of-the-Old-Republic-NWN-Website" target="_blank">
                                                <i className="fa fa-code" /> Website Source Code
                                            </a>
                                        </div>
                                    </li>
                                    <li className="nav-item dropdown">
                                        <Link id="aboutDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                            <i className="fa fa-user " /> About
                                        </Link>
                                        <div className="dropdown-menu">
                                            <Link className="dropdown-item" to="/team-members">
                                                <i className="fa fa-user-circle-o" /> Team Members
                                            </Link>
                                            <Link className="dropdown-item" to="http://nwn.beamdog.com/" target="_blank">
                                                <i className="fa fa-external-link" /> Buy Neverwinter Nights
                                            </Link>
                                            <Link className="dropdown-item" to="https://forums.beamdog.com/categories/neverwinter-nights" target="_blank">
                                                <i className="fa fa-external-link" /> NWN Beamdog Forums
                                            </Link>
                                            <Link className="dropdown-item" to="https://discord.gg/ZDHxTdJ" target="_blank">
                                                <i className="fa fa-external-link" /> NWN Community Discord Channel
                                            </Link>
                                        </div>
                                    </li>

                                    {renderAdmin()}

                                    {this.state.Username === '' || this.state.Username === null || this.state.Username === undefined ?

                                        <li className="nav-item pull-right">
                                            <a className="nav-link" href="/Authorization/Login">
                                                <i className="fa fa-sign-in " /> Login (With Discord)
                                    </a>
                                        </li> :
                                        <li className="nav-item dropdown">
                                            <Link id="userDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                                <i className="fa fa-user " /> {this.state.Username}
                                            </Link>
                                            <div className="dropdown-menu">
                                                <Link className="dropdown-item" to="/user-profile">
                                                    <i className="fa fa-user" /> Profile
                                        </Link>
                                                <Link className="dropdown-item" to="#" data-toggle="modal" data-target="#logoutModal">
                                                    <i className="fa fa-sign-out" /> Log Out
                                        </Link>
                                            </div>
                                        </li>
                                    }
                                </ul>
                            </div>


                        </nav>
                    </div>

                </div>

            </div>
        );



    }
}
