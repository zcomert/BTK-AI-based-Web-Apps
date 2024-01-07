import axios from "axios";

class SentimentService {
    constructor() {
        this.baseUrl = `${process.env.REACT_APP_ML}/predict`;
    }

    async makePredict(text) {
        const { data } = await axios.post(this.baseUrl, {
            text: text
        });

        return data;
    }
}

export default SentimentService;