import React, { useContext } from 'react'
import { Link } from 'react-router-dom'
import Header from '../../components/header/Header'
// import ProductService from '../../services/ProductService'
// import { products } from './ProductsData'
import AppContext from '../../context/AppContext'
export default function Products() {

    const { products } = useContext(AppContext);

    return (
        <div>
            <Header data={{ title: "Ürünler" }}></Header>
            <ul>
                {products?.map((prd) => (<li key={prd?.id} >
                    <Link to={`/productdetail/${prd?.id}`}>{prd?.name}</Link>
                </li>))}
            </ul>

        </div>
    )
}
