import { connect } from "react-redux";
import {
  IRootStore,
  IRootDashboardPageStore
} from "./types";

import DashboardPageComponent from "./DashboardPageComponent";
import operations from "./duck/operations";

const mapStateToProps = (state: IRootStore): IRootDashboardPageStore => {

  return {
    marketValues: state.dashboardPage.marketValues,
    isLoading: state.dashboardPage.isLoading
  };
};

const mapDispatchToProps = (dispatch: any) => {
  return {
    getMarketValues: () => dispatch(operations.getMarketValues()),
  };
};

export default connect(
  mapStateToProps,
  mapDispatchToProps,
)(DashboardPageComponent);
