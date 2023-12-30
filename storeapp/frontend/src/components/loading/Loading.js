import * as React from 'react';
import CircularProgress from '@mui/material/CircularProgress';
import Box from '@mui/material/Box';

function Loading() {
    return (
        <Box
            sx={{
                display: 'flex',
                justifyContent: 'center',
                alignItems: 'center',
                height: '100vh', // Sayfanın yüksekliği kadar kutuyu kapla
            }}
        >
            <CircularProgress />
        </Box>
    );
}

export default Loading;
