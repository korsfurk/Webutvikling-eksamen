<template>
    <footer>
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
        <section>
            <h3>Privacy Policy</h3>
            <ul>
                <li 
                    v-for="(value, name, index) in privacyPolicy"
                    v-bind:key="index">
                    {{value}}
                </li>
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

<style scoped>
h3{
    background-color: #C8E6C9;
    text-align: center;
    color: white;
    
}

li{
    background-color: #C8E6C9;
    text-align: center;
    list-style-type: none;
      

}

ul{
    background-color: #C8E6C9;
}



footer{
    position: absolute;
    bottom: 0;
    width: 100%;
    padding-bottom:2.5rem;
    height:5rem;

}
</style>