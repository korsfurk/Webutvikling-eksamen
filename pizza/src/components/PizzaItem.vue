<template>
    <v-card max-width="350px">
        <v-img 
            :src="`https://localhost:5001/images/${pizzaImageSrc}`"
            height="200px"
            >
        </v-img>
        <v-card-title>{{ pizzaName }}</v-card-title>
        <v-card-subtitle>{{ pizzaPrice }}</v-card-subtitle>
       
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
                <v-card-text>{{ PizzaDescription }}</v-card-text>
            </div>
        </v-expand-transition> 

    </v-card>
</template>

<script>
export default {
    name: "PizzaItem",
    props: {
        PizzaName: {
            type: String
        },
        PizzaImageSrc: {
            type: String
        },
        Pizzaprice: {
            type: String
        },
        PizzaDescription: {
            type: String
        }
    },
    data: () => ({
        show: false,
    })
    
}
</script>
