<template>
    <div>
        <v-row>
            <v-col v-for="drink in drinks" :key="drink.drinkId">
                <DrinkItem 
                    :drinkId="drink.drinkId"
                    :drinkName="drink.drinkName"
                    :drinkImageSrc="drink.drinkImageSrc"
                    />
            </v-col>
        </v-row>
    </div>
</template>

<script>
export default {
    name: "DrinkList",
    data(){
        return {
            drinks: [ { drinkId: 999, drinkName: "TESTFANTA", drinkImageSrc: "fanta.jpg"}]
        }
    }
}
</script>