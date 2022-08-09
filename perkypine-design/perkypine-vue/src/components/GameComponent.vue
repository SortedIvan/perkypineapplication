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

.cardUI{
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
  background-color:rgb(145, 172, 245);
  border-color: rgb(9, 9, 57);
}

</style>

<template>
<w-card shadow class="cardUI">
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

  </w-card>
</template>