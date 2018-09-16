import * as React from 'react';
import { Route, Switch } from 'react-router-dom';
import { Layout } from './components/Layout';
import Home from './components/Home';
import About from './components/About';
import Setting from './components/Setting';
import UserProfile from './components/UserProfile';
import Logs from './components/admin/logs/Logs';
import ChatLogs from './components/admin/logs/ChatLogs';
import ConnectionLogs from './components/admin/logs/ConnectionLogs';
import QuestEditor from './components/admin/quest-editor/QuestEditor';
import QuestDetails from './components/admin/quest-editor/QuestDetails';
import QuestPrerequisites from './components/admin/quest-editor/QuestPrerequisites';
import QuestRewards from './components/admin/quest-editor/QuestRewards';
import QuestStates from './components/admin/quest-editor/QuestStates';
import Admin from './components/Admin';
import NotFound from './components/NotFound';
import CharacterBackgrounds from './components/CharacterBackgrounds';
import Perks from './components/Perks';
import Skills from './components/Skills';
import FAQ from './components/FAQ';
import LootTableEditor from './components/admin/loot-table-editor/LootTableEditor';
import Species from './components/Species';
import Crafting from './components/Crafting';
import GameplayInfo from './components/GameplayInfo';

export const routes =
    <Layout>
        <Switch>

            /* Client Routes */

            /* Public Routes */
            <Route exact path="/" component={Home} />
            <Route exact path="/home" component={Home} />
            <Route exact path="/about" component={About} />
            <Route exact path="/setting" component={Setting} />
            <Route exact path="/admin" component={Admin} />
            <Route exact path="/backgrounds" component={CharacterBackgrounds} />
            <Route exact path="/perks" component={Perks} />
            <Route exact path="/skills" component={Skills} />
            <Route exact path="/faq" component={FAQ} />
            <Route exact path="/setting" component={Setting} />
            <Route exact path="/species" component={Species} />
            <Route exact path="/crafting" component={Crafting} />
            <Route exact path="/gameplay-info" component={GameplayInfo} />
            
            /* User Logged-In Routes */
            <Route exact path="/user-profile" component={UserProfile} />

            /* DM Routes */
            <Route exact path="/admin/logs" component={Logs} />
            <Route exact path="/admin/chat-logs" component={ChatLogs} />
            <Route exact path="/admin/connection-logs" component={ConnectionLogs} />

            /* Admin Routes */
            <Route exact path="/admin/quest-editor" component={QuestEditor} />
            <Route exact path="/admin/quest-editor/quest-details" component={QuestDetails} />
            <Route exact path="/admin/quest-editor/quest-prerequisites" component={QuestPrerequisites} />
            <Route exact path="/admin/quest-editor/quest-rewards" component={QuestRewards} />
            <Route exact path="/admin/quest-editor/quest-states" component={QuestStates} />
            <Route exact path="/admin/loot-table-editor" component={LootTableEditor} />
            
            <Route component={NotFound} />
        </Switch>
    </Layout>;
