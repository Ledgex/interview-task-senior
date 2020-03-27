import React from "react";
import { configure, mount } from "enzyme";
import NotFound from "../index";

import Adapter from "enzyme-adapter-react-16";

configure({ adapter: new Adapter() });

describe("Not Found Page", () => {
  let notFoundPage;

  const buttonInstance = () => {
    if (!notFoundPage) {
      notFoundPage = mount(<NotFound />);
    }
    return notFoundPage;
  };

  beforeEach(() => { 
    notFoundPage = undefined;
  });

  it("always renders a single div", () => {
    const button = buttonInstance().find("h2");
    expect(button.length).toBe(1);
  });

  it("always displays a message that page was not found (404)", () => {
    const button = buttonInstance().find("h2");
    expect(button.text()).toBe("404");
  });
});
