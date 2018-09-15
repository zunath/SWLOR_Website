import * as React from 'react';
import { Link } from 'react-router-dom';
import * as dotnetify from 'dotnetify';
import Notifier from '../../shared/Notifier';
import Modal from '../../shared/Modal';
import LootTableItem from './LootTableItem';

export default class LootTableEditor extends React.Component {
    constructor(props) {
        super(props);
        this.vm = dotnetify.react.connect('LootTableEditorViewModel', this);
        this.dispatch = state => this.vm.$dispatch(state);

        this.state = {
            LootTableOptions: [],

            ShowNotification: false,
            NotificationMessage: '',
            NotificationSuccessful: false,

            ModalHeader: '',
            ModalBody: '',
            ModalActionText: '',
            ModalAction: null
        }
        
        this.handleChangeLootTable = this.handleChangeLootTable.bind(this);

        this.handleAddLootTable = this.handleAddLootTable.bind(this);
        this.handleSaveChanges = this.handleSaveChanges.bind(this);
        this.handleDeleteLootTable = this.handleDeleteLootTable.bind(this);
        this.handleDiscardChanges = this.handleDiscardChanges.bind(this);
        this.handleChangeName = this.handleChangeName.bind(this);
        this.confirmDiscardChanges = this.confirmDiscardChanges.bind(this);
        this.confirmDeleteLootTable = this.confirmDeleteLootTable.bind(this);

        this.addItem = this.addItem.bind(this);

        this.renderItems = this.renderItems.bind(this);
        this.receiveItemChanges = this.receiveItemChanges.bind(this);
        this.receiveDeleteItem = this.receiveDeleteItem.bind(this);
        this.clearNotification = this.clearNotification.bind(this);

        this.getLootTableName = this.getLootTableName.bind(this);
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }
    
    handleChangeLootTable(event) {
        const lootTableID = event.target.value;

        if (this.state.SelectedLootTableID === -2) {

            const newLootTables = this.state.LootTableOptions;
            for (let i = newLootTables.length - 1; i >= 0; --i) {
                if (newLootTables[i].LootTableID === -2) {
                    newLootTables.splice(i, 1);
                }
            }

            this.setState({
                SelectedLootTableID: lootTableID,
                LootTableOptions: newLootTables
            }, this.dispatch({ ChangeLootTable: lootTableID }));
        }
        else {
            this.setState({
                SelectedLootTableID: lootTableID
            }, this.dispatch({ ChangeLootTable: lootTableID }));
        }
    }

    handleChangeName(event) {
        const lt = this.state.ActiveLootTable;
        lt.Name = event.target.value;

        this.setState({
            ActiveLootTable: lt
        });
    }

    handleAddLootTable() {
        const newLootTables = this.state.LootTableOptions;
        for (let i = newLootTables.length - 1; i >= 0; --i) {
            if (newLootTables[i].LootTableID === -2) {
                newLootTables.splice(i, 1);
            }
        }
        const newLootTable = {
            LootTableID: -2,
            Name: '<New Loot Table (UNSAVED)>'
        };
        newLootTables.push(newLootTable);

        this.setState({
            LootTableOptions: newLootTables,
            SelectedLootTableID: -2
        }, this.dispatch({ ChangeLootTable: newLootTable.LootTableID }));

    }

    handleSaveChanges() {
        this.dispatch({
            SaveChanges: this.state.ActiveLootTable
        });
    }

    handleDeleteLootTable() {
        this.setState({
            ModalHeader: 'Delete Loot Table?',
            ModalBody: 'Are you sure you want to delete this loot table? This is action irreversible!',
            ModalActionText: 'Delete Loot Table',
            ModalAction: this.confirmDeleteLootTable
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

    addItem() {
        const lt = this.state.ActiveLootTable;
        const items = lt.LootTableItems;
        items.push({
            Resref: '',
            MaxQuantity: 1,
            Weight: 10,
            IsActive: true
        });

        this.setState({
            ActiveLootTable: lt
        });
    }

    confirmDeleteLootTable() {
        if (this.state.SelectedLootTableID === -2) {
            const newLootTables = this.state.LootTableOptions;
            for (let i = newLootTables.length - 1; i >= 0; --i) {
                if (newLootTables[i].LootTableID === -2) {
                    newLootTables.splice(i, 1);
                }
            }
            this.setState({
                LootTableOptions: newLootTables,
                SelectedLootTableID: -1
            }, () => { this.dispatch({ ChangeLootTable: -1 }) });
        }
        else {
            this.dispatch({ DeleteLootTable: this.state.SelectedLootTableID });
        }
    }

    confirmDiscardChanges() {
        if (this.state.SelectedLootTableID === -2) {
            this.handleAddLootTable();
        }
        else {
            this.dispatch({ DiscardChanges: this.state.SelectedLootTableID });
        }
    }

    receiveItemChanges(record) {
        const item = this.state.ActiveLootTable.LootTableItems[record.RecordID];

        item.Resref = record.Resref;
        item.MaxQuantity = record.MaxQuantity;
        item.Weight = record.Weight;
        item.IsActive = record.IsActive;

        const lootTable = this.state.ActiveLootTable;
        lootTable.LootTableItems[record.RecordID] = item;

        this.setState({
            ActiveLootTable: lootTable
        });
    }

    receiveDeleteItem(recordID) {
        const lt = this.state.ActiveLootTable;
        const items = lt.LootTableItems;
        items.splice(recordID, 1);

        this.setState({
            ActiveLootTable: lt
        });
    }

    renderItems() {
        if (!this.state.ActiveLootTable || !this.state.ActiveLootTable.LootTableItems) {
            return <div>No items set for this loot table.</div>;
        }
        else {
            return (
                <div>
                    {this.state.ActiveLootTable.LootTableItems.map((lti, index) =>
                        <LootTableItem
                            key={index}
                            RecordID={index}
                            Resref={lti.Resref}
                            MaxQuantity={lti.MaxQuantity}
                            Weight={lti.Weight}
                            IsActive={lti.IsActive}
                            OnUpdateParent={this.receiveItemChanges}
                            OnDelete={this.receiveDeleteItem}/>
                    )}
                </div>
            );
        }
    }

    clearNotification() {
        this.setState({ ShowNotification: false });
    }

    getLootTableName() {
        if (this.state.ActiveLootTable) {
            if (this.state.ActiveLootTable.Name) {
                return this.state.ActiveLootTable.Name;
            }
        }

        return '';
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
                    ActionCallback={this.state.ModalAction} />

                <label htmlFor="selectLootTable">Loot Table:</label>
                <div className="row">
                    <div className="col-10">
                        <select id="selectLootTable"
                            className="form-control"
                            onChange={this.handleChangeLootTable}
                            value={this.state.SelectedLootTableID}>
                            {this.state.LootTableOptions.map(function (lt) {
                                return <option
                                    key={lt.LootTableID}
                                    value={lt.LootTableID}>
                                    {lt.LootTableID > -1 && `#${lt.LootTableID} - ${lt.Name}`}
                                    {lt.LootTableID <= -1 && '' + lt.Name}
                                </option>;
                            })};
                        </select>
                    </div>
                    <div className="col-2">
                        <div className="btn-group">
                            <button
                                className="btn btn-primary"
                                onClick={this.handleAddLootTable}>
                                New
                            </button>
                            <span>&nbsp;</span>
                            <button
                                className="btn btn-outline-primary"
                                data-target="#confirmModal"
                                data-toggle="modal"
                                onClick={this.handleDeleteLootTable}
                                disabled={this.state.SelectedLootTableID === -1 ? true : false}>
                                Delete
                            </button>
                        </div>

                    </div>

                </div>

                <div className="row">&nbsp;</div>

                <div className="row">
                    <div className="col-1">
                        <label className="pt-1">Name:</label>
                    </div>
                    <div className="col-10">
                        <input
                            type="text"
                            className="form-control"
                            value={this.state.ActiveLootTable && this.state.ActiveLootTable.Name ? this.state.ActiveLootTable.Name : ''}
                            disabled={this.state.SelectedLootTableID === -1 ? true : false}
                            onChange={this.handleChangeName}
                            maxLength="64" />
                    </div>

                </div>


                <div className="row">&nbsp;</div>

                <div className="row">
                    <div className="col">
                        <input
                            type="button"
                            className="btn btn-primary btn-block"
                            value="Add Item"
                            disabled={this.state.SelectedLootTableID === -1 ? true : false}
                            onClick={this.addItem} />
                    </div>

                </div>

                <div className="row">&nbsp;</div>

                <div className="row">
                    <div className="col-6 center">
                        <b>Resref</b>
                        <hr />
                    </div>

                    <div className="col-2 center">
                        <b>Max Quantity</b>
                        <hr />
                    </div>

                    <div className="col-2 center">
                        <b>Weighted Chance</b>
                        <hr />
                    </div>
                    <div className="col-1 center">
                        <b>Is Active</b>
                        <hr />
                    </div>
                    <div className="col-1 center">
                        <b>Actions</b>
                    </div>

                </div>

                {this.renderItems()}


                <div className="row">&nbsp;</div>
                <div className="row">

                    <div className="col-5">
                        <button
                            type="button"
                            className="btn btn-primary btn-block"
                            disabled={this.state.SelectedLootTableID === -1 ? true : false}
                            onClick={this.handleSaveChanges}>
                            Save Changes
                        </button>
                    </div>
                    <div className="col-5">
                        <button
                            type="button"
                            className="btn btn-outline-primary btn-block"
                            disabled={this.state.SelectedLootTableID === -1 ? true : false}
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
