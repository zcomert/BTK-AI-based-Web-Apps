import React, { useState } from 'react'
import { Link, useParams } from 'react-router-dom'
import { products } from '../products/ProductsData';
import Comments from './Comments';
import { Container } from '@mui/material';
import Header from '../../components/header/Header';
import NewComment from './NewComment';

export default function ProductDetail() {

    const { id } = useParams();

    const [selectedProduct, setSelectedProduct] =
        useState(products.find(p => p.id === parseInt(id)));


    if (!selectedProduct) {
        return (<div>
            Ürün bulunamadı.
        </div>)
    }

    return (
        <>
            <Header data={{ title: `${selectedProduct?.name}` }} />
            <Container>
                <h1>
                    {selectedProduct?.name}
                </h1>

                <img src={selectedProduct?.imageUrl}
                    alt={selectedProduct?.name}
                />
                <p>
                    {selectedProduct?.price}
                </p>
                <hr />

                <Comments selectedProduct={selectedProduct} />

                <p>
                    <NewComment />
                </p>

                <p>
                    <Link to="/products">Ürünler</Link>
                </p>
            </Container>
        </>
    )
}
