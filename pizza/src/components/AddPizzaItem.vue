<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" class="mx-auto">
                <v-text-field label="Name"></v-text-field>
                <v-text-field label="Price"></v-text-field>
                <v-text-field label="Description"></v-text-field>
                <v-file-input show-size label="Image"></v-file-input>
            </v-col>
        </v-row>
    </div>
</template>

<script>
export default {
    name: "AddMenuItem",
    data(){
        return {
            newPizza
        }
    }
}
</script>