import React from 'react';
import PageFooter from '../components/PageFooter';
import Dashboard from '../components/Dashboard';
import { cleanLocalStorage, getUser, isLoggedIn } from '../services/localStorageService'

const Home = () => {

  if (isLoggedIn()) {
    return (
      <>
        <Dashboard />
      </>
    );
  };
  cleanLocalStorage()
  window.location.href = "/index"
}

export default Home;