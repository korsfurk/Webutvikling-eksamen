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

  </v-app>
</template>

<script>

import MainPageHeader from "../src/components/MainPageHeader"

export default {
  
}
</script>

<style scoped>
.mr-3{
  background-color: cadetblue;

}
</style>

