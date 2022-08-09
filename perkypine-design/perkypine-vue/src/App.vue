<script>
import MainComponent from './components/GameComponent.vue'
import GeneratorComponent from './components/GeneratorComponent.vue'

export default {
  name: 'App',
  components: {
    MainComponent,
    GeneratorComponent
  }
}
</script>

<style>
#app {
  font-family: "Trebuchet MS", Helvetica, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  align-items: center;
  justify-content: center;
}
body {
  background-color: rgb(33, 17, 83);
  color: white;
}
</style>

<template>
  <div>
    <GeneratorComponent/>
    <MainComponent/>
    
  </div>
</template>