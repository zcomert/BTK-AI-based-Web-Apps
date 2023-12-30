import React, { useContext } from 'react'
import { useState } from 'react';
import Header from '../components/header/Header';
import AppContext from '../context/AppContext';
import { Link } from 'react-router-dom';

function Counter() {
    
    const [number, setNumber] = useState(0);
    
    function increase() {
        setNumber(number + 1)
        console.log(number);
    }
    
    function decrease() {
        setNumber(number - 1);
        console.log(number);
    }
    
    const { message } = useContext(AppContext);
    return (
        <div>
            <Header data={{ title: "Sayaç" }}></Header>
            <h1>{message}</h1>
            {number}
            <button onClick={increase} >Artır</button>
            <button onClick={decrease} >Azaltmak</button>
            <div>
                <Link to="/context">Context</Link>
            </div>
        </div>
    )
}
export default Counter;
