<template>
<!--Content-->
    <div>
        <v-row>
            <v-col >
                <h3 class="font-weight-light"> Edit drink</h3>
                <v-text-field v-model="editId" label="Id for drink you want to edit"></v-text-field>
                <v-btn @click="getDrink">Get drink</v-btn>
                

                <v-text-field v-model="editDrink.drinkName" label="Edit drink name"></v-text-field>
                <v-text-field v-model="editDrink.drinkPrice" label="Edit price"></v-text-field>
                <!--<v-file-input v-model="file" label></v-file-input>-->
                <v-btn @click="putDrink">Save pizza</v-btn>
                
            </v-col>
       </v-row>

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
            let webAPIUrl = `https://localhost:5001/drink/${this.editId}`;
            axios.get(webAPIUrl )
            .then( result => {
                this.editDrink = result.data;
                console.log(this.editDrink);
            })
        },
        putDrink(){
            let webAPIUrl = "https://localhost:5001/drink";
            axios.put(webAPIUrl, this.editDrink)
        }
    }
    
}
</script>