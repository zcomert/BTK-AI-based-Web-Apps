import React from 'react'
import { products } from './ProductsData'
import Product from '../product/Product'
import { Link } from 'react-router-dom'
import Header from '../../components/header/Header'
export default function Products() {
    return (
        <div>
            <Header data={{title:"Ürünler"}}></Header>

            <ul>
                {products?.map((prd) => (<li>
                    <Link to={`/productdetail/${prd?.id}`}>{prd?.name}</Link>
                </li>))}
            </ul>

        </div>
    )
}
