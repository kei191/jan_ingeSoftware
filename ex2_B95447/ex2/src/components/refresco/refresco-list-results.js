import * as React from 'react';
import Button from '@mui/material/Button';
import PerfectScrollbar from 'react-perfect-scrollbar';
import PropTypes from 'prop-types';
import {
  Box,
  Card,
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableRow,
  Typography
} from '@mui/material';

export const RefrescoListResults = ({ refrescos, ...rest }) => {
  return (
    <Card {...rest}>
      <PerfectScrollbar>
        <Box sx={{ minWidth: 1050 }}>
          <Table>
            <TableHead>
              <TableRow>
                <TableCell>
                  Nombre de la bebida
                </TableCell>
                <TableCell>
                  Cantidad de latas en el sistema
                </TableCell>
                <TableCell>
                  Costo
                </TableCell>
                <TableCell>
                  Acciones
                </TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {refrescos.map(juguito => (
                <TableRow
                  hover
                  key={juguito.nombre}
                >
                  <TableCell>
                    <Box
                      sx={{
                        alignItems: 'center',
                        display: 'flex'
                      }}
                    >
                      <Typography
                        color="textPrimary"
                        variant="body1"
                      >
                        {juguito.nombre}
                      </Typography>
                    </Box>
                  </TableCell>
                  <TableCell>
                    {juguito.cantidad}
                  </TableCell>
                  <TableCell>
                    {"CRC " + juguito.precio}
                  </TableCell>
                  <TableCell>
                    <Button
                      color="success"
                      variant="contained"
                    >
                      Agregar
                    </Button>
                    <Button
                      color="error"
                      variant="contained"
                    >
                      Eliminar
                    </Button>
                  </TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </Box>
      </PerfectScrollbar>
    </Card>
  );
};

RefrescoListResults.propTypes = {
  refrescos: PropTypes.array.isRequired
};
