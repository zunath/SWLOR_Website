import * as React from 'react';

export default class QuestPrerequisites extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            PrerequisiteQuestIDs: [],
            Quests: [],
            EnableControls: false,
            OnUpdateParent: props.OnUpdateParent
        }

        this.addPrerequisite = this.addPrerequisite.bind(this);
        this.buildDetail = this.buildDetail.bind(this);
        this.handleChange = this.handleChange.bind(this);
        this.handleDelete = this.handleDelete.bind(this);
        this.raiseParentChanges = this.raiseParentChanges.bind(this);
    }

    componentWillUnmount() {

    }

    componentWillReceiveProps(newProps) {
        this.setState({
            PrerequisiteQuestIDs: newProps.PrerequisiteQuestIDs,
            Quests: newProps.Quests,
            EnableControls: newProps.EnableControls,
            OnUpdateParent: newProps.OnUpdateParent
        });
    }

    addPrerequisite() {

        // Only add a new prereq if the last one has been set.
        const lastIndex = this.state.PrerequisiteQuestIDs.length - 1;
        if (lastIndex >= 0) {
            if (this.state.PrerequisiteQuestIDs[lastIndex] <= 0) {
                return;
            }
        }
        
        this.setState(prevState => ({
            PrerequisiteQuestIDs: [...prevState.PrerequisiteQuestIDs, 0]
        }));
    }

    handleChange(event, prereqQuestID, index) {
        const newPrerequisites = this.state.PrerequisiteQuestIDs;
        newPrerequisites[index] = event.target.value;

        this.setState({
            PrerequisiteQuestIDs: newPrerequisites
        }, this.raiseParentChanges);
    }

    raiseParentChanges() {
        if (this.state.OnUpdateParent) {
            this.state.OnUpdateParent(this.state.PrerequisiteQuestIDs);
        }
    }

    handleDelete(event, index) {
        const newPrerequisites = this.state.PrerequisiteQuestIDs;
        newPrerequisites.splice(index, 1);
        
        this.setState({
            PrerequisiteQuestIDs: newPrerequisites
        });
    }
    
    buildDetail(prereqQuestID, index) {
        return <div key={index}>
            <div className="row">
                <div className="col-2">
                    <input type="text"
                        className="form-control"
                        readOnly={true}
                        value={index+1} />

                </div>
                <div className="col-8">
                    <select id="selectQuest"
                        name="prereqQuestID"
                        className="form-control"
                        disabled={!this.state.EnableControls}
                        onChange={(event) => this.handleChange(event, prereqQuestID, index)}
                        value={prereqQuestID}>
                        {this.state.Quests.map((quest) => {
                            return <option
                                key={quest.QuestID}
                                value={quest.QuestID}>
                                {quest.Name}
                            </option>;
                        })};
                     </select>
                </div>
                <div className="col-2">
                    <button className="btn btn-outline-primary" onClick={(event) => this.handleDelete(event, index)}>
                        Delete
                    </button>

                </div>

            </div>

            <div className="row">&nbsp;</div>
        </div>;

    }

    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-12">
                        <button
                            className="btn btn-primary btn-block"
                            onClick={this.addPrerequisite}
                            disabled={!this.state.EnableControls}>
                            Add Prerequisite
                        </button>
                    </div>
                </div>

                <div className="row">&nbsp;</div>

                <div className="row">
                    <div className="col-2">
                        <div className="center">
                            <label>ID</label>
                        </div>
                    </div>
                    <div className="col-8">
                        <div className="center">
                            <label>Quest</label>
                        </div>
                    </div>
                    <div className="col-2">
                        <div className="center">
                            <label>Actions</label>
                        </div>
                    </div>
                </div>

                <div className="row">&nbsp;</div>

                {this.state.PrerequisiteQuestIDs.length <= 0 &&
                    <div className="row">
                        <span className="center">
                            No prerequisites set for this quest...
                        </span>
                    </div>
                }

                {this.state.PrerequisiteQuestIDs.map((prereqQuestID, index) => {
                    return this.buildDetail(prereqQuestID, index);
                })}
            </div>
        );



    }
}
