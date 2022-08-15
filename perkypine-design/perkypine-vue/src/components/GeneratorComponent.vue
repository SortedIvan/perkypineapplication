<script>
<link rel="stylesheet" type="text/css" href="//fonts.googleapis.com/css?family=Orbitron" />
import axios from 'axios';
const fantasyUrl = "https://localhost:44387/GameIdeas/api/getrandomfantasygame/";
const scifiUrl = "https://localhost:44387/GameIdeas/api/getrandomfantasygame/";
const spaceUrl =  "https://localhost:44387/GameIdeas/api/getrandomscifigame/";
const worldAPI = "https://app.pixelencounter.com/api/basic/planets?frame=1000&disableBackground=true&disableStars=true";
const urls = [fantasyUrl,scifiUrl,spaceUrl]
// const options = {
//   method: 'GET',
//   mode: 'no-cors'
// };
var randomUrl = "";
function timer() {
  setTimeout(function () {
    console.log("done");}, 2000);
}
export default {
  data() {
    return{
      games:[],
      gameNameSubmit: "",
      isLoadingGame: false,
      newGame: {},
      gameWorldPhoto: "",
      planetImageUrl: worldAPI
    }
  }, 
  methods:{
    sleep(milliseconds) {
    const start = Date.now();
    while (Date.now() - start < milliseconds);
    },
    getRandomGameType(){
      let x = Math.floor(Math.random() * 2);
      return x;
    },
    getRandomWorldImage(){
      var randomUrl1 = "https://app.pixelencounter.com/api/basic/planets?frame=1000";
      var randomUrl2 = "&disableBackground=true&disableStars=true";
      let x = Math.floor(Math.random() * 20000 + 1);
      this.planetImageUrl = randomUrl1 + x + randomUrl2; 
    },
    fetchData(gameName){
      this.isLoadingGame = true
      this.games = []
      this.newGame = {}
      randomUrl = urls[this.getRandomGameType()];
      axios.get(randomUrl + gameName)
      .then((response) => {
        timer();
        this.newGame = response.data;
        this.games = response.data;
        this.isLoadingGame = false;
        console.log(this.games);
        console.log("THIS IS THE GAMES")
      })
    },
    response() {
   var urlCreator = window.URL || window.webkitURL;
   var imageUrl = urlCreator.createObjectURL(this.response);
   document.querySelector("#image").src = imageUrl;
  },
    // fetchRandomWorldPhoto(){
    //   fetch(worldAPI, options)
    //   .then(response => response.blob())
    //   .then(imageBlob => {
    //       // Then create a local URL for that image and print it 
    //       this.gameWorldPhoto = URL.createObjectURL(imageBlob);
    //       console.log(this.gameWorldPhoto + "hi")
    //   });
    // }

  }
}
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Orbitron:wght@400;669&display=swap');
ul {
    list-style-type: none;
}
li {
  list-style-type: none;
}
.inputUI{
  width: 500px;
  height: 200px;
  display: flex;
  place-items: center;
  position: fixed;
  width: 500px;
  height: 200px;
  margin: 5% auto; /* Will not center vertically and won't work in IE6/7. */
  left: 0;
  right: 0;
  background-color:rgb(131, 117, 180);
  border-color: rgb(255, 255, 255);;
  border-radius: 8% !important;
}

.looping-rhombuses-spinner, .looping-rhombuses-spinner * {
      box-sizing: border-box;
    }

    .looping-rhombuses-spinner {
      width: calc(15px * 4);
      height: 15px;
      position: relative;
    }

    .looping-rhombuses-spinner .rhombus {
      height: 15px;
      width: 15px;
      background-color: #ff1d5e;
      left: calc(15px * 4);
      position: absolute;
      margin: 0 auto;
      border-radius: 2px;
      transform: translateY(0) rotate(45deg) scale(0);
      animation: looping-rhombuses-spinner-animation 2500ms linear infinite;
    }

    .looping-rhombuses-spinner .rhombus:nth-child(1) {
      animation-delay: calc(2500ms * 1 / -1.5);
    }

    .looping-rhombuses-spinner .rhombus:nth-child(2) {
      animation-delay: calc(2500ms * 2 / -1.5);
    }

    .looping-rhombuses-spinner .rhombus:nth-child(3) {
      animation-delay: calc(2500ms * 3 / -1.5);
    }

    @keyframes looping-rhombuses-spinner-animation {
      0% {
        transform: translateX(0) rotate(45deg) scale(0);
      }
      50% {
        transform: translateX(-233%) rotate(45deg) scale(1);
      }
      100% {
        transform: translateX(-466%) rotate(45deg) scale(0);
      }
    }

.spinnerAnimation{
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 30px;
}
.buttonPosition{
  display: flex;
  justify-content: center;
  align-items: center;
  font-family: 'Orbitron', sans-serif;
}
.radioButtons{
    color: rgb(193, 50, 3);
}

a.button3{
display:inline-block;
padding:0.3em 1.2em;
margin:0 0.3em 0.3em 0;
border-radius:2em;
box-sizing: border-box;
text-decoration:none;
font-family:'Roboto',sans-serif;
font-weight:300;
color:#FFFFFF;
background-color:#4eb5f1;
text-align:center;
transition: all 0.2s;
cursor: pointer;
font-family: 'Orbitron';
}
a.button3:hover{
background-color:#4095c6;
}
@media all and (max-width:30em){
a.button3{
display:block;
margin:0.2em auto;
}
}

/* @font-face {


} */

.siteDescr{
  opacity: .6;
  font-family: 'Orbitron', sans-serif; 
}

@import url('http://fonts.cdnfonts.com/css/common-pixel');
.siteTitle{
  justify-content: center;
  font-family: 'Common Pixel', sans-serif;
}

.worldName{
  margin-top: 5px;
}
/* image shake */
img:hover {
  /* Start the shake animation and make the animation last for 0.5 seconds */
  animation: shake 0.5s;

  /* When the animation is finished, start again */
  animation-iteration-count: infinite;
}

@keyframes shake {
  0% { transform: translate(1px, 1px) rotate(0deg); }
  10% { transform: translate(-1px, -2px) rotate(-1deg); }
  20% { transform: translate(-3px, 0px) rotate(1deg); }
  30% { transform: translate(3px, 2px) rotate(0deg); }
  40% { transform: translate(1px, -1px) rotate(1deg); }
  50% { transform: translate(-1px, 2px) rotate(-1deg); }
  60% { transform: translate(-3px, 1px) rotate(0deg); }
  70% { transform: translate(3px, 1px) rotate(-1deg); }
  80% { transform: translate(-1px, -1px) rotate(1deg); }
  90% { transform: translate(1px, 2px) rotate(0deg); }
  100% { transform: translate(1px, -2px) rotate(-1deg); }
}

.gameDisplay:not(#img){
  mix-blend-mode:difference;
  color:white;
  font-family: 'Orbitron', sans-serif; 
}
w-input{
  font-family: 'Orbitron', sans-serif; 
}
</style>

<template>
  <div>
    
    <w-card class = "inputUI" shadow = true>
      <h2 class = "siteTitle">PerkyPine</h2>
      <h3 class = "siteDescr">Generate short, unique game lore with three characters to go with it.</h3>
      <br>
        <w-input
            class="mb4"
            placeholder="Give your game a name"
            v-model="this.gameNameSubmit">
        </w-input>
        <div class = "buttonPosition">
          <a v-on:click="fetchData(this.gameNameSubmit); this.getRandomWorldImage()" class="button3">Generate</a>
        </div>
        <div v-if="this.isLoadingGame">
          <div class = "spinnerAnimation">
            <div class="looping-rhombuses-spinner">
            <div class="rhombus"></div>
            <div class="rhombus"></div>
            <div class="rhombus"></div>
            </div>
          </div>
        </div>
        <div v-else>
        </div>
        <!-- <ul>
          <li v-for="game in this.games" v-bind:key= "game.gameIdeaName">
                <h3>{{game.gameCharacters}}</h3>    
          </li>
        </ul> -->
        <br>
        <br>
        <br>
        <div class = "gameDisplay" v-if = "!Object.keys(this.newGame).length == 0">
            <li v-for = "gameWorld in this.newGame.gameWorld" v-bind:key="gameWorld">
             <h3 class = "siteDescr">Game world:</h3><p class = "worldName">{{gameWorld}}</p> 
            </li>
            <img v-bind:src= "this.planetImageUrl" alt = "credits: https://app.pixelencounter.com/"/>
          <h3 class = "siteDescr">Game characters:</h3>
            <li v-for = "gameCharacters in this.newGame.gameCharacters" v-bind:key="gameCharacters">
              <p class = "siteDescr">{{gameCharacters.characterName}}</p> - {{gameCharacters.characterLore}}
            </li>
        </div>
    </w-card>
  </div>
</template>