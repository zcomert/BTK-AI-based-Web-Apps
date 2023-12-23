import React from 'react'

function Book() {

    
    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(e.target);
    }
    
    const handleChange = (e) => {
        console.log(e.target.value)
    }
    
    return (
        <div>
            <h1>Kitap Formu</h1>
            <form onSubmit={handleSubmit} >
                <input onChange={handleChange} type="text" name="title" placeholder='Kitap adı'  />
                <input type="text" name="price" placeholder='Fiyatı' />
                <input type="text" name="author" placeholder='Yazarı' />
                <input type="submit" />
            </form>
        </div>
    )
}

export default Book;
