import * as React from 'react';
import { Link } from 'react-router-dom';

export default class Home extends React.Component<any, any> {
    render() {
        return (
            <div>

                <h1 className="center">Welcome to Star Wars: Legends of the Old Republic!</h1>
                <h3 className="center">A NeverWinter Nights Server</h3>
                <h5 className="center">
                    Direct Connect: swlor.eastus.cloudapp.azure.com:5121 <Link to="/downloads"><i>(Download Files)</i></Link>
                </h5>

                

            </div>
        );



    }
}
