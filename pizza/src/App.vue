<template>
  <v-app class="black">
  
  <!--Header + navigation-->
  <v-app-bar 
    class="nav-bar"
    app 
    extended 
    shrink-on-scroll
    src="https://localhost:5001/images/beef.jpg"
    >
    <TheHeader/>
    <v-spacer></v-spacer>
    <v-btn class="" to="/">Home</v-btn>
</v-app-bar>

<!--Content-->
 
  <v-content><!--skaper riktig padding mht. navbaren-->
    <router-view/><!--Hvor komponentene (view) vises-->
  </v-content>


  <!--Footer-->
  <v-footer padless>
    <v-card flat tile width="100%" class="green lighten-4 text-center">

      <v-card-text>
        <v-btn v-for="icon in icons" :key="icon" class="mx-4" icon>
          <v-icon size="24px">{{ icon }}</v-icon>
        </v-btn>
      </v-card-text>

      <v-card-text class="pt-0">
        <TheFooter/>
      </v-card-text>

      <v-spacer></v-spacer>
      <v-btn class="mr-3" id="cust-btn" to="/">Customer</v-btn>
      <v-btn class="mr-3" to="/admin">Admin</v-btn>

      <v-divider></v-divider>

      <v-card-text>
        <strong>Pizza Q U A R A N T I N E - 2020</strong>
      </v-card-text>

    </v-card>
  </v-footer>
 

  </v-app>
</template>

<script>

import TheHeader from "../src/layout/TheHeader"
import TheFooter from "../src/layout/TheFooter"


export default {
  name: "App",
  components: {
    TheHeader,
    TheFooter,
    
  },
  data: () => ({
    icons: [
      'mdi-facebook',
      'mdi-twitter',
      'mdi-instagram'
    ]
  })
}
</script>

<style scoped>


.mr-3{
  position: absolute;
  bottom: 50%;
  right: 0;
}

#cust-btn{
  position: absolute;
  right: 100px;
}

</style>

