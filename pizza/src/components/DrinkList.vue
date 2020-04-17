<template>
    <div>
        <v-row>
            <v-col v-for="drink in drinks" :key="drink.drinkId">
                <DrinkItem 
                    :drinkId="drink.drinkId"
                    :drinkName="drink.drinkName"
                    :drinkImageSrc="drink.drinkImageSrc"
                    :drinkPrice="drink.drinkPrice"
                    />
            </v-col>
        </v-row>
    </div>
</template>

<script>
import axios from 'axios'
import DrinkItem from '@/components/DrinkItem'

export default {
    name: "DrinkList",
    data(){
        return {
            drinks: [ { drinkId: 999, drinkName: "TESTFANTA", drinkPrice:"20", drinkImageSrc: "fanta.jpg"}]
        }
    },
    created() {
        axios.get("https://localhost:5001/customer/Getdrinks")
            .then( result => {
                this.drinks = result.data;
            } )
    },
    components: {
        DrinkItem
    }
}
</script>