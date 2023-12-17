import React from 'react'
import { products } from './ProductsData'
import Product from '../product/Product'
export default function Products() {
    return (
        <div>
            <h1>
                Products {products?.length}
            </h1>

            <ul>
                {products?.map((prd) => (<li>
                    <Product product={prd} />
                </li>))}
            </ul>

        </div>
    )
}
