import React from 'react'
import Header from '../components/header/Header';

function Contact() {
    return (
        <div>
            <Header data={{ title: "İletişim" }}></Header>
            <h1>Contact</h1>
            <ul>
                <li>Telefon: 506 111 22 33</li>
                <li>Adres BTK Akademi Samsun</li>
            </ul>
        </div>
    )
}

export default Contact;
