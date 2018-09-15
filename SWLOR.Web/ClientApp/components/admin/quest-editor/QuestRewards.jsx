import * as React from 'react';
import QuestItemDetails from './QuestItemDetails';
import NumericInput from 'react-numeric-input';

export default class QuestRewards extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            Gold: 0,
            XP: 0,
            KeyItemID: -1,
            Fame: 0,
            Items: [],
            KeyItems: [],
            EnableControls: false,
            OnUpdateParent: props.OnUpdateParent
        }

        this.handleChange = this.handleChange.bind(this);
        this.handleChangeNumeric = this.handleChangeNumeric.bind(this);
        this.addItemReward = this.addItemReward.bind(this);
        this.handleDelete = this.handleDelete.bind(this);
        this.changeItem = this.changeItem.bind(this);
        this.raiseParentChanges = this.raiseParentChanges.bind(this);
    }

    componentWillUnmount() {

    }

    componentWillReceiveProps(newProps) {
        this.setState({
            Gold: newProps.Rewards == null ? 0 : newProps.Rewards.Gold,
            XP: newProps.Rewards == null ? 0 : newProps.Rewards.XP,
            KeyItemID: newProps.Rewards == null ? -1 : newProps.Rewards.KeyItemID,
            Fame: newProps.Rewards == null ? 0 : newProps.Rewards.Fame,
            Items: newProps.Rewards == null ? [] : newProps.Rewards.RewardItems,
            KeyItems: newProps.KeyItems,
            EnableControls: newProps.EnableControls,
            OnUpdateParent: newProps.OnUpdateParent
        });
    }

    handleChange(event) {
        const name = event.target.name;
        const value = event.target.value;
        
        this.setState({
            [name]: value
        }, this.raiseParentChanges);
    }

    handleChangeNumeric(name, value) {
        this.setState({
            [name]: value
        }, this.raiseParentChanges);
    }

    changeItem(index, resref, quantity) {
        const newItems = this.state.Items;
        newItems[index].Resref = resref;
        newItems[index].Quantity = quantity;

        this.setState({
            Items: newItems
        }, this.raiseParentChanges);
    }

    raiseParentChanges() {
        if (this.state.OnUpdateParent) {
            const reward = {
                Gold: this.state.Gold,
                XP: this.state.XP,
                KeyItemID: this.state.KeyItemID,
                Fame: this.state.Fame,
                RewardItems: this.state.Items,
                KeyItems: this.state.KeyItems
            };

            this.state.OnUpdateParent(reward);
        }
    }

    handleDelete(index) {
        const newItems = this.state.Items;
        newItems.splice(index, 1);

        this.setState({
            Items: newItems
        });
    }

    addItemReward() {

        // Only add a new item if the last one has been set.
        const lastIndex = this.state.Items.length - 1;
        if (lastIndex >= 0) {
            if (this.state.Items[lastIndex].Resref === '' ||
                this.state.Items[lastIndex].Quantity <= 0) {
                return;
            }
        }
        
        const newElement = {
            Resref: '',
            Quantity: 0
        };

        this.setState(prevState => ({
            Items: [...prevState.Items, newElement]
        }));
    }
    
    render() {
        return (
            <div>
                <label htmlFor="gold">Gold:</label>
                <div className="row">
                    <div className="col-12">
                        <NumericInput 
                            id="gold"
                            name="Gold"
                            className="form-control"
                            value={this.state.Gold}
                            min={0}
                            max={9999}
                            onChange={(value) => this.handleChangeNumeric('Gold', value)}
                            disabled={!this.state.EnableControls}
                            required
                            strict>
                        </NumericInput>
                    </div>
                </div>
                <div className="row">&nbsp;</div>
                <label htmlFor="xp">XP:</label>
                <div className="row">
                    <div className="col-12">
                        <NumericInput 
                            id="xp"
                            name="XP"
                            className="form-control"
                            value={this.state.XP}
                            min={0}
                            max={9999}
                            onChange={(value) => this.handleChangeNumeric('XP', value)}
                            disabled={!this.state.EnableControls}
                            required
                            strict>
                        </NumericInput>
                    </div>
                </div>
                <div className="row">&nbsp;</div>
                <label htmlFor="fame">Fame:</label>
                <div className="row">
                    <div className="col-12">
                        <NumericInput 
                            id="fame"
                            name="Fame"
                            className="form-control"
                            value={this.state.Fame}
                            min={0}
                            max={999}
                            onChange={(value) => this.handleChangeNumeric('Fame', value)}
                            disabled={!this.state.EnableControls}
                            required
                            strict>
                        </NumericInput>
                    </div>
                </div>
                <div className="row">&nbsp;</div>
                <label htmlFor="keyItemReward">Key Item:</label>
                <select id="keyItemReward"
                    name="KeyItemID"
                    className="form-control"
                    value={this.state.KeyItemID}
                    onChange={this.handleChange}
                    disabled={!this.state.EnableControls}>
                    {this.state.KeyItems.map(function (keyItem) {
                        return <option
                            key={keyItem.KeyItemID}
                            value={keyItem.KeyItemID}>
                            {keyItem.Name}
                        </option>;
                    })};
                </select>

                <div className="row">&nbsp;</div>

                <label>Item Rewards:</label>
                <button
                    className="btn btn-primary btn-block"
                    onClick={this.addItemReward}
                    disabled={!this.state.EnableControls}>
                    Add Item Reward
                </button>

                <div className="row">&nbsp;</div>

                <div className="row">
                    <div className="col-2">
                        <div className="center">
                            <label>ID</label>
                        </div>
                    </div>
                    <div className="col-4">
                        <div className="center">
                            <label>Resref</label>
                        </div>
                    </div>
                    <div className="col-4">
                        <div className="center">
                            <label>Quantity</label>
                        </div>
                    </div>
                    <div className="col-2">
                        <div className="center">
                            <label>Actions</label>
                        </div>
                    </div>
                </div>

                <div className="row">&nbsp;</div>

                {this.state.Items.length <= 0 &&
                    <div className="row">
                        <span className="center">
                            No item rewards set for this quest...
                        </span>
                    </div>
                }

                {this.state.Items.map((item, index) => {
                    return <QuestItemDetails
                        key={index}
                        Index={index}
                        Resref={item.Resref}
                        Quantity={item.Quantity}
                        OnDeleteCallback={this.handleDelete}
                        OnChangeCallback={this.changeItem}/>;
                })}
            </div>
        );



    }
}
