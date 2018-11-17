import * as React from 'react';
import { Link } from 'react-router-dom';
import * as dotnetify from 'dotnetify';
import Logout from './Logout';
import Logo from '../images/swollogo2.png';

export default class Header extends React.Component {
    constructor(props) {
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
            <div className="container">
                <Logout callback={this.confirmLogout} />
                
                <Link className="navbar-brand" to="/">
                    <img src={Logo} alt="Star Wars: LOR" className="img-fluid" />
                </Link>
                <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
                    <div className="navbar">
                        <ul className="navbar-nav">
                            <li className="nav-item">
                                <Link className="nav-link" to="/home">
                                    <i className="fa fa-home fa-lg" /> Home
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/about">
                                    <i className="fa fa-info-circle fa-lg" /> About
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/rules">
                                    <i className="fa fa-list-ul fa-lg" /> Rules
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/downloads">
                                    <i className="fa fa-download fa-lg" /> Downloads
                                </Link>
                            </li>
                            <li className="nav-item dropdown">
                                <Link id="loreDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                    <i className="fa fa-book fa-lg" /> &nbsp;Lore
                                </Link>
                                <div className="dropdown-menu">
                                    <Link className="dropdown-item" to="/setting">
                                        <i className="fa fa-bolt" /> &nbsp;Setting
                                    </Link>
                                    <Link className="dropdown-item" to="/species">
                                        <i className="fa fa-level-up" /> &nbsp;Species
                                    </Link>
                                </div>
                            </li>
                            <li className="nav-item dropdown">
                                <Link id="gameplayDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                    <i className="fa fa-info-circle fa-lg" /> &nbsp;Gameplay
                                </Link>
                                <div className="dropdown-menu">
                                    <Link className="dropdown-item" to="/skills">
                                        <i className="fa fa-bolt" /> &nbsp;Skills
                                    </Link>
                                    <Link className="dropdown-item" to="/perks">
                                        <i className="fa fa-level-up" /> &nbsp;Perks
                                    </Link>
                                    <Link className="dropdown-item" to="/backgrounds">
                                        <i className="fa fa-user-secret" /> &nbsp;Character Backgrounds
                                    </Link>
                                    <Link className="dropdown-item" to="/crafting">
                                        <i className="fa fa-simplybuilt" /> &nbsp;Crafting
                                    </Link>
                                    <Link className="dropdown-item" to="/gameplay-info">
                                        <i className="fa fa-compass" /> &nbsp;Other Gameplay Info
                                    </Link>
                                    <Link className="dropdown-item" to="/faq">
                                        <i className="fa fa-question" /> &nbsp;FAQ
                                    </Link>

                                </div>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="https://forums.starwarsnwn.com/">
                                    <i className="fa fa-forumbee fa-lg" /> Forums
                                </a>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="https://discord.gg/MyQAM6m" target="_blank">
                                    <i className="fa fa-commenting-o fa-lg" /> Discord
                                </Link>
                            </li>

                            <li className="nav-item dropdown">
                                <Link id="serverInfoDropdown" className="nav-link dropdown-toggle" to="#" data-toggle="dropdown" role="button">
                                    <i className="fa fa-code" /> Source Code
                                </Link>
                                <div className="dropdown-menu">
                                    <a className="dropdown-item" href="https://github.com/zunath/SWLOR_NWN" target="_blank">
                                        <i className="fa fa-code" /> &nbsp;Server Source Code
                                    </a>
                                    <a className="dropdown-item" href="https://github.com/zunath/SWLOR_Website" target="_blank">
                                        <i className="fa fa-code" /> &nbsp;Website Source Code
                                    </a>
                                </div>
                            </li>

                            {renderAdmin()}

                            {this.state.Username === '' || this.state.Username === null || this.state.Username === undefined ?

                                <li className="nav-item float-right">
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
