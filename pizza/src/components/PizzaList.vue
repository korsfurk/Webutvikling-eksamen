<template>
    <div>
        <v-row>
            <v-col v-for="pizza in pizzas" :key="pizza.pizzaId">
                <PizzaItem 
                    :pizzaId="pizza.pizzaId" 
                    :pizzaName="pizza.pizzaName" 
                    :pizzaImageSrc="pizza.pizzaImageSrc"
                    :pizzaPrice="pizza.pizzaPrice"  
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
            pizzas: [ { id: 999, name: "TESTPIZZA", imageSrc: "beef.jpg" } ]
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