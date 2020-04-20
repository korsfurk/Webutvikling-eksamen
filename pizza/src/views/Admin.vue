<template>
<div>
  <h3>Add to menu:</h3>
  <AddPizza class="pl-9 ml-9"/>
  <AddDrink class="pl-9 ml-9"/>
  
  <h3>Edit menu</h3>


  <h3>Delete item from menu </h3>
    <DeletePizza class="pl-9 ml-9"/>

</div>
</template>

<script>
import AddPizza from '@/components/AddPizza'
import AddDrink from '@/components/AddDrink'
import DeletePizza from '@/components/DeletePizza'

export default {
  name: "Admin",
  components: {
    AddPizza,
    AddDrink,
    DeletePizza
  }
}
</script>

<style scoped>
h3{
  text-align: center;
  padding-top: 30px;
}
</style>


