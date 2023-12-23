import { Container, Typography } from '@mui/material'
import React from 'react'

export default function Header({ data }) {

    const style = {
        backgroundColor: "#e1e1e1",
        padding: "20px",
        textAlign: "center"
    };

    return (
        <Container sx={style} maxWidth="xxl">
            <Typography variant="h2" gutterBottom>
                {data?.title}
            </Typography>
        </Container>
    )
}
