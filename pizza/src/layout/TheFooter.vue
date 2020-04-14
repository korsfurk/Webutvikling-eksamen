<template>
    <footer>
        <section>
            <h3>Contact Info</h3>
            <ul>
                <li 
                    v-for="(value, name, index) in contactInfo"
                    v-bind:key="index">
                    {{name}} : {{value}}
                </li>
            </ul>
        </section>
        <section>
            <h3>Privacy Policy</h3>
            <ul>
                <li></li>
            </ul>
        </section>
    </footer>
</template>

<script>
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
            }
        }
    }
}
</script>