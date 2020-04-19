<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" class="mx-auto">
                <v-text-field v-model="newPizza.pizzaName" label="Name"></v-text-field>
                <v-text-field v-model="newPizza.pizzaPrice" label="Price"></v-text-field>
                <v-text-field v-model="newPizza.pizzaDescription" label="Description"></v-text-field>
                <v-file-input v-model="file" show-size label="Image"></v-file-input>
                <v-btn @click="postPizza">Lagre</v-btn>
            </v-col>
        </v-row>
    </div>
</template>

<script>
import axios from 'axios'

export default {
    name: "AddPizzaItem",
    data(){
        return {
            newPizza: { pizzaName: "", pizzaPrice: "", pizzaDescription: "", pizzaImageSrc: "" },
            file: null
        }
    },
    methods: {
        postPizza(){
            this.newPizza.pizzaImageSrc = this.file.name;

            let data = new FormData();
            data.append("file", this.file);

            axios.post( "https://localhost:5001/customer", this.newPizza )
                .then( result => {
                    console.log(result.data);

                    axios({
                        method: "POST",
                        url: "https://localhost:5001/admin/UploadImage",
                        data: data,
                        config: { headers: { 'Content-Type' : 'multipart/form-data' } }
                    })
                } )
        }
    }
}

        /*this.newPizza.pizzaImageSrc = this.file.name;

        let data = new FormData();
            data.append("file", this.file);

        axios.post("https://localhost:5001/admin/GetFoods", this.newPizza)
            .then( result => {
                console.log( result.data );

            axios({
                method: "POST",
                url: "https://localhost:5001/mypetsadmin/UploadImage",
                data: data,
                config: { headers: { 'Content-Type': 'multipart/form-data' } }       
            })

        })
}*/
</script>