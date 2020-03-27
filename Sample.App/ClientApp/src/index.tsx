import * as React from "react";
import * as ReactDOM from "react-dom";
import { Provider } from "react-redux";

import 'babel-polyfill';

import "./index.scss";

import routes from "./routes";

import store from "./store";

ReactDOM.render(
  <Provider store={store}>
    {routes}
  </Provider>,
  document.getElementById("root") as HTMLElement
);
