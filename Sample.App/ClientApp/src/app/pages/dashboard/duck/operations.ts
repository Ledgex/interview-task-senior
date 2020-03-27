import { Dispatch } from "redux";
import { get } from "../../../../services/axiosRedux";

import actions from "./actions";

const getMarketValues = () => { 
  return (dispatch: Dispatch) => { 
    return get(dispatch,
      `api/marketValue`,
      actions.getMarketValuesStarted,
      actions.getMarketValuesSuccess,
      actions.getMarketValuesFailure);
  };
};

export default {
  getMarketValues
};
