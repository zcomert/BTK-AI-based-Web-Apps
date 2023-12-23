import { Button, Input } from '@mui/material';
import { useFormik } from 'formik';
import React from 'react'

function NewComment() {

    const formik = useFormik({
        initialValues: {
            comment: ''
        },
        onSubmit: (values) => {
            console.log(values)
        }
    })

    return (
        <div>
            <form onSubmit={formik.handleSubmit} >
                <Input
                    value={formik.values.comment}
                    onChange={formik.handleChange}
                    name="comment" />
                <Button variant='contained' type="submit">Gönder</Button>
            </form>
        </div>
    )
}

export default NewComment;
