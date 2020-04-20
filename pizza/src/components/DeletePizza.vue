<template>
    <div>
        <h1>Delete pizza</h1>
        <v-text-field>Id</v-text-field>
        <input v-model="deleteId" type="text">
        <input @click="deletePizza" type="button" value="Delete Pizza">
        <p>{{ deleteStatus }}</p>
    </div>
</template>

<script>
import axios from 'axios'

export default {
    name: "DeletePizza",
    data() {
        return {
            deleteId: null,
            deleteStatus: "Nothing is deleted yet"
        }
    },
    methods: {
        deletePizza(){
            let webApiUrl = `https://localhost:5001/admin/GetFoods/${this.deleteId}`;

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