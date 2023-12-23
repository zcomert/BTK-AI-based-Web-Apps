import React from 'react'
import Header from '../components/header/Header'
import { useFormik } from 'formik';
import BookValidationSchema from './BookValidation'


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
        },
        validationSchema: BookValidationSchema
    });

    return (
        <>
            <Header data={{ title: "Formik ile Form Kontrolü" }} />
            <form onSubmit={formik.handleSubmit} >
                <div>
                    <input
                        onChange={formik.handleChange}
                        onBlur={formik.handleBlur}
                        name="title"
                        value={formik.values.title}
                    />
                    {
                        (formik.errors.title && formik.touched.title) &&
                        <div>{formik.errors.title}</div>}
                </div>

                <div>

                    <input
                        onChange={formik.handleChange}
                        onBlur={formik.handleBlur}
                        value={formik.values.price}
                        name="price" />

                    {formik.errors.price && formik.touched.price
                        ? <div>{formik.errors.price}</div>
                        : null
                    }
                </div>

                <div>
                    <input
                        onChange={formik.handleChange}
                        onBlur={formik.handleBlur}
                        value={formik.values.author}
                        name="author" />

                    {(formik.errors.author && formik.touched.author) &&
                        <div>{formik.errors.author}</div>
                    }
                </div>

                <input type="submit" />
            </form>
            {JSON.stringify(formik.values)}
        </>
    )
}

export default BookWithFormik;
