<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4">
                <h3>Delete Pizza</h3>
                <v-text-field v-model="foodId" label="Id"></v-text-field>
                <v-btn @click="deleteFood">Delete Pizza</v-btn>
                <p>{{ deleteStatus }}</p>
            </v-col>
        </v-row>
    </div>
</template>

<script>
import axios from 'axios'

export default {
    name: "DeletePizza",
    data() {
        return {
            foodId: null,
            deleteStatus: "Nothing is deleted yet."
        }
    },
    
    methods: {
        deleteFood(){
            
            let webApiUrl = `https://localhost:5001/admin/${this.foodId}`;
            
            axios.delete( webApiUrl )
                .then(
                    result => {
                        this.deleteStatus = JSON.stringify( result.data );
                    }
               )
        }
    }
}
</script>

<style scoped>
.h3{
    font-family: Arial, Helvetica, sans-serif;
}
</style>

