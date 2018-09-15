import * as React from 'react';
import QuestItemDetails from './QuestItemDetails';

export default class QuestCollectItems extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            KeyItems: props.KeyItems,
            RequiredItems: this.props.RequiredItems,
            RequiredKeyItems: this.props.RequiredKeyItems,

            OnUpdateParent: this.props.OnUpdateParent
        };

        this.handleChange = this.handleChange.bind(this);
        this.addItem = this.addItem.bind(this);
        this.addKeyItem = this.addKeyItem.bind(this);
        this.deleteRequiredItem = this.deleteRequiredItem.bind(this);
        this.handleDeleteKeyItem = this.handleDeleteKeyItem.bind(this);
    }
    
    handleChange(index, resref, quantity) {
        const newRequiredItems = this.state.RequiredItems;
        newRequiredItems[index].Resref = resref;
        newRequiredItems[index].Quantity = quantity;
        
        this.setState({
            RequiredItems: newRequiredItems
        });
    }
    
    addItem() {

        // Only add a new item if the last one has been set.
        const lastIndex = this.state.RequiredItems.length - 1;
        if (lastIndex >= 0) {
            if (this.state.RequiredItems[lastIndex].Resref === '' ||
                this.state.RequiredItems[lastIndex].Quantity <= 0) {
                return;
            }
        }

        const newElement = {
            Resref: '',
            Quantity: 0
        };

        const newRequiredItems = this.state.RequiredItems;
        newRequiredItems.push(newElement);

        this.setState({
            RequiredItems: newRequiredItems
        });
    }

    addKeyItem() {
        
    }

    deleteRequiredItem(index) {
        const newItems = this.state.RequiredItems;
        newItems.splice(index, 1);

        this.setState({
            RequiredItems: newItems
        });
    }

    handleDeleteKeyItem() {
        
    }

    render() {
        return (
            <div>
                <div className="row">&nbsp;</div>
                <div className="row">
                    <label className="center">
                        Collect Items Details:
                    </label>
                </div>
                <div className="row">
                    <button
                        className="btn btn-primary btn-block"
                        onClick={this.addItem}>
                        Add Required Item
                    </button>
                </div>

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

                {this.state.RequiredItems.length <= 0 &&
                    <div className="row">
                        <span className="center">
                            No required items set for this quest...
                        </span>
                    </div>
                }
                
                {this.state.RequiredItems.map((item, index) => {
                    return <QuestItemDetails
                        key={index}
                        Index={index}
                        Resref={item.Resref}
                        Quantity={item.Quantity}
                        OnDeleteCallback={this.deleteRequiredItem}
                        OnChangeCallback={this.handleChange}/>;
                })}

            </div>
        );



    }
}
