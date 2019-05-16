import React from 'react';
import Splash from './splash'
import UserCache from './user_cache'
import Nav from './nav'
import {Route, Switch, HashRouter} from 'react-router-dom';


const Lrl = () => (
        <div className="container">
            <div>
                <h1>LRU</h1>
                <Nav/>
                <HashRouter>
                    <Switch>
                        <Route exact path='/home' component={Splash} />
                        <Route exact path='/:userId' component={UserCache} />
                    </Switch>
                </HashRouter>
            </div>
        </div>
);

export default Lrl;