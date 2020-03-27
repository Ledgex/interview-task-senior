import types from "./types";

export default {
  getMarketValuesStarted: () => ({
    type: types.MARKET_VALUES_GET_STARTED
  }),
  getMarketValuesSuccess: (responseData: any) => ({
    responseData,
    type: types.MARKET_VALUES_GET_SUCCESS
  }),
  getMarketValuesFailure: (responseData: any) => ({
    responseData,
    type: types.MARKET_VALUES_GET_FAILURE
  })
}