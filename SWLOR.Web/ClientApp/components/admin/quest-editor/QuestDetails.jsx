import * as React from 'react';
import NumericInput from 'react-numeric-input';

export default class QuestDetails extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            QuestID: -1,
            Name: '',
            JournalTag: '',
            FameRegionID: 0,
            RequiredFameAmount: 0,
            AllowRewardSelection: false,
            RewardGold: 0,
            RewardXP: 0,
            RewardKeyItemID: null,
            RewardFame: 0,
            IsRepeatable: false,
            MapNoteTag: '',
            StartKeyItemID: -1,
            RemoveStartKeyItemAfterCompletion: false,

            KeyItems: [],
            FameRegions: [],

            OnUpdateParent: props.OnUpdateParent
        }
        
        this.handleChange = this.handleChange.bind(this);
        this.raiseParentChanges = this.raiseParentChanges.bind(this);
        this.handleChangeRequiredFame = this.handleChangeRequiredFame.bind(this);
    }
    
    componentWillReceiveProps(newProps) {
        this.setState({
            QuestID: newProps.Details.QuestID,
            Name: newProps.Details.Name,
            JournalTag: newProps.Details.JournalTag,
            FameRegionID: newProps.Details.FameRegionID,
            RequiredFameAmount: newProps.Details.RequiredFameAmount,
            AllowRewardSelection: newProps.Details.AllowRewardSelection,
            RewardGold: newProps.Details.RewardGold,
            RewardXP: newProps.Details.RewardXP,
            RewardKeyItemID: newProps.Details.RewardKeyItemID,
            RewardFame: newProps.Details.RewardFame,
            IsRepeatable: newProps.Details.IsRepeatable,
            MapNoteTag: newProps.Details.MapNoteTag,
            StartKeyItemID: newProps.Details.StartKeyItemID,
            RemoveStartKeyItemAfterCompletion: newProps.Details.RemoveStartKeyItemAfterCompletion,

            KeyItems: newProps.KeyItems,
            FameRegions: newProps.FameRegions,

            OnUpdateParent: newProps.OnUpdateParent
        });
    }
    
    handleChange(event) {
        const target = event.target;
        const value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;
        
        this.setState({
            [name]: value
        }, () => this.raiseParentChanges(name, value));
    }

    handleChangeRequiredFame(value) {
        const propName = 'RequiredFameAmount';
        this.setState({
            [propName]: value
        }, () => this.raiseParentChanges(propName, value));
    }

    raiseParentChanges(name, value) {
        if (this.state.OnUpdateParent) {
            this.state.OnUpdateParent(name, value);
        }
    }

    render() {
        return (
            <div>
                <form>
                    <div className="form-group">
                        <div className="row">
                            <div className="col-10">

                                <label htmlFor="questID">ID:</label>
                                <input type="text" id="questID" name="QuestID"
                                    className="form-control"
                                    value={this.state.QuestID <= -1 ? '' : this.state.QuestID}
                                    onChange={this.handleChange}
                                    disabled={this.state.QuestID === -1 ? true : false}
                                    readOnly={true}>
                                </input>

                                <div className="form-group">
                                    <label htmlFor="name">Name:</label>
                                    <input type="text" id="name" name="Name"
                                           className="form-control"
                                           value={this.state.QuestID === -1 ? '' : this.state.Name}
                                           onChange={this.handleChange}
                                           disabled={this.state.QuestID === -1 ? true : false}
                                           maxLength="100"
                                           required>
                                    </input>
                                    <div className="invalid-tooltip">Please enter a quest name.</div>
                                </div>
                                
                                <label htmlFor="journalTag">Journal Tag:</label>
                                <input type="text" id="journalTag" name="JournalTag"
                                       className="form-control"
                                       value={this.state.QuestID === -1 ? '' : this.state.JournalTag}
                                       onChange={this.handleChange}
                                       disabled={this.state.QuestID === -1 ? true : false}
                                       required
                                       maxLength="32">
                                </input>
                                <label htmlFor="fameRegion">Fame Region:</label>
                                <select id="fameRegion"
                                        name="FameRegionID"
                                        className="form-control"
                                        onChange={this.handleChange}
                                        value={this.state.FameRegionID}
                                        disabled={this.state.QuestID === -1 ? true : false}>
                                    {this.state.FameRegions.map(function (fameRegion) {
                                        return <option
                                            key={fameRegion.FameRegionID}
                                            value={fameRegion.FameRegionID}>
                                            {fameRegion.Name}
                                        </option>;
                                    })};
                                </select>

                                <label htmlFor="requiredFame">Required Fame:</label>
                                <NumericInput
                                    id="requiredFame"
                                    name="RequiredFameAmount"
                                    className="form-control"
                                    min={0}
                                    max={9999}
                                    value={this.state.QuestID === -1 ? 0 : this.state.RequiredFameAmount}
                                    onChange={this.handleChangeRequiredFame}
                                    disabled={this.state.QuestID === -1 ? true : false}
                                    required
                                    strict>
                                </NumericInput>
                                <label htmlFor="mapNoteTag">Map Note Tag:</label>
                                <input type="text" id="mapNoteTag" name="MapNoteTag"
                                       className="form-control"
                                       value={this.state.QuestID === -1 ? '' : this.state.MapNoteTag}
                                       onChange={this.handleChange}
                                       disabled={this.state.QuestID === -1 ? true : false}
                                       maxLength="32">
                                </input>
                                <label htmlFor="selectStartingKeyItem">Starting Key Item:</label>
                                <select id="selectStartingKeyItem"
                                    className="form-control"
                                    name="StartKeyItemID"
                                    onChange={this.handleChange}
                                    value={this.state.StartKeyItemID}
                                    disabled={this.state.QuestID === -1 ? true : false}>
                                    {this.state.KeyItems.map(function(keyItem) {
                                        return <option
                                            key={keyItem.KeyItemID}
                                            value={keyItem.KeyItemID}>
                                            {keyItem.Name}
                                        </option>;
                                    })};
                                </select>


                            </div>

                            <div className="col-2">

                                <label htmlFor="optionsList">Options:</label>
                                <fieldset id="optionsList">
                                    <div className="form-check">
                                        <label className="form-check-label">
                                            <input
                                                name="AllowRewardSelection"
                                                className="form-check-input"
                                                value=""
                                                checked={this.state.AllowRewardSelection}
                                                onChange={this.handleChange}
                                                disabled={this.state.QuestID === -1 ? true : false}
                                                type="checkbox" />
                                            Allow Reward Selection
                                        </label>
                                        <label className="form-check-label">
                                            <input
                                                name="IsRepeatable"
                                                className="form-check-input"
                                                value=""
                                                checked={this.state.IsRepeatable}
                                                onChange={this.handleChange}
                                                disabled={this.state.QuestID === -1 ? true : false}
                                                type="checkbox" />
                                            Repeatable
                                        </label>
                                        <label className="form-check-label">
                                            <input
                                                name="RemoveStartKeyItemAfterCompletion"
                                                className="form-check-input"
                                                value=""
                                                checked={this.state.RemoveStartKeyItemAfterCompletion}
                                                onChange={this.handleChange}
                                                disabled={this.state.QuestID === -1 ? true : false}
                                                type="checkbox" />
                                            Remove Starting Key Item
                                        </label>
                                    </div>
                                </fieldset>
                            </div>
                        </div>

                        <div className="row">&nbsp;</div>

                    </div>

                </form>

            </div>
        );



    }
}
