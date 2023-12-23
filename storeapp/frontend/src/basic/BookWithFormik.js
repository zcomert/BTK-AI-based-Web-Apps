import React from 'react'
import Header from '../components/header/Header'
import { useFormik } from 'formik';

function BookWithFormik() {

    const formik = useFormik({});

    return (
        <>
            <Header data={{ title: "Formik ile Form Kontrolü" }} />
            <form>
                <input name="title" />
                <input name="price" />
                <input name="author" />
                <input type="submit" />
            </form>
        </>
    )
}

export default BookWithFormik;
