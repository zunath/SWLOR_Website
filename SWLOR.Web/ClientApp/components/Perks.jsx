import * as React from 'react';
import * as dotnetify from 'dotnetify';
import { Link } from 'react-router-dom';

export default class Perks extends React.Component {
    constructor(props) {
        super(props);
        this.vm = dotnetify.react.connect('PerksViewModel', this);
        this.dispatch = state => this.vm.$dispatch(state);

        this.state = {
            PerkCategoryList: [],
            PerkList: [],
            SelectedCategoryID: 0,
            SelectedPerkID: 0,
            SelectedPerk: {},
            ActiveTab: 1
        }

        this.handleChange = this.handleChange.bind(this);
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }

    handleChangeCategory() {
        this.dispatch({
            SelectedCategory: this.state.SelectedCategory
        });
    }

    handleChange(event) {
        const target = event.target;
        var value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;

        if (value === undefined)
            value = target.getAttribute('data-perkid');

        this.setState({
            [name]: value
        }, () => this.dispatch({ [name]: value }));
    }

    toggle(tab) {
        if (this.state.ActiveTab !== tab) {
            this.setState({
                ActiveTab: tab
            });
        }
    }

    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-12">
                        <div className="card border-primary mb-3 center">
                            <div className="card-body">
                                <h4 className="card-title">Perks</h4>

                                <p>
                                    Perks cover a wide range of upgrades available to your character.
                                    <br />
                                    Every time you gain a skill level, you also gain 1 skill point (SP).
                                    <br />
                                    These SP can be spent to purchase everything from stat upgrades like HP and Mana to learning new spells and abilities.
                                    <br />
                                    Most Perks have multiple ranks so you can decide how deeply specialized you want to be.
                                    <br />
                                    Take a look at the available Perks below. New ones are being added all the time!
                                </p>
                            </div>
                        </div>
                    </div>
                </div>



                <div className="row">
                    <div className="col-3">
                        <h3 className="center">Perk List</h3>
                        <hr />

                        <div className="row">


                            <div className="col">
                                <select className="form-control"
                                    name="SelectedCategoryID"
                                    onChange={this.handleChange}
                                    value={this.state.SelectedCategoryID} >
                                    {this.state.PerkCategoryList.map(obj =>
                                        <option key={obj.PerkCategoryID} value={obj.PerkCategoryID}>
                                            {obj.Name}
                                        </option>
                                    )}
                                </select>
                            </div>

                        </div>

                        <div className="row">&nbsp;</div>

                        <div className="list-group">
                            {this.state.PerkList.map(obj =>
                                <Link key={obj.PerkID}
                                    className={this.state.SelectedPerkID === obj.PerkID ? 'list-group-item list-group-item-action active' : 'list-group-item list-group-item-action'}
                                    to="#"
                                    onClick={this.handleChange}
                                    name="SelectedPerkID"
                                    data-perkid={obj.PerkID}>
                                    {obj.Name}
                                </Link>
                            )}
                        </div>
                    </div>
                    <div className="col offset-1">
                        <h3 className="center">Details</h3>
                        <hr />

                        <div className="row">
                            <div className="col-3">
                                <b>Name:</b>
                            </div>
                            <div className="col">
                                {this.state.SelectedPerk.Name}
                            </div>

                        </div>
                        <div className="row">&nbsp;</div>

                        {this.state.SelectedPerk.ExecutionTypeID > 0 &&
                            <div className="row">
                                <div className="col-3">
                                    <b>Type:</b>
                                </div>
                                <div className="col">
                                    <p>
                                        {this.state.SelectedPerk.ExecutionType.Name}
                                    </p>

                                </div>
                            </div>
                        }

                        <div className="row">
                            <div className="col-3">
                                <b>Description:</b>
                            </div>
                            <div className="col">
                                <p>
                                    {this.state.SelectedPerk.Description}
                                </p>

                            </div>
                        </div>

                        <div className="row">
                            {this.state.SelectedPerk.BaseManaCost > 0 && [
                                <div className="col-2 pl-5">
                                    <b>Mana:</b>
                                </div>,
                                <div className="col-1">
                                    {this.state.SelectedPerk.BaseManaCost}

                                </div>
                            ]}

                            {this.state.SelectedPerk.BaseCastingTime > 0.0 && [
                                <div className="col-2 pl-5">
                                    <b>Delay:</b>
                                </div>,
                                <div className="col-1">
                                    {this.state.SelectedPerk.BaseCastingTime}s
                                        </div>
                            ]}

                            {this.state.SelectedPerk.CooldownCategory && this.state.SelectedPerk.CooldownCategory.BaseCooldownTime > 0.0 && [
                                <div className="col-2 pl-4">
                                    <b>Cooldown:</b>
                                </div>,
                                <div className="col-1">
                                    {this.state.SelectedPerk.CooldownCategory.BaseCooldownTime}s
                                        </div>
                            ]}
                        </div>

                        <div className="row">&nbsp;</div>
                        <ul className="nav nav-tabs"
                            role="tablist">
                            {this.state.SelectedPerk.PerkLevels && this.state.SelectedPerk.PerkLevels.map(perkLevel =>
                                <li className="nav-item"
                                    key={'tab_' + perkLevel.PerkLevelID}>
                                    <Link
                                        className={this.state.ActiveTab === perkLevel.Level ? 'nav-link active' : 'nav-link'}
                                        data-toggle="tab"
                                        to={'#nav-rank' + perkLevel.Level} role="tab">Lvl {perkLevel.Level}</Link>
                                </li>
                            )}
                        </ul>

                        <div className="tab-content">
                            {this.state.SelectedPerk.PerkLevels && this.state.SelectedPerk.PerkLevels.map(perkLevel =>
                                <div className={this.state.ActiveTab === perkLevel.Level ? 'tab-pane active' : 'tab-pane'}
                                    id={'nav-rank' + perkLevel.Level}
                                    role="tabpanel"
                                    key={'tabcontent_' + perkLevel.PerkLevelID}>
                                    <div className="row">&nbsp;</div>
                                    <div className="row">
                                        <div className="col-2">
                                            <b>Bonus:</b>
                                        </div>
                                        <div className="col-10">
                                            {perkLevel.Description}
                                        </div>
                                    </div>
                                    <div className="row">&nbsp;</div>
                                    <div className="row">
                                        <div className="col-2">
                                            <b>Price:</b>
                                        </div>
                                        <div className="col-10">
                                            {perkLevel.Price} SP
                                            </div>
                                    </div>
                                    <div className="row">&nbsp;</div>

                                    {perkLevel.PerkLevelSkillRequirements && perkLevel.PerkLevelSkillRequirements.length > 0 &&
                                        <div className="row">
                                            <div className="col">
                                                <b>Requirements:</b>
                                            </div>
                                        </div>
                                    }

                                    <div className="row">&nbsp;</div>

                                    {perkLevel.PerkLevelSkillRequirements && perkLevel.PerkLevelSkillRequirements.map(req =>
                                        <div className="row"
                                            key={req.PerkLevelSkillRequirementID}>
                                            <div className="col">
                                                {req.Skill.Name} rank {req.RequiredRank}
                                            </div>
                                        </div>
                                    )}
                                </div>
                            )}

                        </div>


                    </div>

                </div>

            </div>
        );
    }
}
