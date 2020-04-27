<template>
<!--Overskrifter på siden -->
<div>
  <h3 class="font-weight-light green lighten-4">ADD TO MENU</h3>
  <v-container class="green lighten-5">
    <v-row>
      <v-col cols="12" sm="6" >
        <AddPizza/>
      </v-col>
      
      <v-col cols="12" sm="6">
        <AddDrink />
      </v-col>

    </v-row>
  </v-container>
   
  <h3 class="font-weight-light green lighten-4">EDIT ITEM FROM MENU</h3>
    <v-container class="green lighten-5">
    <v-row>
      
      <v-col cols="12" sm="6" >
        <EditPizza/>
      </v-col>
      
      <v-col cols="12" sm="6">
        <EditDrink />
      </v-col>

    </v-row>
  </v-container>
    
  <h3 class="font-weight-light green lighten-4">DELETE ITEM FROM MENU </h3>
    <v-container class="green lighten-5">
    <v-row>
      
      <v-col cols="12" sm="6" >
        <DeletePizza/>
      </v-col>
      
      <v-col cols="12" sm="6">
        <DeleteDrink />
      </v-col>

    </v-row>
  </v-container>



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

/*.add{
  position: relative;
  width: 100%;
  height: 400px;
}

.addPizza{
  position: absolute;
  left: 10%;
  width: 100%;
}

.addDrink{
  position: absolute;
  left: 50%;
  width: 100%;
}*/
</style>


