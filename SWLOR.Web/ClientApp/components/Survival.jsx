import * as React from 'react';
import * as dotnetify from 'dotnetify';
import { Link } from 'react-router-dom';

export default class Survival extends React.Component {
    constructor(props) {
        super(props);
        this.vm = dotnetify.react.connect('SurvivalViewModel', this);
        this.dispatch = state => this.vm.$dispatch(state);

        this.state = {
            TopicList: [],
            SelectedTopicID: 0,
            SelectedTopic: {}
        }

        this.handleChange = this.handleChange.bind(this);
        this.buildDescription = this.buildDescription.bind(this);
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }

    handleChange(event) {
        const target = event.target;
        var value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;

        if (value === undefined)
            value = target.getAttribute('data-topicid');

        this.setState({
            [name]: value
        }, () => this.dispatch({ [name]: value }));
    }

    buildDescription() {
        const text = this.state.SelectedTopic.Text;
        
        return (text.split('\\n').map(function (item, index) {
            return <span key={index}>
                {item}
                <br />
            </span>;
        }));
    }

    render() {
        return (
            <div>

                <div className="row">
                    <div className="col-12">
                        <div className="card border-primary mb-3 center">
                            <div className="card-body">
                                <h4 className="card-title">Survival Guide</h4>

                                <p>
                                    Freescape is primarily a game about survival. This means your character needs to search for raw materials, craft supplies, and eat food.
                                    <br />
                                    There are numerous changes from vanilla Neverwinter Nights that you should be aware of.
                                    <br />
                                    Please take some time to read the topics below for more information.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>

                <div className="row">
                    <div className="col-3">
                        <h3 className="center">Topics</h3>
                        <hr />

                        <div className="list-group">
                            {this.state.TopicList.map(obj =>
                                <Link key={obj.GameTopicID}
                                    className={this.state.SelectedTopicID === obj.GameTopicID ? 'list-group-item list-group-item-action active' : 'list-group-item list-group-item-action'}
                                    to="#"
                                    onClick={this.handleChange}
                                    name="SelectedTopicID"
                                    data-topicid={obj.GameTopicID}>
                                    <i className={'fa ' + obj.Icon}></i>&nbsp;&nbsp;{obj.Name} 
                                </Link>
                            )}
                        </div>

                    </div>

                    <div className="col offset-1">
                        <h3 className="center">Information</h3>
                        <hr />

                        {this.state.SelectedTopic.Text && this.buildDescription()}


                    </div>

                </div>
            </div>
        );
    }
}
