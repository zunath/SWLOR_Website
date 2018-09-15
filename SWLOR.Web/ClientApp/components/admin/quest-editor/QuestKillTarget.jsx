import * as React from 'react';
import NumericInput from 'react-numeric-input';

export default class QuestKillTarget extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            NPCGroups: this.props.NPCGroups,
            KillTargets: this.props.KillTargets
        }

        this.handleAdd = this.handleAdd.bind(this);
        this.handleChange = this.handleChange.bind(this);
        this.handleChangeQuantity = this.handleChangeQuantity.bind(this);
        this.handleDelete = this.handleDelete.bind(this);
    }

    componentWillReceiveProps(newProps) {
        this.setState({
            NPCGroups: newProps.NPCGroups,
            KillTargets: newProps.KillTargets
        });
    }

    handleAdd() {
        const newElement = {
            NPCGroupID: 1,
            Quantity: 0
        };

        const newKillTargets = this.state.KillTargets;
        newKillTargets.push(newElement);

        this.setState({
            KillTargets: newKillTargets
        });
    }


    handleChange(event, index) {
        const newKillTargets = this.state.KillTargets;
        newKillTargets[index][event.target.name] = event.target.value;

        this.setState({
            KillTargets: newKillTargets
        });
    }

    handleChangeQuantity(index, value) {
        const newKillTargets = this.state.KillTargets;
        newKillTargets[index].Quantity = value;

        this.setState({
            KillTargets: newKillTargets
        });
    }

    handleDelete(index) {
        const newKillTargets = this.state.KillTargets;
        newKillTargets.splice(index, 1);

        this.setState({
            KillTargets: newKillTargets
        });
    }

    render() {
        return (
            <div>
                <div className="row">&nbsp;</div>
                <div className="row">
                    <label className="center">
                        Kill Enemies Details:
                </label>
                </div>
                <div className="row">
                    <button
                        className="btn btn-primary btn-block"
                        onClick={this.handleAdd}>
                        Add Kill Target
                </button>
                </div>
                <div className="row">&nbsp;</div>

                <div className="row">
                    <div className="col-2">
                        ID
                </div>
                    <div className="col-6">
                        NPC Group
                </div>
                    <div className="col-2">
                        Quantity
                </div>
                    <div className="col-2">
                        Actions
                </div>
                </div>
                <div className="row">&nbsp;</div>

                {this.state.KillTargets.map((killTarget, index) => {
                    return <div key={index}>
                        <div className="row">
                            <div className="col-2">
                                <input type="text"
                                    className="form-control"
                                    readOnly={true}
                                    value={index + 1} />
                            </div>
                            <div className="col-6">
                                <select id="selectNPCGroup"
                                    name="NPCGroupID"
                                    className="form-control"
                                    onChange={(event) => this.handleChange(event, index)}
                                    value={killTarget.NPCGroupID}>
                                    {this.state.NPCGroups.map((npcGroup) => {
                                        return <option
                                            key={npcGroup.NPCGroupID}
                                            value={npcGroup.NPCGroupID}>
                                            {npcGroup.Name}
                                        </option>;
                                    })};
                            </select>
                            </div>
                            <div className="col-2">
                                <NumericInput 
                                    className="form-control"
                                    name="Quantity"
                                    value={killTarget.Quantity}
                                    onChange={(value) => this.handleChangeQuantity(index, value)}
                                    min={0}
                                    max={999}
                                    required
                                    strict />
                            </div>
                            <div className="col-2">
                                <button className="btn btn-outline-primary btn-block"
                                    onClick={() => this.handleDelete(index)}>
                                    Delete
                            </button>
                            </div>

                        </div>
                    </div>;
                })}
            </div>
        );



    }
}
