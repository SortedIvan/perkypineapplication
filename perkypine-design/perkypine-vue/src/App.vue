<script>
import MainComponent from './components/GameComponent.vue'
import GeneratorComponent from './components/GeneratorComponent.vue'
import CreditsComponent from './components/CreditsComponent.vue';

export default {
  name: 'App',
  components: {
    MainComponent,
    GeneratorComponent,
    CreditsComponent
  }
}
</script>

<style>
#app {
  font-family: "Trebuchet MS", Helvetica, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;

}
body {
  background-color: rgb(33, 17, 83);
  color: white;
}
</style>

<template>
<w-app>
  <div>
    <GeneratorComponent/>
    <MainComponent/>
    <CreditsComponent/>
  </div>
</w-app>
</template>