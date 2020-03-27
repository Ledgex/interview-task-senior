import { combineReducers } from "redux";

import dashboardPage from "./app/pages/dashboard/duck/reducers";

const rootReducer = combineReducers({
  dashboardPage,
});

export default rootReducer;
