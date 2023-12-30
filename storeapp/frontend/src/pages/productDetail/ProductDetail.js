import React, { useContext, useEffect, useState } from 'react'
import { Link, useParams } from 'react-router-dom'
import Comments from './Comments';
import { Container } from '@mui/material';
import Header from '../../components/header/Header';
import NewComment from './NewComment';
import AppContext from '../../context/AppContext';
import ProductService from '../../services/ProductService';

export default function ProductDetail() {

    const { id } = useParams();
    const { setLoad } = useContext(AppContext);

    const [selectedProduct, setSelectedProduct] = useState(null);

    useEffect(() => {
        setLoad(true);
        const productService = new ProductService();
        productService
            .getOneProductById(id)
            .then(resp => {
                setSelectedProduct(resp)
                setLoad(false);
            })
    }, [])



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
                    <NewComment selectedProduct={selectedProduct}
                        setSelectedProduct={setSelectedProduct} />
                </p>

                <p>
                    <Link to="/products">Ürünler</Link>
                </p>
            </Container>
        </>
    )
}
