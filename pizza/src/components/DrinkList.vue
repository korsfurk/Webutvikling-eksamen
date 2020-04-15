<template>
    <div>
        <v-row>
            <v-col v-for="drink in drinks" :key="drink.DrinkId">
                <DrinkItem 
                    :DrinkId="drink.DrinkId"
                    :DrinkName="drink.DrinkName"
                    :DrinkImageSrc="drink.DrinkImageSrc"
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
            drinks: [ { DrinkId: 999, DrinkName: "TESTFANTA", DrinkImageSrc: "fanta.jpg"}]
        }
    }
}
</script>