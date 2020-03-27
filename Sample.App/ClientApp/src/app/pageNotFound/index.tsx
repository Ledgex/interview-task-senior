import * as React from "react";
import "./notfound.scss";

class App extends React.Component {
  public render() {
    return (
      <div>
        <div className="container-page-not-found">
          <h2>404</h2>
          <h3>The requested page was not found</h3>
        </div>
      </div>
    );
  }
}

export default App;
