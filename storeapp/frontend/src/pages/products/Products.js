import React from 'react'
import { products } from './ProductsData'
import Product from '../product/Product'
import { Link } from 'react-router-dom'
export default function Products() {
    return (
        <div>
            <h1>
                Products {products?.length}
            </h1>

            <ul>
                {products?.map((prd) => (<li>
                    <Link to={`/productdetail/${prd?.id}`}>{prd?.name}</Link>
                </li>))}
            </ul>

        </div>
    )
}
