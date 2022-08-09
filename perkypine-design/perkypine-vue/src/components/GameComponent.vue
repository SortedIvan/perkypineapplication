<script>
export default {
  data() {
    return {
      game: {gameName: "Next 3A Title", gameCharacters: [{characterName: "Benjy Franklin", characterLore: "Cool president guy"},
      {characterName: "The Terminator", characterLore: "He terminates people"}
      ]}
    }
  }
}
</script>

<style>
ul {
    list-style-type: none;
}
.center {
  display: grid;
  place-items: center;
}
</style>

<template>
  <div class = "center">
    <h3>
      Your unique title: {{this.game.gameName}}
      <br/>
      Game characters: 
        <ul>
          <li v-for="character in this.game.gameCharacters" v-bind:key="character.characterName">
              <vm-card>{{character.characterName}} -{{character.characterLore}}</vm-card>
          </li>
          
        </ul>
    </h3>
  </div>
</template>