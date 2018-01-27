import * as React from 'react';
import { Link } from 'react-router-dom';

export default class ConnectionInfo extends React.Component<any, any> {

    render() {
        return (
            <div>
                <h2 className="center">Connection Info</h2>
                <hr />
                <div className="row">
                    <div className="col-12">
                        <p className="center">
                            We're really excited you decided to come check us out! Make sure you <Link to="/downloads">download our files </Link> so you're ready to play when we launch.
                            <br />
                            <br />
                            We will have connection information posted once we launch the server.
                            <br />
                            <br />
                            In the meantime you can <Link to="http://forums.starwarsnwn.com/">join us on the forums </Link> or you can <Link to="https://discord.gg/g7PzMaM">chat with us on Discord!</Link>
                        </p>
                    </div>

                </div>
            </div>
        );



    }
}
