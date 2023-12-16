import React from 'react'
import { useState } from 'react';

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

    return (
        <div>
            {number}
            <button onClick={increase} >Artır</button>
            <button onClick={decrease} >Azaltmak</button>
        </div>
    )
}
export default Counter;
