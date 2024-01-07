import axios from "axios";

class ProductService {
    constructor() {
        this.test = `${process.env.REACT_APP_DOTNETBACKEND}`;
        console.log("testurl", this.test);

        this.baseUrl = 'http://localhost:5265/api/products';
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

    async updateOneProduct(id, product) {
        // [PUT] endpoint : localhost:3000/products/:id
        const url = `${this.baseUrl}/${id}`;
        const { data } = await axios.put(url, product);
        return data;
    }
}
export default ProductService;