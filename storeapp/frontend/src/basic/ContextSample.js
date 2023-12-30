import React, { useContext } from 'react'
import AppContext from '../context/AppContext'
import { Button, Container, Stack, TextField } from '@mui/material';

export default function ContextSample() {
    const { message, setMessage } = useContext(AppContext);

    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(e.target.text.value);
        setMessage(e.target.text.value);
    }

    return (
        <Container>
            <Stack spacing={3}>
                <div>
                    {message}
                </div>
                <form onSubmit={handleSubmit}>
                    <TextField name="text" ></TextField>
                    <Button type="submit">Gönder</Button>
                </form>
            </Stack>
        </Container>
    )
}
