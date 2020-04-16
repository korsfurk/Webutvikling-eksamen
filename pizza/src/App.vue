<template>
  <v-app>
  
  <v-app-bar 
    class="nav-bar"
    app 
    extended 
    shrink-on-scroll
    src="https://localhost:5001/images/beef.jpg"
    >
    <TheHeader class="logo-txt"/>
    <v-spacer></v-spacer>
    <v-btn class="mr-3" id="cust-btn" to="/">Kunde</v-btn>
    <v-btn class="mr-3" to="/about">Admin</v-btn>
</v-app-bar>

<v-container>  
  <v-content><!--skaper riktig padding mht. navbaren-->
    <router-view/><!--Hvor komponentene (view) vises-->
  </v-content>
</v-container><!--tilrettelegger for breakpoints-->

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
  position: absolute;
  bottom: 0px;
  right: 0;
}

#cust-btn{
  position: absolute;
  bottom: 0;
  right: 100px;
}

.logo-txt{
  position: absolute;
  top: 20%;
  left: 20%;
}
</style>

