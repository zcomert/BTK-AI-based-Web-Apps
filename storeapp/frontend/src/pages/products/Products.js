import React, { useContext } from 'react'
import { Link } from 'react-router-dom'
import Header from '../../components/header/Header'
// import ProductService from '../../services/ProductService'
// import { products } from './ProductsData'
import AppContext from '../../context/AppContext'
import { Container, Grid } from '@mui/material';
import ProductCard from '../product/productCart/ProductCard';
export default function Products() {

    const { products } = useContext(AppContext);

    return (
        <div>
            <Header data={{ title: "Ürünler" }}></Header>
            <Container sx={{ mt: 5 }}>
                <Grid container spacing={3}>
                    {products?.map((prd) => (
                        <Grid key={prd.id} item xs={12} sm={6} md={4} lg={3} >
                            {/* <Link to={`/productdetail/${prd?.id}`}>{prd?.name}</Link> */}
                            <ProductCard product={prd} />
                        </Grid>
                    ))}
                </Grid>
            </Container>
        </div>
    )
}
