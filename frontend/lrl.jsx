import React from 'react';
import Splash from './splash'
import UserCache from './user_cache'
import {Route, Switch, HashRouter} from 'react-router-dom';


const Lrl = () => (
        <div className="container">
            <div>
                <h1>adsgsdgs</h1>
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