import * as React from 'react';
import { Link } from 'react-router-dom';
import * as dotnetify from 'dotnetify';
import Logout from './Logout';
import * as Logo from '../images/compressed/swollogo2.png';

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
                        <i className="fa fa-cogs fa-lg" /> Admin
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
                
                <nav className="navbar navbar-expand-lg navbar-dark bg-dark">


                    <div className="navbar">
                        <ul className="navbar-nav">
                            <li className="nav-item">
                                <Link className="nav-link" to="/story">
                                    <i className="fa fa-info-circle fa-lg" /> Story
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/classes">
                                    <i className="fa fa-info-circle fa-lg" /> Classes
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/races">
                                    <i className="fa fa-info-circle fa-lg" /> Races
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/crafting">
                                    <i className="fa fa-info-circle fa-lg" /> Skills
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/crafting">
                                    <i className="fa fa-info-circle fa-lg" /> Crafting
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/downloads">
                                    <i className="fa fa-download fa-lg" /> Downloads
                                </Link>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="http://forums.starwarsnwn.com/">
                                    <i className="fa fa-th-list fa-lg" /> Forums
                                </a>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="https://discord.gg/g7PzMaM" target="_blank">
                                    <i className="fa fa-commenting-o fa-lg" /> Discord (Chat)
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="http://czs.wikia.com/" target="_blank">
                                    <i className="fa fa-wikipedia-w fa-lg" /> Wiki
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="https://github.com/zunath/Star-Wars-Legends-of-the-Old-Republic-NWN" target="_blank">
                                    <i className="fa fa-code fa-lg" /> Source Code
                                </Link>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="/team">
                                    <i className="fa fa-th-list fa-lg" /> Team
                                </a>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/about-nwn">
                                    <i className="fa fa-info-circle fa-lg" /> About NWN
                                </Link>
                            </li>

                            {renderAdmin()}

                            {this.state.Username === '' || this.state.Username === null || this.state.Username === undefined ?

                                <li className="nav-item pull-right">
                                    <a className="nav-link" href="/Authorization/Login">
                                        <i className="fa fa-sign-in fa-lg" /> Login (With Discord)
                                    </a>
                                </li> :
                                <li className="nav-item dropdown">
                                    <Link id="userDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                        <i className="fa fa-user fa-lg" /> {this.state.Username}
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
        );



    }
}
