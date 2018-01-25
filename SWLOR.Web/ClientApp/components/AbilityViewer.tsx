import * as React from 'react';
import {Link} from 'react-router-dom';

export default class AbilityViewer extends React.Component<any, any> {
    

    constructor(props: any) {
        super(props);
        this.state = {
            abilities: props.abilities,
            activeAbilityID: 0
        }

        this.changeAbility = this.changeAbility.bind(this);
    }

    componentWillReceiveProps(newProps) {
        this.setState({
            abilities: newProps.abilities
        });

        if (this.state.activeAbilityID == undefined || this.state.activeAbilityID === 0) {
            this.setState({
                activeAbilityID: newProps.abilities[0].AbilityID
            });
        }
    }

    changeAbility = (e, abilityID) => {
        
        this.setState({
            activeAbilityID: abilityID
        });
    }

    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-3"> 
                        <h5>Ability Name</h5>
                        <hr />
                        <div className="scrollable">
                            <div className="list-group" role="tablist">
                                {this.state.abilities.map(ability =>
                                    <Link
                                        className={this.state.activeAbilityID === ability.AbilityID ? 'list-group-item list-group-item-action show active' : 'list-group-item list-group-item-action'}
                                        data-toggle="list"
                                        to="#"
                                        aria-controls={ability.Name}
                                        key={ability.AbilityID}
                                        onClick={((e) => this.changeAbility(e, ability.AbilityID))}>
                                        {ability.Name}
                                    </Link>
                                )}
                            </div>
                        </div>
                    </div>
                    <div className="col-9">
                        <h5>Details</h5>
                        <hr />
                        <div className="scrollable">
                            <div className="tab-content">
                                {this.state.abilities.map(ability =>
                                    <div
                                        className={this.state.activeAbilityID === ability.AbilityID ? 'tab-pane fade show active' : 'tab-pane fade'}
                                        role="tabpanel"
                                        key={ability.AbilityID}>

                                        <p>
                                            <i>Description:</i> {ability.Description}
                                        </p>

                                        <p>
                                            <i>Category:</i> {ability.CategoryName}
                                        </p>
                                        
                                        {ability.ManaCost > 0 &&
                                            <p>
                                                <i>Mana Cost:</i> {ability.ManaCost}
                                            </p>
                                        }
                                    </div>
                                )}
                            </div>
                        </div>

                    </div>
                </div>
                
                


            </div>
        );



    }
}
