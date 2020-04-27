<template>
<!--Content-->
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4">
                <h3 class="font-weight-light"> Edit pizza</h3>
                <v-text-field v-model="editId" label="Id for pizza you want to edit"></v-text-field>
                <v-btn @click="getPizza">Get pizza</v-btn>
                
                <v-divider inset></v-divider>

                <v-text-field v-model="editPizza.pizzaName" label="Edit pizza name"></v-text-field>
                <v-text-field v-model="editPizza.pizzaPrice" label="Edit price"></v-text-field>
                <v-text-field v-model="editPizza.pizzaDescription" label="Edit description"></v-text-field>
                <!--<v-file-input v-model="file" label></v-file-input>-->
                <v-btn @click="putPizza">Save pizza</v-btn>
                
            </v-col>
       </v-row>

    </div>
</template>

<script>
import axios from 'axios'
export default {
    name:"EditPizza",
    data(){
        return{
            editId: "",
            editPizza: {}
            
        }
    },
    
    methods: {
        getPizza(){
            let webAPIUrl = `https://localhost:5001/food/${this.editId}`;
            axios.get(webAPIUrl )
            .then( result => {
                this.editPizza = result.data;
                //console.log(this.editPizza.pizzaName);
            })
        },
        putPizza(){
            let webAPIUrl = "https://localhost:5001/food";
            axios.put(webAPIUrl, this.editPizza)
        }
    }
    
}
</script>