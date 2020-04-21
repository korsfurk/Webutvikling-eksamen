<template>
    <div>
        <h1 class="font-weight-light"> Edit pizza</h1>
        <label>Id</label>
        <v-text-field v-model="editId" label="Id">></v-text-field>
        <v-btn @click="getPizza">Get pizza</v-btn>
       
        <hr>
        <label> Pizza </label>
        <v-text-field v-model="editId" label="Id">></v-text-field>
        <v-btn @click="getPizza">Save pizza</v-btn>
        
       

    </div>
</template>

<script>
import axios from 'axios'
export default {
    name:"EditPizza",
    data(){
        return{
            editId: "",
            editPizza: {},
            
        }
    },
    methods: {
        getDrink(){
            let webAPIUrl = `https://localhost:8080/admin/${this.editId}`;
            axios.get(webAPIUrl )
            .then( result => {
                this.editPizza = result.data;
            })
        },
        putDrink(){
            let webAPIUrl = "https://localhost:8080/admin";
            axios.put(webAPIUrl, this.editPizza)
        }
    }
    
}
</script>