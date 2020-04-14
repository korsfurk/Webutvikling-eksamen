<template>
  <v-app>
    <v-container><!--tilrettelegger for breakpoints-->
    
    <v-content><!--skaper riktig padding mht. navbaren-->
      <v-app-bar app light>
        <v-spacer></v-spacer>
        <v-btn class="mr-3" to="/">Kunde</v-btn>
        <v-btn class="mr-3" to="/about">Admin</v-btn>
      
      </v-app-bar>
    </v-content>

  <router-view></router-view><!--Hvor komponentene (view) vises-->
      
  </v-container>

  <TheHeader/>
  <TheFooter/>

  </v-app>
</template>

<script>

import TheHeader from "../src/layout/TheHeader"
import TheFooter from "../src/layout/TheFooter"

export default {
  name: "App",
  components: {
    TheHeader,
    TheFooter
  }
}
</script>

<style scoped>
.mr-3{
  background-color: cadetblue;

}
</style>

