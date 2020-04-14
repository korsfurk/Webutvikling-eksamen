<template>
  <v-app>
    
    <v-container>
     
      <v-content><!--skaper riktig padding mht. navbaren-->
        <v-app-bar app extended shrink-on-scroll>
          <v-spacer></v-spacer>
          <TheHeader/>
          <v-spacer></v-spacer>
          <v-btn class="mr-3" to="/">Kunde</v-btn>
          <v-btn class="mr-3" to="/about">Admin</v-btn>
        
        </v-app-bar>
      </v-content>

    <router-view></router-view><!--Hvor komponentene (view) vises-->
      
  </v-container><!--tilrettelegger for breakpoints-->

  <TheFooter/>
  <TheFooter/>
  <TheFooter/>
  <TheFooter/>
  <TheFooter/>
  <TheFooter/>
  <TheFooter/>
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



</style>

