import * as React from 'react';
import * as dotnetify from 'dotnetify';

export default class Downloads extends React.Component {
    constructor(props) {
        super(props);

        this.vm = dotnetify.react.connect('DownloadViewModel', this);
        this.dispatch = state => this.vm.$dispatch(state);

        this.buildURL = this.buildURL.bind(this);
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }

    buildURL(id) {
        return '/Download/Index/' + id;
    }


    render() {
        return (
            <div>

                <div>
                    <div className="row">
                        <div className="col-12">
                            <div className="card border-primary mb-3 center">
                                <div className="card-body">
                                    <h4 className="card-title">Downloads</h4>

                                    <p>
                                        The main files necessary to play are distributed over NWSync. This means you can just join the server and get the files!
                                         <br />
                                        However, there are a few files which aren't distributed this way. You will need to manually install these if you would like them.
                                         <br />
                                        We highly recommend installing these for the full Star Wars experience.
                                     </p>
                                </div>
                            </div>
                        </div>
                    </div>


                    <table className="table">
                        <thead>
                            <tr>
                                <th>File Name</th>
                                <th>Description</th>
                                <th>Instructions</th>
                                <th>Download</th>
                            </tr>
                        </thead>
                        <tbody>

                            {this.state && this.state.DownloadList.map(obj =>
                                <tr key={obj.ID}>
                                    <td>{obj.Name}</td>
                                    <td>{obj.Description}</td>
                                    <td>{obj.Instructions}</td>
                                    <td>
                                        <a className="btn btn-primary btn-block" href={this.buildURL(obj.ID)} target="_blank">Download</a>
                                    </td>
                                </tr>

                                )}
                        </tbody>

                    </table>
                </div>
            </div>
        );
    }
}
