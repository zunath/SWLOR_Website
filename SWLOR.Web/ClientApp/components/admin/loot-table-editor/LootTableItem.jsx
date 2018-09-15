import * as React from 'react';
import NumericInput from 'react-numeric-input';

export default class LootTableItem extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            RecordID: props.RecordID,
            Resref: props.Resref,
            MaxQuantity: props.MaxQuantity,
            Weight: props.Weight,
            IsActive: props.IsActive,
            OnUpdateParent: props.OnUpdateParent,
            OnDelete: props.OnDelete
        }

        this.handleChange = this.handleChange.bind(this);
        this.handleChangeWeight = this.handleChangeWeight.bind(this);
        this.handleChangeMaxQuantity = this.handleChangeMaxQuantity.bind(this);
        this.handleDelete = this.handleDelete.bind(this);
        this.raiseParentChanges = this.raiseParentChanges.bind(this);
    }

    componentWillUnmount() {
    }

    componentWillReceiveProps(props) {
        this.setState({
            RecordID: props.RecordID,
            Resref: props.Resref,
            MaxQuantity: props.MaxQuantity,
            Weight: props.Weight,
            IsActive: props.IsActive,
            OnUpdateParent: props.OnUpdateParent
        });
    }

    raiseParentChanges() {
        if (this.state.OnUpdateParent) {
            const record = {
                RecordID: this.state.RecordID,
                Resref: this.state.Resref,
                MaxQuantity: this.state.MaxQuantity,
                Weight: this.state.Weight,
                IsActive: this.state.IsActive
            }

            this.state.OnUpdateParent(record);
        }
    }

    handleChangeMaxQuantity(value) {
        this.setState({
            MaxQuantity: value
        }, this.raiseParentChanges);
    }

    handleChange(event) {
        const target = event.target;
        const value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;

        this.setState({
            [name]: value
        }, this.raiseParentChanges);
        
    }

    handleChangeWeight(value) {
        this.setState({
            Weight: value
        }, this.raiseParentChanges);
        
    }

    handleDelete() {
        if (this.state.OnDelete) {
            this.state.OnDelete(this.state.RecordID);
        }
    }

    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-6">
                        <input
                            name="Resref"
                            className="form-control"
                            type="text"
                            value={this.state.Resref}
                            onChange={this.handleChange}
                            maxLength="16" />
                    </div>
                    <div className="col-2">
                        <NumericInput
                            name="MaxQuantity"
                            className="form-control"
                            min={1}
                            max={99}
                            type="text"
                            value={this.state.MaxQuantity}
                            onChange={this.handleChangeMaxQuantity}
                            required
                            strict />
                    </div>
                    <div className="col-2">
                        <NumericInput
                            name="Weight"
                            className="form-control"
                            min={1}
                            max={99}
                            type="text"
                            value={this.state.Weight}
                            onChange={this.handleChangeWeight}
                            required
                            strict />
                    </div>
                    <div className="col-1 form-check">
                        <label className="form-check-label">
                            <input
                                name="IsActive"
                                className="form-check"
                                type="checkbox"
                                checked={this.state.IsActive}
                                onChange={this.handleChange} />
                        </label>
                    </div>
                    <div className="col-1">
                        <input 
                            name="Delete"
                            className="btn btn-primary"
                            type="button"
                            value="Delete"
                            onClick={this.handleDelete}/>
                    </div>

                </div>

                <div className="row">&nbsp;</div>


            </div>
        );



    }
}
