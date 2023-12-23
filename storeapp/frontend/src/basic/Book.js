import React from 'react'

function Book() {

    let values = {
        title: '',
        price: '',
        author: ''
    }

    const handleSubmit = (e) => {
        e.preventDefault();
        values = {
            title: e.target.title.value,
            price: e.target.price.value,
            author: e.target.author.value
        }
        console.log(values);
    }

    const handleChange = (e) => {


    }

    return (
        <div>
            <h1>Kitap Formu</h1>
            <form onSubmit={handleSubmit} >
                <input onChange={handleChange} type="text" name="title" placeholder='Kitap adı' />
                <input onChange={handleChange} type="text" name="price" placeholder='Fiyatı' />
                <input onChange={handleChange} type="text" name="author" placeholder='Yazarı' />
                <input type="submit" />
            </form>
            {JSON.stringify(values)}
        </div>
    )
}

export default Book;
