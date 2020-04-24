<template>
<!--Content-->
    <div>
        <v-col cols="12" sm="6" lg="4">
        <h1 class="font-weight-light"> Edit drink</h1>
        <label>Id</label>
        <input v-model="editId " type="text">
        <input @click="getDrink" type="button" value=" Get drink">
        
        <hr>
        <label> Drink </label>
        <input v-model="editDrink.drink" type="text">
        <label> New drink </label>
        <input v-model="editDrink.newDrink" type="text">
        <input @click="putDrink" type="button" value="Save drink">

     
        
       </v-col>

    </div>
</template>

<script>
import axios from 'axios'
export default {
    name:"EditDrink",
    data(){
        return{
            editId: "",
            editDrink: {},
            
        }
    },
    methods: {
        getDrink(){
            let webAPIUrl = `https://localhost:8080/drink/${this.editId}`;
            axios.get(webAPIUrl )
            .then( result => {
                this.editDrink = result.data;
            })
        },
        putDrink(){
            let webAPIUrl = "https://localhost:8080/drink";
            axios.put(webAPIUrl, this.editDrink)
        }
    }
    
}
</script>