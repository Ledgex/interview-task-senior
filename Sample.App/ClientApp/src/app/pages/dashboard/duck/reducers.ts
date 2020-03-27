import {
  IRootDashboardPageStore
} from "../types";
import types from "./types";
import { IMarketValue } from "../../../types";

const INITIAL_STATE = {
  marketValues: [] as IMarketValue[],
  isLoading: true
};

const screenStateReducer = {
  // EXAMPLES_GET_SUCCESS
  [types.MARKET_VALUES_GET_SUCCESS]: (state: IRootDashboardPageStore, action: any) => { 
    return {
      ...state,
      isLoading: false,
      marketValues: action.responseData
    };
  },
};

const reducers = [
  screenStateReducer
];

const reducer = (startingState: IRootDashboardPageStore = INITIAL_STATE, action: any) => {
  let state = startingState;
  reducers.forEach((reducerMethod: any) => {
    if (reducerMethod[action.type]) {
      state = reducerMethod[action.type](state, action);
    }
  })
  return state;
};

export default reducer;
