import {
  Box,
  Button,
  Typography
} from '@mui/material';

export const RefrescoListEnding = (props) => (
  <Box {...props}>
    <Box
      sx={{
        alignItems: 'center',
        display: 'flex',
        justifyContent: 'space-between',
        flexWrap: 'wrap',
        m: -1
      }}
    >
      <Typography
        sx={{ m: 1 }}
        variant="h4"
      >
        Total:
      </Typography>
    </Box>
    <Box
      sx={{
        alignItems: 'center',
        display: 'flex',
        justifyContent: 'space-between',
        flexWrap: 'wrap',
        m: -1
      }}
    >
      <Typography
        sx={{ m: 1 }}
        variant="h4"
      >
        Desea pagar con:
      </Typography>
    </Box>
    <Button
      color="primary"
      variant="contained"
    >
      Pagar
    </Button>
    <br></br>
  </Box>
);
