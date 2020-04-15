<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" v-for="pizza in pizzas" :key="pizza.id">
                <PetItem 
                    :id="pizza.id" 
                    :name="pizza.name" 
                    :imageSrc="pizza.imageSrc"  />
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
            pizzas: [ { 
                id: 999, name: "TESTPIZZA", imageSrc: "fido.jpg"  
            } ]
        }
    },
    created(){
        axios.get("https://localhost:5001/mypets")
            .then( result => {
                this.pizzas = result.data;
            } )
    },
    components: {
        PizzaItem
    }
}
</script>