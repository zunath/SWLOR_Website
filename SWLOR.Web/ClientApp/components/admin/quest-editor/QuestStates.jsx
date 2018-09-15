import * as React from 'react';
import QuestKillTarget from './QuestKillTarget';
import QuestTalkToNPC from './QuestTalkToNPC';
import QuestUseObject from './QuestUseObject';
import QuestCollectItems from './QuestCollectItems';
import QuestExploreArea from './QuestExploreArea';
import QuestUseItem from './QuestUseItem';
import NumericInput from 'react-numeric-input';

export default class QuestStates extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            QuestTypes: [],
            EnableControls: false,
            QuestStates: [],
            NPCGroups: [],
            KeyItems: [],

            OnUpdateParent: props.OnUpdateParent
        }

        this.addQuestState = this.addQuestState.bind(this);
        this.handleChange = this.handleChange.bind(this);
        this.handleChangeNumeric = this.handleChangeNumeric.bind(this);
        this.handleMoveUp = this.handleMoveUp.bind(this);
        this.handleMoveDown = this.handleMoveDown.bind(this);
        this.handleDelete = this.handleDelete.bind(this);
        this.raiseParentChange = this.raiseParentChange.bind(this);
    }

    componentWillReceiveProps(newProps) {
        this.setState({
            QuestTypes: newProps.QuestTypes,
            EnableControls: newProps.EnableControls,
            QuestStates: newProps.QuestStates,
            NPCGroups: newProps.NPCGroups,

            OnUpdateParent: newProps.OnUpdateParent
        });
    }

    handleChange(event, index) {
        const name = event.target.name;
        const value = event.target.value;
        
        const newQuestStates = this.state.QuestStates;
        newQuestStates[index][name] = value;

        this.setState({
            QuestStates: newQuestStates
        }, this.raiseParentChange);
    }

    handleChangeNumeric(index, name, value) {
        const newQuestStates = this.state.QuestStates;
        newQuestStates[index][name] = value;

        this.setState({
            QuestStates: newQuestStates
        }, this.raiseParentChange);
    }

    raiseParentChange() {
        if (this.state.OnUpdateParent) {
            this.state.OnUpdateParent(this.state.QuestStates);
        }
    }

    handleMoveUp(event, index) {
        const newQuestStates = this.state.QuestStates;
        let newIndex = index - 1;
        if (newIndex < 0) newIndex = 0;

        const element = newQuestStates[index];
        newQuestStates.splice(index, 1);
        newQuestStates.splice(newIndex, 0, element);

        this.setState({
            QuestStates: newQuestStates
        });
    }

    handleMoveDown(event, index) {
        const newQuestStates = this.state.QuestStates;
        let newIndex = index + 1;
        if (newIndex > this.state.QuestStates.length - 1) newIndex = this.state.QuestStates.length - 1;

        const element = newQuestStates[index];
        newQuestStates.splice(index, 1);
        newQuestStates.splice(newIndex, 0, element);

        this.setState({
            QuestStates: newQuestStates
        });
    }

    handleDelete(event, index) {
        const newQuestStates = this.state.QuestStates;
        newQuestStates.splice(index, 1);

        this.setState({
            QuestStates: newQuestStates
        });
    }
    
    addQuestState() {
        const newElement = {
            QuestTypeID: 0,
            JournalStateID: 0,
            KillTargets: [],
            RequiredItems: [],
            RequiredKeyItems: []
        };

        this.setState(prevState => ({
            QuestStates: [...prevState.QuestStates, newElement]
        }));
    }

    render() {
        return (
            <div>
                <div className="row">
                    <button
                        className="btn btn-primary btn-block"
                        onClick={this.addQuestState}
                        disabled={!this.state.EnableControls}>
                        Add Quest State
                    </button>
                </div>

                <div className="row">&nbsp;</div>

                <div className="row">
                    <div className="col-1">
                        <div className="center">
                            <label>Move</label>
                        </div>
                    </div>
                    <div className="col-2">
                        <div className="center">
                            <label>Order</label>
                        </div>
                    </div>
                    <div className="col-4">
                        <div className="center">
                            <label>Type</label>
                        </div>
                    </div>
                    <div className="col-2">
                        <div className="center">
                            <label>Journal State ID</label>
                        </div>
                    </div>
                    <div className="col-3">
                        <div className="center">
                            <label>Actions</label>
                        </div>
                    </div>
                </div>

                {this.state.QuestStates.length <= 0 &&
                    <div className="row">
                        <span className="center">
                            No states set for this quest...
                        </span>
                    </div>
                }

                {this.state.QuestStates.map((questState, index) => {

                    return <div key={index}>

                        <div className="card">
                            <div className="card-body">
                                <div className="row">
                                    <div className="col-1">
                                        <div className="row">
                                            <button
                                                className="btn-sm btn-outline-primary h-25"
                                                onClick={(event) => this.handleMoveUp(event, index)}>
                                                <i className="fa fa-caret-up fa-lg"></i>
                                            </button>
                                            <button
                                                className="btn-sm btn-outline-primary h-25"
                                                onClick={(event) => this.handleMoveDown(event, index)}>
                                                <i className="fa fa-caret-down fa-lg"></i>
                                            </button>
                                        </div>
                                    </div>
                                    <div className="col-2">
                                        <input type="text"
                                            className="form-control"
                                            readOnly={true}
                                            value={index + 1} />

                                    </div>
                                    <div className="col-4">
                                        <select id="selectQuestType"
                                            name="QuestTypeID"
                                            className="form-control"
                                            disabled={!this.state.EnableControls}
                                            onChange={(event) => this.handleChange(event, index)}
                                            value={questState.QuestTypeID}>
                                            {this.state.QuestTypes.map((questType) => {
                                                return <option
                                                    key={questType.QuestTypeID}
                                                    value={questType.QuestTypeID}>
                                                    {questType.Name}
                                                </option>;
                                            })};
                                        </select>
                                    </div>
                                    <div className="col-2">
                                        <NumericInput
                                            className="form-control"
                                            name="JournalStateID"
                                            value={questState.JournalStateID}
                                            min={0}
                                            max={9999}
                                            onChange={(value) => this.handleChangeNumeric(index, 'JournalStateID', value)}
                                            placeholder="Journal State ID"
                                            required
                                            strict>
                                        </NumericInput>
                                    </div>
                                    <div className="col-3">
                                        <button className="btn btn-outline-primary btn-block" onClick={(event) => this.handleDelete(event, index)}>
                                            Delete
                                        </button>
                                    </div>
                                </div>

                                <div className="row">
                                    <div className="col-11 offset-1">
                                        {questState.QuestTypeID == 1 &&
                                            <QuestKillTarget
                                                NPCGroups={this.state.NPCGroups}
                                                KillTargets={questState.KillTargets} />}
                                        {questState.QuestTypeID == 2 &&
                                            <QuestTalkToNPC />}
                                        {questState.QuestTypeID == 3 &&
                                            <QuestUseObject />}
                                        {questState.QuestTypeID == 4 &&
                                            <QuestCollectItems
                                                KeyItems={this.state.KeyItems}
                                                RequiredItems={questState.RequiredItems}
                                                RequiredKeyItems={questState.RequiredKeyItems}/>}
                                        {questState.QuestTypeID == 5 &&
                                            <QuestExploreArea />}
                                        {questState.QuestTypeID == 6 &&
                                            <QuestUseItem />}
                                    </div>

                                </div>
                                <div className="row">&nbsp;</div>
                            </div>
                        </div>
                        <div className="row">&nbsp;</div>
                    </div>;
                })}

            </div>
        );



    }
}
