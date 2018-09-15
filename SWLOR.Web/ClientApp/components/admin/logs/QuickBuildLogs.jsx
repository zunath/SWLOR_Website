import * as React from 'react';
import * as dotnetify from 'dotnetify';
import ReactPaginate from 'react-paginate';

export default class QuickBuildLogs extends React.Component {
    constructor(props) {
        super(props);
        this.vm = dotnetify.react.connect('QuickBuildLogsViewModel', this);

        this.dispatchState = state => this.vm.$dispatch(state);

        this.state = { PaginatedItems: [], Pages: 1, SelectedPage: 0 };

        this.pageChanged = this.pageChanged.bind(this);
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }

    pageChanged(page) {
        const pageIndex = page.selected;

        this.setState({
            SelectedPage: pageIndex
        });

        this.dispatchState({ ChangePage: pageIndex });
    }

    render() {
        return <div>
            
            <div className="row">
                <table className="table table-responsive">
                    <thead>
                        <tr>
                            <th>PC Territory Flag ID</th>
                            <th>Structure ID</th>
                            <th>DM Name</th>
                            <th>Date Built</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.PaginatedItems.map(obj => {
                            return <tr key={obj.StructureQuickBuildID}>
                                <td>
                                    {obj.PCTerritoryFlagID}
                                </td>
                                <td>
                                    {obj.PCTerritoryFlagStructureID}
                                </td>
                                <td>
                                    {obj.DMName}
                                </td>
                                <td>
                                    {obj.DateBuilt}
                                </td>
                            </tr>;
                        })}
                    </tbody>
                </table>
            </div>

            <ReactPaginate
                pageCount={this.state.Pages}
                pageRangeDisplayed={10}
                marginPagesDisplayed={3}
                pageClassName="page-item"
                nextClassName="page-item"
                previousClassName="page-item"
                pageLinkClassName="page-link"
                nextLinkClassName="page-link"
                previousLinkClassName="page-link"
                containerClassName="pagination pagination-lg pull-right"
                onPageChange={this.pageChanged}
            >
            </ReactPaginate>
        </div>;
    }
}