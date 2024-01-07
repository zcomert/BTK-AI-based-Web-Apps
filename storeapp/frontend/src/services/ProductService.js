import axios from "axios";

class ProductService {
    constructor() {
        this.baseUrl = `${process.env.REACT_APP_API_URL}/products`;
        // this.baseUrl = `${process.env.REACT_APP_JSON_API_URL}/products`;
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

    async addOneComment(id, text) {
        // baseUrl/api/products/{id}/comments
        const url = `${this.baseUrl}/${id}/comments`;
        const body = {
            text: text
        };
        const { data } = await axios.post(url, body);
        return data;
    }
}
export default ProductService;