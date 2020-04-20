<template>
    <div>
        <h1>Delete drink</h1>
    <label>Id</label>
    <input v-model="deleteId" type="text">
    <input @click="deleteDrink" type="button" value="Delete drink">
    <p> {{ deleteStatus}} </p>
    </div>
</template>

<script>
import axios from 'axios'
export default {
    name: "DeleteDrink",
    data(){
        return {
            deleteId: null,
            deleteStatus: "Your item is deleted."
        
        }
    },
    methods: {
        deleteDrink(){
            let webAPIUrl = `https://localhost:8080/admin/${this.deleteId}`;

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