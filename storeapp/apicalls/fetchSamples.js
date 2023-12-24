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


// const response = await getOneProduct();
const response = await getAllProducts();
console.log(response);