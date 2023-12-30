import { Button, Input } from '@mui/material';
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

        console.log(e.target.value);
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
        <div>
            <form onSubmit={handleSubmit} >
                <Input
                    value={values?.text}
                    onChange={handleChange}
                    name="text" />
                <Button variant='contained' type="submit">Gönder</Button>
            </form>
            {JSON.stringify(values)}
        </div>
    )
}

export default NewComment;
