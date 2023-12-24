import axios from "axios";

const baseUrl = `http://localhost:3000/products`;

async function getOneProduct(id) {
    const url = `${baseUrl}/${id}`;
    const { data, status } = await axios.get(url)
    return data;
}

async function getAllProducts() {
    const { data, status } = await axios.get(baseUrl)
    return data;
}

async function createOneProduct(product) {
    const { data } = await axios.post(baseUrl, product)
    return data;
}

async function updateOneProduct(id, product) {
    const { data } = await axios.put(`${baseUrl}/${id}`, product)
    return data;
}

async function deleteOneProduct(id) {
    const { data } = await axios.delete(`${baseUrl}/${id}`)
    return data;
}

const product = {
    "id": 21,
    "name": "Black C. Latte",
    "price": 175
};

// const response = await getOneProduct(16);
// const response = await getAllProducts();
// const response = await createOneProduct(product);
// const response = await updateOneProduct(21, product);
const response = await deleteOneProduct(21);
console.log(response);