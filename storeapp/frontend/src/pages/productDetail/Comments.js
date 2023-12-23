import React from 'react'

export default function Comments({ selectedProduct }) {

    if (selectedProduct?.comments.length === 0) {
        return (<div>
            Henüz hiç yorum yapılmadı.
        </div>)
    }
    return (
        <>
            <h2>Müşteri İncelemeleri</h2>
            <div>Yorumlar {selectedProduct?.comments.length}</div>
            <ul>
                {selectedProduct?.comments?.map((c) => (
                    <li key={c?.id}>
                        {c?.text}
                    </li>))}
            </ul>
        </>
    )
}
