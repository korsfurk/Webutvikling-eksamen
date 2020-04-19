
<template>
  <div class="green lighten-5">
    <v-container>
    <PizzaList />
    <DrinkList/>
    </v-container>
  </div>

</template>

<script>
import PizzaList from '@/components/PizzaList'
import DrinkList from '@/components/DrinkList'

export default {
  name: "Home",
  components: {
    DrinkList,
    PizzaList
  }
}
</script> 

<style scoped>
  #color{
    width: 100%;
    height: 40%;
    background-color: #B4D7C2;
  }

</style>














