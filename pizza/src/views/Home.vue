
<template>
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














