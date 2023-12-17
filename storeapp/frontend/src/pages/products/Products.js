import React from 'react'
import { products } from './ProductsData'
export default function Products() {
    return (
        <div>
            <h1>
                Products {products?.length}
            </h1>

            <ul>
                {products?.map((prd) => (<li>
                    {prd?.name}
                </li>))}
            </ul>

        </div>
    )
}
