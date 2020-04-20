<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" v-for="drink in drinks" :key="drink.drinkId">
                <DrinkItem 
                    :drinkId="drink.drinkId"
                    :drinkName="drink.drinkName"
                    :drinkImagesrc="drink.drinkImagesrc"
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
            drinks: [ { drinkId: 999, drinkName: "TESTFANTA", drinkPrice:"20", drinkImagesrc: "fanta.jpg"}]
        }
    },
    created() {
        axios.get("https://localhost:5001/admin/GetDrinks")
            .then( result => {
                this.drinks = result.data;
            } )
    },
    components: {
        DrinkItem
    }
}
</script>