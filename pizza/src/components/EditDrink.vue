<template>
    <div>
        <h1> Edit drink</h1>
        <label>Id</label>
        <v-text-field v-model="editId" label="Id">></v-text-field>
        <v-btn @click="getDrink">Get drink</v-btn>
       
        <hr>
        <label> Drink </label>
        <v-text-field v-model="editId" label="Id">></v-text-field>
        <v-btn @click="getDrink">Save drink</v-btn>
        
       

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
            let webAPIUrl = `https://localhost:8080/drink/${this.edited}`;
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