import React, { useContext } from 'react'
import { Link } from 'react-router-dom'
import Header from '../../components/header/Header'
// import ProductService from '../../services/ProductService'
// import { products } from './ProductsData'
import AppContext from '../../context/AppContext'
import { Container, Grid } from '@mui/material';
import ProductCard from '../product/productCart/ProductCart';
export default function Products() {

    const { products } = useContext(AppContext);

    return (
        <div>
            <Header data={{ title: "Ürünler" }}></Header>
            <Container>
                <Grid container spacing={3}>
                    {products?.map((prd) => (
                        <Grid key={prd.id} item xs={4}>
                            {/* <Link to={`/productdetail/${prd?.id}`}>{prd?.name}</Link> */}
                            <ProductCard />
                        </Grid>
                    ))}
                </Grid>
            </Container>
        </div>
    )
}
