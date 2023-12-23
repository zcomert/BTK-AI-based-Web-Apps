import React, { useState } from 'react'

function Book() {

    const initialValue = {
        title: '',
        price: '',
        author: ''
    };

    const [values, setValues] = useState(initialValue);


    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(values);
        setValues(initialValue);
        // e.target.reset()
    }

    const handleChange = (e) => {
        setValues({
            ...values,
            [e.target.name]: e.target.value
        })
    }

    return (
        <div>
            <h1>Kitap Formu</h1>
            <form onSubmit={handleSubmit} >
                <input onChange={handleChange}
                    type="text" name="title"
                    placeholder='Kitap adı'
                    value={values?.title} />


                <input onChange={handleChange}
                    value={values?.price}
                    type="text"
                    name="price"
                    placeholder='Fiyatı' />
                <input
                    value={values?.author}
                    onChange={handleChange}
                    type="text"
                    name="author"
                    placeholder='Yazarı' />
                <input type="submit" />
            </form>
            {JSON.stringify(values)}
        </div>
    )
}

export default Book;
