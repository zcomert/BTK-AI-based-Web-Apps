import { Container, Typography } from '@mui/material'
import React from 'react'

export default function Header({ data }) {

    const style = {
        backgroundColor: "#e1e1e1"
    };

    return (
        <Container sx={style} maxWidth="xl">
            <Typography variant="h2" gutterBottom>
                {data?.title}
            </Typography>
        </Container>
    )
}
