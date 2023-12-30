import axios from "axios";

class ProductService {
    constructor() {
        this.baseUrl = 'http://localhost:3000/products';
    }

    async getAllProducts() {
        const { data } = await axios
            .get(this.baseUrl);
        
        return data;
    }

    async getOneProductById(id) {
        // endpoint : localhost:3000/products/:id
        const url = `${this.baseUrl}/${id}`;
        const { data } = await axios.get(url);
        return data;
    }
}

export default ProductService;