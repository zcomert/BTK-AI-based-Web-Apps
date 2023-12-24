import React, { useEffect, useState } from 'react'
import { Link } from 'react-router-dom'
import Header from '../../components/header/Header'
import ProductService from '../../services/ProductService'
// import { products } from './ProductsData'
export default function Products() {

    const [products, setProducts] = useState([]);

    const productService = new ProductService();

    useEffect(() => {
        const fetchData = async () => {
            const productService = new ProductService();
            const data = await productService.getAllProducts();
            setProducts(data);
            console.log(products)
        };
        fetchData();
    }, []);


    return (
        <div>
            <Header data={{ title: "Ürünler" }}></Header>

            <ul>
                {products?.map((prd) => (<li>
                    <Link to={`/productdetail/${prd?.id}`}>{prd?.name}</Link>
                </li>))}
            </ul>

        </div>
    )
}
