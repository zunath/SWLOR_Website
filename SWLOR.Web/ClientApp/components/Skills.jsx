import * as React from 'react';
import * as dotnetify from 'dotnetify';
import { Link } from 'react-router-dom';

export default class Skills extends React.Component {
    constructor(props) {
        super(props);
        this.vm = dotnetify.react.connect('SkillsViewModel', this);
        this.dispatch = state => this.vm.$dispatch(state);

        this.state = {
            SkillCategoryList: [],
            SkillList: [],
            SelectedCategoryID: 0,
            SelectedSkillID: 0,
            SelectedSkill: {}
        }

        this.handleChange = this.handleChange.bind(this);
    }
    
    componentWillUnmount() {
        this.vm.$destroy();
    }
    
    handleChange(event) {
        const target = event.target;
        var value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;

        if (value === undefined)
            value = target.getAttribute('data-skillid');
        
        this.setState({
            [name]: value
        }, () => this.dispatch({[name]: value}));
    }
    
    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-12">
                        <div className="card border-primary mb-3 center">
                            <div className="card-body">
                                <h4 className="card-title">Skills</h4>

                                <p>
                                    Freescape introduces skill-based gameplay to NWN. Instead of being held back by restrictive classes, you define your character by playing it.
                                    <br />
                                    Want to be a warrior? Equip some heavy armor and a melee weapon then start bashing heads.
                                    <br />
                                    How about a mage? Learn some magic and start casting spells.
                                    <br />
                                    Or perhaps the life of a simple farmer is more your style? Grab a shovel, some seeds, and get to planting!
                                    <br />
                                    Specialize in a handful of skills or become a jack-of-all-trades. What you choose is entirely up to you.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>

                <div className="row">
                    <div className="col-3">
                        <h3 className="center">Skill List</h3>
                        <hr />

                        <div className="row">
                            

                            <div className="col">
                                <select className="form-control"
                                        name="SelectedCategoryID"
                                        onChange={this.handleChange}
                                        value={this.state.SelectedCategoryID} >
                                    {this.state.SkillCategoryList.map(obj =>
                                        <option key={obj.SkillCategoryID} value={obj.SkillCategoryID}>
                                            {obj.Name}
                                        </option>
                                    )}
                                </select>
                            </div>

                        </div>

                        <div className="row">&nbsp;</div>
                        
                        <div className="list-group">
                            {this.state.SkillList.map(obj =>
                                <Link key={obj.SkillID}
                                    className={this.state.SelectedSkillID === obj.SkillID ? 'list-group-item list-group-item-action active' : 'list-group-item list-group-item-action'}
                                    to="#"
                                    onClick={this.handleChange}
                                    name="SelectedSkillID"
                                    data-skillid={obj.SkillID}>
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
                                {this.state.SelectedSkill.Name}
                            </div>

                        </div>
                        <div className="row">&nbsp;</div>
                        <div className="row">
                            <div className="col-3">
                                <b>Description:</b>
                            </div>
                            <div className="col">
                                {this.state.SelectedSkill.Description}
                            </div>
                        </div>

                        <div className="row">&nbsp;</div>
                        <div className="row">
                            <div className="col-1">
                                <b>Ranks:</b>
                            </div>
                            <div className="col-1">
                                {this.state.SelectedSkill.MaxRank === undefined ? '' : this.state.SelectedSkill.MaxRank}
                            </div>
                            <div className="col-1">
                                <b>Primary:</b>
                            </div>
                            <div className="col-1">
                                {this.state.SelectedSkill.Primary === undefined ? '' : this.state.SelectedSkill.Primary.Name}
                            </div>
                            <div className="col-1">
                                <b>Secondary:</b>
                            </div>
                            <div className="col-1 pl-4">
                                {this.state.SelectedSkill.Secondary === undefined ? '' : this.state.SelectedSkill.Secondary.Name}
                            </div>
                            <div className="col-1">
                                <b>Tertiary:</b>
                            </div>
                            <div className="col-1">
                                {this.state.SelectedSkill.Tertiary === undefined ? '' : this.state.SelectedSkill.Tertiary.Name}
                            </div>
                        </div>
                        
                    </div>

                </div>
            </div>
        );



    }
}
