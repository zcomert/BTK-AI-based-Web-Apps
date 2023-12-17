import React from 'react'
import { Link, useParams } from 'react-router-dom'
import { products } from '../products/ProductsData';

export default function ProductDetail() {

    const { id } = useParams();

    const selectedProduct = products
        .find(p => p.id === parseInt(id));

    if (!selectedProduct) {
        return (<div>
            Ürün bulunamadı.
        </div>)
    }

    return (
        <div>
            <h1>
                {selectedProduct?.name}
            </h1>

            <img src={selectedProduct?.imageUrl}
                alt={selectedProduct?.name}
            />
            <p>
                {selectedProduct?.price}
            </p>
            <p>
                <Link to="/products">Ürünler</Link>
            </p>
        </div>
    )
}
