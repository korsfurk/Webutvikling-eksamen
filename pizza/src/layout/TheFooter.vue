<template>
    <footer>
        <v-row>
            <v-col cols="12" sm="6" lg="4">
                <section>
                <h3>Privacy Policy</h3>
                <ul>
                    <li 
                        v-for="(value, name, index) in privacyPolicy"
                        v-bind:key="index">
                        {{value}}
                    </li>
                </ul>
                
                <h3>Sponsors</h3>
                <ul>
                    <li v-for="sponsor in sponsors" :key="sponsor.id">
                        {{ sponsor.name }}
                    </li>
                </ul>
                </section>
            </v-col>
            <v-col cols="12" sm="6" lg="4">
                <section>
                <h3>Contact Info</h3>
                <ul>
                    <li 
                        v-for="(value, name, index) in contactInfo"
                        v-bind:key="index">
                        {{value}}
                    </li>
                </ul>
                </section>
            </v-col>
            <v-col cols="12" sm="6" lg="4">
                <section>
                <v-btn class="mr-3" id="home-btn" to="/">Home</v-btn>
                <v-btn class="mr-3" to="/admin">Admin</v-btn>
                </section>
            </v-col>
        </v-row>
    </footer>
</template>

<script>
import SponsorStore from '@/stores/SponsorStores.js'

export default {
    name: "TheFooter",
    data(){
        return {
            contactInfo: {
                name: "Pizza Q U A R A N T I N E",
                type: "Takeaway pizza restaurant",
                phoneNumber: "661 34 567",
                email: "order@quarantine.no"
            },
            privacyPolicy: {
                name: "Read more here.."
            },
            sponsors: SponsorStore.getSponsors()
        }
    }
}
</script>

<style scoped>


li{
    list-style-type: none;
}
</style> 