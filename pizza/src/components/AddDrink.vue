<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" class="pl-4">
                <h3> New Drink </h3>
                <v-text-field v-model="newDrink.drinkName" label="Name"></v-text-field>
                <v-text-field v-model="newDrink.drinkPrice" label="Price"></v-text-field>
                <v-file-input v-model="file" show-size label="Image"></v-file-input>
                <v-btn @click="postDrink">Save</v-btn>
            </v-col>
        </v-row>
    </div>
</template>

<script>
import axios from 'axios'

export default {
    name: "AddDrink",
    data(){
        return{
            newDrink: { drinkName: "", drinkPrice: "", drinkImagesrc: ""},
            file: null
        
        }
    },
    methods: {
        postDrink(){
            /*console.log(this.newDrink);
            console.log(this.file);*/
            this.newDrink.drinkImagesrc = this.file.name;

            let data = new FormData();
            data.append("file", this.file);

            axios.post("https://localhost:5001/drink", this.newDrink)
            .then( result => {
                console.log(result.data);

                axios({
                    method: "POST",
                    url: "https://localhost:5001/admin/UploadImage",
                    data: data,
                    config: { headers: { 'Content-Type' : 'multipart/form-data' } }
                })
            })
        }
    }
    
}
</script>

<style scoped>


</style>


