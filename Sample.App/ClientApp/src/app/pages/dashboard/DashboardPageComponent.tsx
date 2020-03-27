import * as React from "react";
import { IMarketValue } from "../../types";

interface ILocalProps {
  isLoading: boolean;
  getMarketValues: () => void;
  marketValues: IMarketValue[]
}

class DashboardPageComponent extends React.Component<ILocalProps> {
  public componentDidMount() {
    this.props.getMarketValues();
  }

  public render() { 
    const body = this.props.isLoading ? <span>Loading!</span> : this.renderTable();

    return <div className="page">
      <h2>Market Values</h2>
      {body}
    </div>;
  }

  private renderTable() {
    const marketValueRows = this.props.marketValues.map(mv => {
      return <tr className="table-row" key={`${mv.asOfDate}-${mv.amount}`}>
        <td className="table-cell width-large">{mv.investmentSymbol}</td>
        <td className="table-cell width-medium">{mv.amount}</td>
        <td className="table-cell width-medium">{mv.performance} %</td>
      </tr>
    })

    return <table>
      <thead>
        <tr>
          <td className="table-header-cell">Investment</td>
          <td className="table-header-cell">Amount</td>
          <td className="table-header-cell">Performance</td>
        </tr>
      </thead>
      <tbody>
        {marketValueRows}
      </tbody>
    </table>
  }
}

export default DashboardPageComponent;