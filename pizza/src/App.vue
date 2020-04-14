<template>
  <v-app>

    <v-app-bar app light>
      <v-toolbar-title>Pizza Q U A R A N T I N E</v-toolbar-title>
      <v-spacer></v-spacer>
      <v-btn class="mr-3" to="/">Kunde</v-btn>
      <v-btn class="mr-3" to="/admin">Admin</v-btn>
    
    </v-app-bar>

    <v-content><!--skaper riktig padding mht. navbaren-->
      <v-container><!--tilrettelegger for breakpoints-->
        <router-view></router-view><!--Hvor komponentene (view) vises-->
      </v-container>
    </v-content>

  </v-app>
</template>

<style scoped>
.mr-3{
  background-color: cadetblue;

}
</style>

