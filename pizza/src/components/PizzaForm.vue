<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" class="mx-auto">
                <v-text-field v-model="newPizza.name" label="Navn"></v-text-field>
                <v-file-input v-model="file" show-size></v-file-input>
                <v-btn @click="postPizza">Lagre ny Pizza</v-btn>
            </v-col>
        </v-row>
    </div>
</template>

<script>
import axios from 'axios'
export default {
    name: "PizzaForm",
    data(){
        return {
            newPizza: { name: "", imageSrc: "" },
            file: null
        }
    },
}
    methods: {
        postPizza();
            this.newPizza.imageSrc = this.file.name;

            let data = new FormData();
            data.append("file", this.file);

            axios.post("https://localhost:5001/mypets", this.newPizza)
                .then( result => {
                    console.log( result.data );

                    axios({
                        method: "POST",
                        url: "https://localhost:5001/mypetsadmin/UploadImage",
                        data: data,
                        config: { headers: { 'Content-Type': 'multipart/form-data' } }       
                    })

                } )
        }
    

</script>