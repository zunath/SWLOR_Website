import * as React from 'react';

export default class Footer extends React.Component<any, any> {
    constructor(props: any) {
        super(props);
    }
    
    componentWillUnmount() {
    }

    render() {
        return (
            <div>
                <footer className="footer">
                    <div className="container">
                        <span>
                            Star Wars: Legends of the Old Republic is a free mod developed for Neverwinter Nights. Star Wars, the Expanded Universe, all logos, characters, artwork, stories, information, names, and other elements associated thereto, are sole and exclusive property of Lucasfilm Limited. We are a completely free, open source non-profit project and operate under the definition of "fair use" under United States copyright laws.
                        </span>
                    </div>
                </footer>
            </div>
        );



    }
}
