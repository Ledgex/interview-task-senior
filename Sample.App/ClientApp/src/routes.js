import React from "react";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";

import { Header } from "./app/components/Header";

// Pages
import DashboardPageContainer from "./app/pages/dashboard/DashboardPageContainer";
import PageNotFound from "./app/pageNotFound";

export default (
  <Router>
    <div>
      <Header />
      <Switch>
        <Route path="/" exact={true} component={DashboardPageContainer} />
        <Route path="*" exact={true} component={PageNotFound} />
      </Switch>
    </div>
  </Router>
);