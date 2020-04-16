
<template>

  <v-layout>
    <v-flex xs12 sm6 offset-sm3>
      <v-card>
        <v-img
          class="white--text"
          height="200px"
          src="https://cdn.vuetifyjs.com/images/cards/docks.jpg"
        >
          <v-container fill-height fluid>
            <v-layout fill-height>
              <v-flex xs12 align-end flexbox>
                <span class="headline">Pizza Covid</span>
              </v-flex>
            </v-layout>
          </v-container>
        </v-img>
        <v-card-title>
          <div>
            <span class="grey--text">Number 1</span><br>
            <span>The classic ham and cheese pizza.</span>
          </div>
        </v-card-title>
        <v-card-actions>
          <v-btn flat color="#B4D7C2">Bestill</v-btn>
        </v-card-actions>
      </v-card>
    </v-flex>
  </v-layout>

  <div>
    <TheHeader/>

    <h1>Menu</h1>
    <DrinkList/>

    <TheFooter/>
  </div>

</template>

<script>

import TheHeader from "../src/layout/TheHeader"
import DrinkList from "@/components/Drinklist"
import TheFooter from "../src/layout/TheFooter"


export default {
  name: "App",
  components: {
    TheHeader,
    DrinkList,
    TheFooter
    
  }
}














