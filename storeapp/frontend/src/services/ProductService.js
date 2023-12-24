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
}

export default ProductService;