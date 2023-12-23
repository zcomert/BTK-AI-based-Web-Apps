import React, { useState } from 'react'
import Header from '../components/header/Header';
import { Button, Container, Input, Stack } from '@mui/material';
import { useFormik } from 'formik';

function ArrayManipulation() {

    const [data, setData] = useState([]);

    const formik = useFormik({
        initialValues: {
            firstName: '',
            lastName: ''
        },
        onSubmit: (values) => {
            setData([...data, values]);
        }
    });

    return (
        <div>
            <Header data={{ title: "Dizi Manipülasyonu" }}></Header>
            <Container maxWidth="sm">

                <Stack>
                    {data.map((emp) => (
                        <div key={emp.firstName}>
                            <Stack direction="column">
                                <p>{emp.firstName}</p>
                                <p>{emp.firstName}</p>
                                <Button variant='contained' >Sil</Button>
                            </Stack>

                        </div>
                    ))}
                </Stack>


                <form onSubmit={formik.handleSubmit}>
                    <Stack spacing={3}>
                        <Input
                            value={formik.values.firstName}
                            onChange={formik.handleChange}
                            size="md"
                            placeholder="Medium" name="firstName" />

                        <Input
                            value={formik.values.lastName}
                            onChange={formik.handleChange}
                            size="md"
                            placeholder="Medium" name="lastName" />
                        <Button type="submit" variant="outlined">Ekle</Button>
                    </Stack>
                </form>
            </Container>

            {JSON.stringify(data)}
        </div>
    )
}

export default ArrayManipulation;