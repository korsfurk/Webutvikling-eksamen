<template>
    <div>
        <v-row>
            <v-col v-for="pizza in pizzas" :key="pizza.pizzaId">
                <PizzaItem 
                    :pizzaId="pizza.pizzaId" 
                    :pizzaName="pizza.pizzaName" 
                    :pizzaImageSrc="pizza.pizzaImageSrc"
                    :pizzaPrice="pizza.pizzaPrice"
                    :pizzaDescription="pizza.pizzaDescription"  
                    />
            </v-col>
        </v-row>
    </div>
</template>

<script>
import axios from 'axios'
import PizzaItem from '@/components/PizzaItem'

export default {
    name: "PizzaList",
    data(){
        return {
            pizzas: [ { pizzaId: 999, pizzaName: "TESTPIZZA", pizzaImageSrc: "beef.jpg", pizzaPrice: "200", pizzaDescription: "God." } ]
        }
    },
    created(){
        axios.get("https://localhost:5001/customer")
            .then( result => {
                this.pizzas = result.data;
            } )
    },
    components: {
        PizzaItem
    }
}
</script>