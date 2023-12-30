import { Button, Input, Stack, TextField } from '@mui/material';
import { useFormik } from 'formik';
import React, { useState } from 'react'
import ProductService from '../../services/ProductService';
import SendIcon from '@mui/icons-material/Send';

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
        <form onSubmit={handleSubmit} >
            <Stack spacing={3}>
                <TextField
                    label="Yorum"
                    variant='outlined'
                    value={values?.text}
                    onChange={handleChange}
                    multiline
                    maxRows={3}
                    name="text" />
                <Button
                    startIcon={<SendIcon />}
                    variant='contained'
                    type="submit">Gönder</Button>
            </Stack>
        </form>
    )
}

export default NewComment;
