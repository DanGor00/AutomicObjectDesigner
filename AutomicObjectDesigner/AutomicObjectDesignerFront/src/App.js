import React, { Component } from 'react';
import { useEffect } from 'react';
import { Router, Routes, Route, Link, BrowserRouter} from 'react-router-dom';
import { FiSettings } from 'react-icons/fi';
import { TooltipComponent } from '@syncfusion/ej2-react-popups';
import { Navbar, Footer, Sidebar, ThemeSettings } from './components';
import { Automicobjectdesigner, Filetransfermany, Filetransferone,
  Sapjobbw, Sapjobmassen, Sapjobsimple, Unixgeneral, Windowsgeneral } from './pages';

import { useStateContext } from './contexts/ContextProvider';

import './App.css';


    export default function App() {
      const { activeMenu } = useStateContext();
      return (
          <div>
            <BrowserRouter>
            <div className='flex relative dark:bg-main-dark-bg'>
              <div className='fixed right-4 bottom-4' style={{zIndex: '1000'}}>
                <TooltipComponent content="Settings" position="Top">
                  <button type='button'
                  className='text-3xl p-3
                  hover:drop-shadow-xl
                  hover:bg-light-gray text-white
                  '
                  style={{background:'blue',
                  borderRadius: '50%' }}>
                    <FiSettings />
                  </button>
                </TooltipComponent>
              </div>
                {activeMenu ? (
                  <div className='w-72 fixe sidebar
                  dark:bg-secondary-dark-bg
                  bg-white'>
                    <Sidebar />
                  </div>
                ) : (
                  <div className='w-0
                  dark:bg-secondary-dark-bg'>
                    <Sidebar />
                  </div>
                )}
                <div className={ activeMenu
                ? 'dark:bg-main-dark-bg  bg-main-bg min-h-screen w-full  '
                : 'bg-main-bg dark:bg-main-dark-bg  w-full min-h-screen flex-2 '
                }>
                  <div className='fixed md:static
                  bg-main-bg dark:bg-main-dark-bg
                  navbar w-full'>
                    <Navbar />
                  </div>
                <div>
                  <Routes />
                </div>
              </div>
            </div>
            </BrowserRouter>
          </div>
        )
      }
  