<template>
<div>
  <h3>Add to menu:</h3>
  <AddPizza class="pl-9 ml-9"/>
  
  <h3>Edit item from menu</h3>
  <h3>Delete item from menu </h3>
</div>
</template>

<script>
import AddPizza from '@/components/AddPizza'

export default {
  name: "Admin",
  components: {
    AddPizza
  }
}
</script>

<style scoped>
h3{
  text-align: center;
  padding-top: 30px;
}
</style>


