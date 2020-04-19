
<template>
<div>

  <div>

    <TheHeader/>

    <h1>Menu</h1>
  <div class="green lighten-4">
    <v-container>
    <PizzaList/>

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

</script> 

<style scoped>
 
    
    
  
</style>















