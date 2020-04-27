<template>
<!--Overskrifter på siden -->
<div>
  <h3 class="font-weight-light">ADD TO MENU</h3>
  
      <AddPizza class="pl-9 ml-9"/>
      <AddDrink class="pl-9 ml-9"/>
   

  <h3 class="font-weight-light">EDIT ITEM FROM MENU</h3>
  <EditDrink class="pl-9 ml-9"/>
  <EditPizza class="pl-9 ml-9"/>


  <h3 class="font-weight-light">DELETE ITEM FROM MENU </h3>
    <DeletePizza class="pl-9 ml-9"/>
    <DeleteDrink class="pl-9 ml-9"/>


</div>
</template>

<!-- Disse komponentene blir det hentet data ifra-->
<script>
import AddPizza from '@/components/AddPizza'
import AddDrink from '@/components/AddDrink'
import EditDrink from '@/components/EditDrink'
import EditPizza from '@/components/EditPizza'
import DeleteDrink from '@/components/DeleteDrink'
import DeletePizza from '@/components/DeletePizza'


export default {
  name: "Admin",
  components: {
    AddPizza,
    AddDrink,
    EditDrink,
    EditPizza,
    DeleteDrink,
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


