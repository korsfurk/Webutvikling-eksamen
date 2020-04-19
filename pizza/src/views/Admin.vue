<template>
<div>
  <h3>Add new item to menu:</h3>
  <AddPizzaItem />
  <h3>Edit item from menu</h3>
  <h3>Delete item from menu </h3>
</div>
</template>

<script>
import AddPizzaItem from '@/components/AddPizzaItem'

export default {
  name: "Admin",
  components: {
    AddPizzaItem
  }
}
</script>

<style scoped>
h3{
  text-align: center;
  padding-top: 30px;
}
</style>


