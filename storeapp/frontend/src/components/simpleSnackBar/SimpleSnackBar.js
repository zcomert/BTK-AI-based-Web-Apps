import { Alert, Snackbar } from '@mui/material';
import React, { useContext } from 'react'
import AppContext from '../../context/AppContext';

function SimpleSnackBar() {
    const { snackbar, setSnackbar } = useContext(AppContext);

    const handleClick = () => {
        setSnackbar({
            ...snackbar,
            open:true
       })
    };

    const handleClose = (event, reason) => {
        if (reason === 'clickaway') {
            return;
        }

        setSnackbar({
            ...snackbar,
            open:false
        });
    };
    return (
        <Snackbar open={snackbar?.open}
            autoHideDuration={3000}
            onClose={handleClose}>
            <Alert onClose={handleClose}
                severity={snackbar.severity}
                sx={{ width: '100%' }}>
                {snackbar?.message}
            </Alert>
        </Snackbar>
    )
}

export default SimpleSnackBar;
