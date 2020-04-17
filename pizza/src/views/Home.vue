
<template>
  <div>

    <TheHeader/>

    <section id="bg"></section>
    <DrinkList/>

    <TheFooter/>
  </div>

</template>

<script>

import TheHeader from "../src/layout/TheHeader"
import DrinkList from "@/components/DrinkList"
import TheFooter from "../src/layout/TheFooter"


export default {
  name: "App",
  components: {
    TheHeader,
    DrinkList,
    TheFooter
    
  }
}















