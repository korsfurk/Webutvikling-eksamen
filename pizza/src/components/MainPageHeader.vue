<template>
  <header>
    <h1>{{pageTitle}}</h1>
    <h2>{{slogan}}</h2>
  </header>
</template>

<script>
export default {
  name: "MainPageHeader",
  props: ["pageTitle", "slogan"]
  
}
</script>

<style scoped>
h1{
    color:lightcoral;
    font-family: Arial, Helvetica, sans-serif;

}

h2{
    font-family: Arial, Helvetica, sans-serif;

}



</style>