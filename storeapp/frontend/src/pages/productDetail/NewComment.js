import { Button, Input, Stack } from '@mui/material';
import { useFormik } from 'formik';
import React, { useState } from 'react'
import ProductService from '../../services/ProductService';

function NewComment({ setSelectedProduct, selectedProduct }) {

    const initialValues = {
        id: selectedProduct?.comments.length + 1,
        text: ''
    };

    const [values, setValues] = useState(initialValues);

    const handleChange = (e) => {
        setValues({
            ...values,
            [e.target.name]: e.target.value
        });

        console.log(Math.random());
    }

    const handleSubmit = (e) => {
        e.preventDefault();
        const productService = new ProductService();
        const product = {
            ...selectedProduct,
            comments: [
                ...selectedProduct.comments,
                values
            ]
        };

        productService
            .updateOneProduct(product.id, product)
            .then(resp => setSelectedProduct(resp));

        setValues(initialValues);
    }



    return (
        <Stack spacing={3}>
            <form onSubmit={handleSubmit} >
                <Input
                    sx={{ display: 'block' }}
                    value={values?.text}
                    onChange={handleChange}
                    name="text" />
                <Button sx={{ mt: 3 }} variant='contained' type="submit">Gönder</Button>
            </form>
        </Stack>
    )
}

export default NewComment;
