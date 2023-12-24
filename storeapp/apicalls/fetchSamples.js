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


const response = await getOneProduct();
console.log(response);