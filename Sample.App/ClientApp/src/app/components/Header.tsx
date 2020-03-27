import * as React from "react";
import { NavLink } from "react-router-dom";

export const Header: React.SFC = () => {
  return (
    <div className="sa-header">
      <h1>Investment Portal</h1>
      <ul className="sa-header-nav">
        <li className="sa-header-nav-item">
          <NavLink to="/" exact activeClassName="active">Home</NavLink>
        </li>
        {/* Additional menu links here */}
      </ul>
    </div>
  );
};
