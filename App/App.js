import React from 'react';

import {ApiContextProvider} from './stores/sessionStore'
import Routes from './pages'

const App = () => {
  return (
    <ApiContextProvider>
        <Routes />
    </ApiContextProvider>
  );
};

export default App;
