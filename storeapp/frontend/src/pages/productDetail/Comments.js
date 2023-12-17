import React from 'react'

export default function Comments({ comments }) {

    if (comments.length === 0) {
        return (<div>
            Henüz hiç yorum yapılmadı.
        </div>)
    }
    return (
        <>
            <h2>Müşteri İncelemeleri</h2>
            <div>Yorumlar {comments.length}</div>
            <ul>
                {comments?.map((c) => (
                    <li key={c?.id}>
                        {c?.text}
                    </li>))}
            </ul>
        </>
    )
}
