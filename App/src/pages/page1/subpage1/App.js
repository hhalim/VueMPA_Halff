import Vue from 'vue';
import App from './App.vue';
import Mixin from '../../../Mixin';

Vue.mixin(Mixin); //needed for Toasted to work easily

new Vue({
    render: h => h(App)
}).$mount('#app');
