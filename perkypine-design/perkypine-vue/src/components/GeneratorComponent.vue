<script>
import axios from 'axios';
export default {
  data() {
    return{
      games:[],
      gameNameSubmit: "",
      isLoadingGame: false
    }
  }, 
  methods:{
    sleep(milliseconds) {
    const start = Date.now();
    while (Date.now() - start < milliseconds);
    },
    fetchData(gameName){
      this.isLoadingGame = true
      this.games = []
      axios.get("https://localhost:44387/GameIdeas/api/getrandomfantasygame/" + gameName)
      .then((response) => {
        this.games = response.data;
        this.isLoadingGame = false;
      })
    }

  }
}
</script>

<style>
ul {
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
  border-color: rgb(9, 9, 57);
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


/* Sticky note styling */

</style>

<template>
  <div>

    <w-card class = "inputUI">
        <w-input
            class="mb4"
            placeholder="Enter your game name here"
            v-model="this.gameNameSubmit">
        </w-input>
        <div class = "buttonPosition">
          <a v-on:click="fetchData(this.gameNameSubmit)" class="button3">Generate</a>
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


        <ul>
          <li v-for="game in this.games" v-bind:key= "game.GameIdeaName">
              <h3>
                {{game}}
              </h3>
          </li>
        </ul>
    </w-card>
  </div>
</template>