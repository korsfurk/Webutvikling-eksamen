const SponsorStore = {

    state: {
        sponsors: [
            { id: 1, name: "Møllerens" },
            { id: 2, name: "Tine" }
        ]
    },
    getSponsors(){
        return this.state.sponsors.map( sponsor => sponsor );
    }


}

export default SponsorStore;