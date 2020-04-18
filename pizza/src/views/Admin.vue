<template>
  <div class="green light-4">
    <h1>Add, edit or delete from menu</h1>
    <PizzaForm/>
  </div>
</template>


<script>
import PizzaForm from '@/components/PizzaForm'

export default {
  name: "Admin",
  components: {
    PizzaForm
  }
}
</script>


<style scoped>
h1{
  font-family: Arial, Helvetica, sans-serif;
}
</style>

