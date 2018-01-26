import * as React from 'react';
import { Route, Switch } from 'react-router-dom';
import { Layout } from './components/Layout';
import Home from './components/Home';
import UserProfile from './components/UserProfile';
import Logs from './components/admin/logs/Logs';
import ChatLogs from './components/admin/logs/ChatLogs';
import ConnectionLogs from './components/admin/logs/ConnectionLogs';
import QuickBuildLogs from './components/admin/logs/QuickBuildLogs';
import Features from './components/Features';
import Admin from './components/Admin';
import Downloads from './components/Downloads';
import NotFound from './components/NotFound';
import Classes from './components/Classes';
import ConnectionInfo from './components/ConnectionInfo';
import Races from './components/Races';
import Skills from './components/Skills';
import Story from './components/Story';
import TeamMembers from './components/TeamMembers';

export const routes =
    <Layout>
        <Switch>

            /* Client Routes */
            <Route exact path="/" component={Home} />
            <Route exact path="/home" component={Home} />
            <Route exact path="/features" component={Features} />
            <Route exact path="/admin" component={Admin} />
            <Route exact path="/downloads" component={Downloads} />
            <Route exact path="/user-profile" component={UserProfile} />
            <Route exact path="/classes" component={Classes} />
            <Route exact path="/connection-info" component={ConnectionInfo} />
            <Route exact path="/races" component={Races} />
            <Route exact path="/skills" component={Skills} />
            <Route exact path="/story" component={Story} />
            <Route exact path="/team-members" component={TeamMembers} />
            <Route exact path="/admin/logs" component={Logs} />
            <Route exact path="/admin/chat-logs" component={ChatLogs} />
            <Route exact path="/admin/connection-logs" component={ConnectionLogs} />
            <Route exact path="/admin/quick-build-logs" component={QuickBuildLogs} />
            <Route component={NotFound} />
        </Switch>
    </Layout>;
