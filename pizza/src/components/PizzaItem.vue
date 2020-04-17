<template>
    <v-card max-width="350px">
        <v-img 
            :src="`https://localhost:5001/images/${pizzaImageSrc}`"
            height="200px"
            >
        </v-img>
        <v-card-title>{{ pizzaName }}</v-card-title>
        <v-card-subtitle>{{ pizzaPrice }} kr</v-card-subtitle>
       
        <v-card-actions>
            <v-btn text> Order </v-btn>
            <v-spacer></v-spacer>
            <v-btn 
                icon 
                @click="show = !show"
            >
                <v-icon>{{ show ? 'mdi-chevron-up' : 'mdi-chevron-down' }}</v-icon>
            </v-btn>
        </v-card-actions>

        <v-expand-transition>
            <div v-show="show">
                <v-divider></v-divider>
                <v-card-text>{{ pizzaDescription }}</v-card-text>
            </div>
        </v-expand-transition> 

    </v-card>
</template>

<script>
export default {
    name: "PizzaItem",
    props: {
        pizzaName: {
            type: String
        },
        pizzaImageSrc: {
            type: String
        },
        pizzaPrice: {
            type: String
        },
        pizzaDescription: {
            type: String
        }
    },
    data: () => ({
        show: false,
    })
    
}
</script>
