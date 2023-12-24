import fetch from "node-fetch";

const baseUrl = `http://localhost:3000/products`;

async function getOneProduct(id) {
    const url = `${baseUrl}/${id}`;
    return await fetch(url)
        .then(res => {
            if (res.status !== 200) {
                console.log("200 kodu dışında bir kod üretildi");
            }
            return res.json()
        });
}

async function getAllProducts() {
    return await fetch(baseUrl, {
        method: "GET",
        headers: {
            "Content-Type": "application/json",
            "Accept": "*/*",
        }
    })
        .then(resp => resp.json());
}

async function updateOneProduct(id, product) {
    const url = `${baseUrl}/${id}`;
    return await fetch(url, {
        method: 'PUT',
        headers: {
            "Content-Type": "application/json",
            "Accept": "*/*",
        },
        body: JSON.stringify(product)
    })
        .then(resp => resp.json());
}

async function deleteOneProduct(id) {
    const response = await fetch(`${baseUrl}/${id}`, {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json',
            'Accept': '*/*',
        },
    });

    return response.json();
}


const product = {
    id: "2",
    name: "Samsung",
    price: 10000
};

const response = await getOneProduct(2);
// const response = await getAllProducts();
// const response = await updateOneProduct(2,product);
// const response = await deleteOneProduct(2);
console.log(response);