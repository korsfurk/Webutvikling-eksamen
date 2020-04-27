<template>
    <v-card max-width="350px">
        <v-img 
        :src="`https://localhost:5001/images/${drinkImagesrc}`"
        height="200px"
        >
        </v-img>
        <v-card-title>{{ drinkName }}</v-card-title>
        <v-card-subtitle>{{ drinkPrice }} kr</v-card-subtitle>

        <!--<v-card-actions>
             <v-rating 
                v-model="rating"
                background-color="grey lighten-1"
                color="yellow accent-4"
                hover
                size="24"
            >
            </v-rating>
        </v-card-actions>-->
    </v-card>
</template>

<script>
export default {
    name: "DrinkItem",
    props: {
        drinkName: {
            type: String
        },
        drinkImagesrc: {
            type: String,
            default: "outofstock.png"
        },
        drinkPrice: {
            type: String 
        }
    }
}
</script>