<template>
    <v-card max-width="350px">
        <v-img 
        :src="`https://localhost:5001/images/${drinkImageSrc}`"
        height="200px"
        >
        </v-img>
        <v-card-title>{{ drinkName }}</v-card-title>
        <v-card-subtitle>{{ drinkPrice }}</v-card-subtitle>
    </v-card>
</template>

<script>
export default {
    name: "DrinkItem",
    props: {
        drinkName: {
            type: String
        },
        drinkImageSrc: {
            type: String
        },
        drinkPrice: {
            type: String,
            appear: true 
        }
    }
}
</script>