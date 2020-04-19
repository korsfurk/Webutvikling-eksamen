<template>
<div>
  <h1>Add new item to menu:</h1>
  <AddPizzaItem />
</div>
</template>

<script>
import AddPizzaItem from '@/components/AddMenuItem'

export default {
  name: "Admin",
  components: {
    AddPizzaItem
  }
}
</script>

<style scoped>
h1{
  text-align: center;
  padding-top: 30px;
}
</style>


