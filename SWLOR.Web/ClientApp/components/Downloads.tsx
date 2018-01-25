import * as React from 'react';
import * as dotnetify from 'dotnetify';

export default class Downloads extends React.Component<any, any> {
    vm: any;

    constructor(props: any) {
        super(props);
        this.vm = dotnetify.react.connect('DownloadsViewModel', this);
        this.state = { DownloadList: [] }
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }

    render() {
        return (
            <div>
                
                <h2 className="center">Downloads</h2>
                <div className="row">
                    <table className="table striped bordered">
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Description</th>
                                <th>Link</th>
                            </tr>
                        </thead>
                        <tbody>
                            {this.state.DownloadList.map(function (obj) {
                                return <tr key={obj.DownloadId}>
                                    <td>
                                        {obj.Name}
                                    </td>
                                    <td>
                                        {obj.Description}
                                    </td>
                                    <td>
                                        <a className="btn btn-outline-primary" href={obj.Url}>
                                            Download
                                        </a>

                                    </td>
                                </tr>;
                            })}
                        </tbody>
                    </table>
                </div>
            
            </div>
        );



    }
}
