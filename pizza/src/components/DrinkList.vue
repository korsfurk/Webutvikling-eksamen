<template>
    <div>
        <v-row>
            <v-col v-for="drink in drinks" :key="drink.drinkId">
                <DrinkItem 
                    :drinkId="drink.drinkId"
                    :drinkName="drink.drinkName"
                    :drinkImageSrc="drink.drinkImageSrc"
                    :drinkprice="drink.drinkPrice"
                    />
            </v-col>
        </v-row>
    </div>
</template>

<script>
import DrinkItem from '@/components/DrinkItem'

export default {
    name: "DrinkList",
    data(){
        return {
            drinks: [ { drinkId: 999, drinkName: "TESTFANTA", drinkPrice:"20", drinkImageSrc: "fanta.jpg"}]
        }
    },
    components: {
        DrinkItem
    }
}
</script>