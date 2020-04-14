<template>
  <v-app>

    <v-app-bar app dark>
      <v-spacer></v-spacer>
      <v-btn class="mr-3" to="/">Kunde</v-btn>
      <v-btn class="mr-3" to="/about">Admin</v-btn>
    
    </v-app-bar>

    <v-content><!--skaper riktig padding mht. navbaren-->
      <v-container><!--tilrettelegger for breakpoints-->
        <router-view></router-view><!--Hvor komponentene (view) vises-->
      </v-container>
    </v-content>

  <TheHeader/>
  </v-app>
</template>

<script>

import TheHeader from "../src/layout/TheHeader"

export default {
  name: "App",
  components: {
    TheHeader
  }
}
</script>

<style scoped>
.mr-3{
  background-color: cadetblue;

}
</style>

