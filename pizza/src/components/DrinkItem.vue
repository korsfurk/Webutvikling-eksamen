<template>
    <v-card>
        <v-img :src="`https://localhost:5001/images/${DrinkImageSrc}`"
        height="200px"
        >
        </v-img>
        <v-card-title>{{ DrinkName }}</v-card-title>
        <v-card-subtitle>{{ DrinkPrice }}</v-card-subtitle>
    </v-card>
</template>

<script>
export default {
    name: "DrinkItem",
    props: {
        DrinkName: {
            type: String
        },
        DrinkImageSrc: {
            type: String
        },
        DrinkPrice: {
            type: String
        }
    }
}
</script>