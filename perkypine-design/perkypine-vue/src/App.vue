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
  /* background-image: url("bgimage.jpg"); */
  /* background-image: url("newbg.jpg"); */
  background-image: url("background.png");
  background-color: rgb(33, 17, 83);
  color: white;
  max-width: 100%; 
  height: auto;
}
.catimage{
  position: absolute;
    width: 500px;
    height: 500px;
  left: 70vw;
  margin: 20px;
  -webkit-animation: mover 1.5s infinite  alternate !important;
  animation: mover 1.5s infinite  alternate !important;

}
@-webkit-keyframes mover {
    0% { transform: translateY(0); }
    100% { transform: translateY(-25px); }
}
@keyframes mover {
    0% { transform: translateY(0); }
    100% { transform: translateY(-25px); }
}
</style>

<template>
<w-app>
  <div>
    <img class = "catimage" src="https://i.postimg.cc/cJdfsds9/cattoimage.png" alt="cat image"/>
    <GeneratorComponent/>
    <MainComponent/>
    <CreditsComponent/>
  </div>
</w-app>
</template>