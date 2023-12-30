import { Button, Input } from '@mui/material';
import { useFormik } from 'formik';
import React from 'react'
import ProductService from '../../services/ProductService';

function NewComment({ setSelectedProduct, selectedProduct }) {

    const formik = useFormik({
        initialValues: {
            id: selectedProduct?.comments.length + 1,
            text: ''
        },
        onSubmit: (values) => {
            
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
            
            formik.resetForm();
        }
    })

    return (
        <div>
            <form onSubmit={formik.handleSubmit} >
                <Input
                    value={formik.values.comment}
                    onChange={formik.handleChange}
                    name="text" />
                <Button variant='contained' type="submit">Gönder</Button>
            </form>
        </div>
    )
}

export default NewComment;
