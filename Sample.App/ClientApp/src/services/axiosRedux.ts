import { Dispatch } from "redux";
import axios from "axios";

export type ISuccessCallback = (responseData: any) => any;
export type ISuccessExtraCallback = (extraData: any, responseData: any,) => any;

export const get = (dispatch: Dispatch, url: string, getStarted: () => any, getSuccess: (data: any) => any, getFailure: (err: any) => any) => { 
  dispatch(getStarted());

  return axios
    .get(url)
    .then((response) => {
      dispatch(getSuccess(response.data));
      return true;
    })
    .catch((error) => {
      console.error(error);
      dispatch(getFailure(error.response && error.response.data ? error.response.data.message : ""));
      return false;
    });
};
