<template>
    <v-card>
        <v-img 
            :src="`https://localhost:5001/images/${imageSrc}`"
            height="200px"
            >
        </v-img>
        <v-card-title>{{ PizzaName }}</v-card-title>
    </v-card>
</template>

<script>
export default {
    name: "PizzaItem",
    props: {
        name: {
            type: String
        },
        imageSrc: {
            type: String
        }
    }
}
</script>
