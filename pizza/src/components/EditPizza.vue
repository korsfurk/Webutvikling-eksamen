<template>
<!--Content-->
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4">
                <h3 class="font-weight-light"> Edit pizza</h3>
                <v-text-field v-model="editId" label="Id for pizza you want to edit"></v-text-field>
                <v-btn @click="getPizza">Get pizza</v-btn>
                
                <v-divider inset vertical></v-divider>

                <v-text-field v-model="editPizza" label="Pizza">></v-text-field>
                <v-btn @click="putPizza">Save pizza</v-btn>
                
            </v-col>
       </v-row>

    </div>
</template>

<!--Content-->
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
        getPizza(){
            let webAPIUrl = `https://localhost:5001/food/${this.editId}`;
            axios.get(webAPIUrl )
            .then( result => {
                this.editPizza = result.data;
            })
        },
        putPizza(){
            let webAPIUrl = "https://localhost:5001/food";
            axios.put(webAPIUrl, this.editPizza)
        }
    }
    
}
</script>