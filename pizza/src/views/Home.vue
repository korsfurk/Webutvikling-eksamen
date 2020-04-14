
<template>
<v-app>
    <TheHeader/>
    <TheFooter/>
  </v-app>
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












