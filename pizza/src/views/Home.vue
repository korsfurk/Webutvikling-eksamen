
<template>

<div>

  <div>

    <TheHeader/>

</div>

    <TheFooter/>
  </v-app>


  </div>

</template>

<script>

import TheHeader from "../src/layout/TheHeader"
import TheFooter from "..src/layout/TheFooter"

export default {
  name: "App",
  components: {
    TheHeader,
    TheFooter
  }
}












