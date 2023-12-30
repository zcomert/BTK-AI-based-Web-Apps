import React, { useContext } from 'react'
import AppContext from '../context/AppContext'

export default function ContextSample() {
    const message = useContext(AppContext);
    return (
        <div>
            {message}
            <input name="text" ></input>
            <button type="submit">Gönder</button>
        </div>
    )
}
