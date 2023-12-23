import React from 'react'
import Header from '../components/header/Header'
import { useFormik } from 'formik';

function BookWithFormik() {

    const formik = useFormik({
        initialValues: {
            title: '',
            price: '',
            author: ''
        },
        onSubmit: (values) => {
            console.log(values)
            formik.resetForm();
        }
    });

    return (
        <>
            <Header data={{ title: "Formik ile Form Kontrolü" }} />
            <form onSubmit={formik.handleSubmit} >
                <input
                    onChange={formik.handleChange}
                    name="title"
                    value={formik.values.title}
                />

                <input
                    onChange={formik.handleChange}
                    value={formik.values.price}
                    name="price" />

                <input
                    onChange={formik.handleChange}
                    value={formik.values.author}
                    name="author" />

                <input type="submit" />
            </form>
            {JSON.stringify(formik.values)}
        </>
    )
}

export default BookWithFormik;
