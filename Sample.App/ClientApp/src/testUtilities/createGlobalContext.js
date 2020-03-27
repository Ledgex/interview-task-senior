import { BrowserRouter } from 'react-router-dom';
import { shape } from 'prop-types';

// Instantiate router context
const router = {
  history: new BrowserRouter({}).history,
  route: {
    location: {},
    match: {},
  },
};

export const createGlobalContext = () => ({
  context: {
    router,
    store: {
      getState: () => ({
        global: { }
      }),
      subscribe: () => null
    }
  },
  childContextTypes: {
    router: shape({}),
    store: shape({})
  }
});
