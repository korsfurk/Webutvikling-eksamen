
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
import TheFooter from "../src/layout/TheFooter"
import DrinkList from "@/components/Drinklist"

export default {
  name: "App",
  components: {
    TheHeader,
    TheFooter,
    DrinkList
  }
}












