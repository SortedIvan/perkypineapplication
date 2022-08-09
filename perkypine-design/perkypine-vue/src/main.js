// import { createApp } from 'vue'
// import App from './App.vue'

// const app = createApp(App)
// app.mount('#app')
// createApp(App).mount('#app')

import { createApp } from 'vue';
import App from './App.vue';
import Vue3Material from 'vue3-material';
//import { VmButton, VmContainer } from 'vue3-material';

createApp(App)
    .use(Vue3Material)
    .mount('#app');

