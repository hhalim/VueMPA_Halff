import Vue from 'vue';
import App from './App.vue';
import Toasted from 'vue-toasted';
import Mixin from '../../Mixin';
import Vuetify from 'vuetify'
import axios from 'axios';
//import VueRouter from 'vue-router';


//Initialization
axios.defaults.withCredentials = true;
Vue.config.productionTip = false;

//Plugins registration
//Vue.use(VueRouter); //if needed
Vue.use(Toasted, {
    iconPack : 'fontawesome' // set your iconPack, defaults to material. material|fontawesome|custom-class
});
Vue.use(Vuetify);

//Global Vars
Vue.mixin(Mixin); //needed for Version and Toasted to work easily

//Routing (if needed)
//const routes = [
//  { path: '/', component: Index },
//  { path: '/about', component: About },
//  { path: '/contact', component: Contact }
//]

//const router = new VueRouter({
//  routes
//});

new Vue({
    render: h => h(App)
}).$mount('#app');
