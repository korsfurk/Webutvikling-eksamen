<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" class="mx-auto">
                <v-text-field v-model="newPizza.pizzaName" label="Name"></v-text-field>
                <v-text-field v-model="newPizza.pizzaPrice" label="Price"></v-text-field>
                <v-text-field v-model="newPizza.pizzaDescription" label="Description"></v-text-field>
                <v-file-input show-size label="Image"></v-file-input>
                <v-btn>Lagre</v-btn>
            </v-col>
        </v-row>
    </div>
</template>

<script>
export default {
    name: "AddMenuItem",
    data(){
        return {
            newPizza: { pizzaName: "", pizzaPrice: "", pizzaDescription: "", pizzaImagesrc: "" },
            file: null
        }
    }
}
</script>