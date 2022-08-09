// import { createApp } from 'vue';
// import App from './App.vue';
// import Vue3Material from 'vue3-material';
// //import { VmButton, VmContainer } from 'vue3-material';

// createApp(App)
//     .use(Vue3Material)
//     .mount('#app');

/////////
import { createApp } from 'vue'
import App from './App.vue'
import WaveUI from 'wave-ui'
import 'wave-ui/dist/wave-ui.css'

const app = createApp(App)

new WaveUI(app, {
  // Some Wave UI options.
})

app.mount('#app')
