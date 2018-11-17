import * as React from 'react';
import { Link } from 'react-router-dom';

export default class Downloads extends React.Component {
    constructor(props) {
        super(props);

        this.download = this.download.bind(this);
    }
    
    download(path) {
        window.open(window.location.protocol + '//' + window.location.host + path);
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
                            <tr>
                                <td>GUI Override</td>
                                <td>This overrides the graphics of your user interface. It will affect all servers so you will need to move it out of your override folder if you no longer wish to use it.</td>
                                <td>Extract all files to your My Documents/Neverwinter Nights/override directory.</td>
                                <td>
                                    <a className="btn btn-primary" href="https://neverwintervault.org/sites/all/modules/pubdlcnt/pubdlcnt.php?file=https://neverwintervault.org/sites/neverwintervault.org/files/project/29362/files/swgui-2.zip&nid=29362">Download</a>
                                </td>
                            </tr>
                        </tbody>

                    </table>
                </div>
            </div>
        );
    }
}
