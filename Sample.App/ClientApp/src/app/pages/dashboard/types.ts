import { IMarketValue } from "../../types";

export interface IRootStore { 
  dashboardPage: IRootDashboardPageStore;
}

export interface IRootDashboardPageStore { 
  marketValues: IMarketValue[];
  isLoading: boolean;
}