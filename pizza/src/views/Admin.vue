<template>
  <div class="Admin">
    <PizzaList/>
    <DrinkList/>
  </div>
</template>


<script>
import PizzaList from '@components/PizzaList'
import DrinkList from '@components/DrinkList'

export default {
  name: "Admin",
  components: {
    PizzaList,
    DrinkList
  }
}
</script>


<style scoped>
h1{
  font-family: Arial, Helvetica, sans-serif;
}
</style>

