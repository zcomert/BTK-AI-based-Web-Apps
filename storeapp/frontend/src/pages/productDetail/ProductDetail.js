import React, { useContext, useEffect, useState } from 'react'
import { Link, useNavigate, useParams } from 'react-router-dom'
import Comments from './Comments';
import { Button, Container, ListItemIcon } from '@mui/material';
import Header from '../../components/header/Header';
import NewComment from './NewComment';
import AppContext from '../../context/AppContext';
import ProductService from '../../services/ProductService';
import MenuIcon from '@mui/icons-material/Menu';
import ViewListIcon from '@mui/icons-material/ViewList';

export default function ProductDetail() {

    const { id } = useParams();
    const { setLoad } = useContext(AppContext);
    const navigate = useNavigate();

    const [selectedProduct, setSelectedProduct] = useState(null);

    useEffect(() => {
        setLoad(true);
        const productService = new ProductService();
        productService
            .getOneProductById(id)
            .then(resp => {
                setSelectedProduct(resp)
                console.log(selectedProduct)
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

                <img src={selectedProduct?.imageURL}
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

                {/* <p>
                    <Button
                        onClick={() => { navigate("/products") }}
                        startIcon={<ViewListIcon />}
                        variant='outlined'>
                        Ürünüler
                    </Button>
                </p> */}
            </Container>
        </>
    )
}
