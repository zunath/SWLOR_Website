import * as React from 'react';
import { Link } from 'react-router-dom';
import * as dotnetify from 'dotnetify';
import QuestDetails from './QuestDetails';
import QuestPrerequisites from './QuestPrerequisites';
import QuestStates from './QuestStates';
import QuestRewards from './QuestRewards';
import Notifier from '../../shared/Notifier';
import Modal from '../../shared/Modal';

export default class QuestEditor extends React.Component {
    constructor(props) {
        super(props);
        this.vm = dotnetify.react.connect('QuestEditorViewModel', this);
        this.dispatch = state => this.vm.$dispatch(state);
        
        this.state = {
            activeTab: '1',
            Quests: [],
            ActiveQuestID: 0,
            ActiveQuest: {},
            KeyItems: [],
            FameRegions: [],
            QuestTypes: [],
            NPCGroups: [],
            
            ShowNotification: false,
            NotificationMessage: '',
            NotificationSuccessful: false,

            ModalHeader: '',
            ModalBody: '',
            ModalActionText: '',
            ModalAction: null
        }

        this.handleAddQuest = this.handleAddQuest.bind(this);
        this.handleChangeQuest = this.handleChangeQuest.bind(this);
        this.handleSaveChanges = this.handleSaveChanges.bind(this);
        this.handleDiscardChanges = this.handleDiscardChanges.bind(this);
        this.handleDeleteQuest = this.handleDeleteQuest.bind(this);
        this.receiveDetailChanges = this.receiveDetailChanges.bind(this);
        this.receivePrerequisiteChanges = this.receivePrerequisiteChanges.bind(this);
        this.receiveQuestStateChanges = this.receiveQuestStateChanges.bind(this);
        this.receiveQuestRewardsChanges = this.receiveQuestRewardsChanges.bind(this);
        this.confirmDiscardChanges = this.confirmDiscardChanges.bind(this);
        this.confirmDeleteQuest = this.confirmDeleteQuest.bind(this);
        this.clearNotification = this.clearNotification.bind(this);
    }
    
    componentWillUnmount() {
        this.vm.$destroy();
    }
    
    handleChangeQuest(event) {
        const questID = event.target.value;
        if (this.state.ActiveQuestID === -2) {

            const newQuests = this.state.Quests;
            for (let i = newQuests.length - 1; i >= 0; --i) {
                if (newQuests[i].QuestID === -2) {
                    newQuests.splice(i, 1);
                }
            }

            this.setState({
                ActiveQuestID: questID,
                Quests: newQuests
            }, this.dispatch({ ChangeQuest: questID}));
        }
        else {
            this.setState({
                ActiveQuestID: questID
            }, this.dispatch({ ChangeQuest: questID }));
        }
    }
    
    handleAddQuest() {
        const newQuests = this.state.Quests;
        for (let i = newQuests.length - 1; i >= 0; --i) {
            if (newQuests[i].QuestID === -2) {
                newQuests.splice(i, 1);
            }
        }
        const newQuest = {
            QuestID: -2,
            Name: '<New Quest (UNSAVED)>'
        };
        newQuests.push(newQuest);

        this.setState({
            Quests: newQuests,
            ActiveQuestID: -2
        }, this.dispatch({ ChangeQuest: newQuest.QuestID }));
        
    }

    handleSaveChanges() {
        this.dispatch({
            SaveChanges: this.state.ActiveQuest
        });
    }

    handleDeleteQuest() {
        this.setState({
            ModalHeader: 'Delete Quest?',
            ModalBody: 'Are you sure you want to delete this quest? This is action irreversible!',
            ModalActionText: 'Delete Quest',
            ModalAction: this.confirmDeleteQuest
        });
    }

    handleDiscardChanges() {
        this.setState({
            ModalHeader: 'Discard Changes?',
            ModalBody: 'Are you sure you want to discard all of your changes?',
            ModalActionText: 'Discard Changes',
            ModalAction: this.confirmDiscardChanges
        });
    }

    receiveDetailChanges(name, value) {
        const newActiveQuest = this.state.ActiveQuest;
        newActiveQuest[name] = value;

        this.setState({
            ActiveQuest: newActiveQuest
        });
    }

    receivePrerequisiteChanges(prerequisiteQuestIDs) {
        const newActiveQuest = this.state.ActiveQuest;
        newActiveQuest.PrerequisiteQuestIDs = prerequisiteQuestIDs;

        this.setState({
            ActiveQuest: newActiveQuest
        });
    }

    receiveQuestStateChanges(questStates) {
        const newActiveQuest = this.state.ActiveQuest;
        newActiveQuest.QuestStates = questStates;

        this.setState({
            ActiveQuest: newActiveQuest
        });
    }

    receiveQuestRewardsChanges(rewards) {
        const newActiveQuest = this.state.ActiveQuest;
        newActiveQuest.Rewards = rewards;

        this.setState({
            ActiveQuest: newActiveQuest
        });
    }

    confirmDeleteQuest() {
        if (this.state.ActiveQuestID === -2) {
            const newQuests = this.state.Quests;
            for (let i = newQuests.length - 1; i >= 0; --i) {
                if (newQuests[i].QuestID === -2) {
                    newQuests.splice(i, 1);
                }
            }
            this.setState({
                Quests: newQuests,
                ActiveQuestID: -1
            }, () => { this.dispatch({ ChangeQuest: -1 })});
        }
        else {
            this.dispatch({ DeleteQuest: this.state.ActiveQuestID });
        }
    }

    confirmDiscardChanges() {
        if (this.state.ActiveQuestID === -2) {
            this.handleAddQuest();
        }
        else {
            this.dispatch({ DiscardChanges: this.state.ActiveQuestID });
        }
        
    }

    clearNotification() {
        this.setState({ ShowNotification: false });
    }


    render() {
        return (
            <div>
                <Notifier
                    ShowNotification={this.state.ShowNotification}
                    NotificationMessage={this.state.NotificationMessage}
                    NotificationSuccessful={this.state.NotificationSuccessful}
                    OnOpened={this.clearNotification} />

                <Modal
                    ModalID="confirmModal"
                    Header={this.state.ModalHeader}
                    Body={this.state.ModalBody}
                    ActionText={this.state.ModalActionText}
                    Action={this.state.ModalAction} />


                <label htmlFor="selectQuest">Quest:</label>
                <div className="row">
                    <div className="col-10">
                        <select id="selectQuest"
                                className="form-control"
                                onChange={this.handleChangeQuest}
                                value={this.state.ActiveQuestID}>
                            {this.state.Quests.map(function (quest) {
                                return <option
                                           key={quest.QuestID}
                                           value={quest.QuestID}>
                                    {quest.QuestID > -1 && `#${quest.QuestID} - ${quest.Name}`}
                                    {quest.QuestID <= -1 && '' + quest.Name}
                                       </option>;
                            })};
                        </select>
                    </div>
                    <div className="col-2">
                        <div className="btn-group">
                            <button
                                className="btn btn-primary"
                                onClick={this.handleAddQuest}>
                                New
                            </button>
                            <span>&nbsp;</span>
                            <button
                                className="btn btn-outline-primary"
                                data-target="#confirmModal"
                                data-toggle="modal"
                                onClick={this.handleDeleteQuest}
                                disabled={this.state.ActiveQuestID === -1 ? true : false}>
                                Delete
                            </button>
                        </div>
                        
                    </div>

                </div>

                <div className="row">&nbsp;</div>

                <div className="row">

                    <div className="col-12">

                        <ul className="nav nav-tabs" role="tablist">
                            <li className="nav-item">
                                <Link className="nav-link active" data-toggle="tab" to="#nav-details" role="tab">Details</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" data-toggle="tab" to="#nav-prerequisites" role="tab">Prerequisites</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" data-toggle="tab" to="#nav-states" role="tab">States</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" data-toggle="tab" to="#nav-rewards" role="tab">Rewards</Link>
                            </li>
                        </ul>

                    </div>

                </div>

                <div className="row">

                    <div className="col-12">

                        <div className="tab-content">
                            <div className="row">&nbsp;</div>
                            <div className="tab-pane active" id="nav-details" role="tabpanel">
                                <QuestDetails
                                    Details={this.state.ActiveQuest}
                                    KeyItems={this.state.KeyItems}
                                    FameRegions={this.state.FameRegions}
                                    OnUpdateParent={this.receiveDetailChanges}/>
                            </div>
                            <div className="tab-pane" id="nav-prerequisites" role="tabpanel">
                                <QuestPrerequisites
                                    PrerequisiteQuestIDs={this.state.ActiveQuest.PrerequisiteQuestIDs}
                                    Quests={this.state.Quests}
                                    EnableControls={this.state.ActiveQuestID ===-1 ? false : true}
                                    OnUpdateParent={this.receivePrerequisiteChanges}/>
                            </div>
                            <div className="tab-pane" id="nav-states" role="tabpanel">
                                <QuestStates 
                                    QuestTypes={this.state.QuestTypes}
                                    EnableControls={this.state.ActiveQuestID === -1 ? false : true}
                                    QuestStates={this.state.ActiveQuest.QuestStates}
                                    NPCGroups={this.state.NPCGroups}
                                    KeyItems={this.state.KeyItems}
                                    OnUpdateParent={this.receiveQuestStateChanges}/>
                            </div>
                            <div className="tab-pane" id="nav-rewards" role="tabpanel">
                                <QuestRewards
                                    Rewards={this.state.ActiveQuest.Rewards}
                                    KeyItems={this.state.KeyItems}
                                    EnableControls={this.state.ActiveQuestID === -1 ? false : true}
                                    OnUpdateParent={this.receiveQuestRewardsChanges}/>
                            </div>
                        </div>
                    </div>

                </div>

                <div className="row">&nbsp;</div>
                <div className="row">

                    <div className="col-5">
                        <button
                            type="button"
                            className="btn btn-primary btn-block"
                            disabled={this.state.ActiveQuestID === -1 ? true : false}
                            onClick={this.handleSaveChanges}>
                            Save Changes
                        </button>
                    </div>
                    <div className="col-5">
                        <button
                            type="button"
                            className="btn btn-outline-primary btn-block"
                            disabled={this.state.ActiveQuestID === -1 ? true : false}
                            onClick={this.handleDiscardChanges}
                            data-target="#confirmModal"
                            data-toggle="modal">
                            Discard Changes
                        </button>
                        &nbsp;
                    </div>
                </div>



            </div>
        );



    }
}
