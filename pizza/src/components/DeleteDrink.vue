<template>
    <div>
        <v-row>
            <v-col >
                <h3 class="font-weight-light">Delete Drink</h3>
                <v-text-field v-model="drinkId" label="Id"></v-text-field>
                <v-btn @click="deleteDrink"> Delete Drink</v-btn>
                <p> {{ deleteStatus}}</p>
            </v-col>


        </v-row>
    </div>
</template>

<script>
import axios from 'axios'
export default {
    name: "DeleteDrink",
    data(){
        return {
            drinkId: null,
            deleteStatus: "Nothing is deleted yet."
        }
    },
    methods: {
        deleteDrink(){
            let webAPIUrl = `https://localhost:5001/drink/${this.drinkId}`;

            axios.delete( webAPIUrl)
            .then(
                result=> {
                    this.deleteStatus = JSON.stringify( result.data);
                }
            )
        }
    }
}
</script>