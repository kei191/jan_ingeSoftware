import Head from 'next/head';
import React from 'react';
import axios from 'axios';
import { Box, Container } from '@mui/material';
import { RefrescoListResults } from '../components/refresco/refresco-list-results';
import { RefrescoListToolbar } from '../components/refresco/refresco-list-toolbar';
import { RefrescoListEnding } from '../components/refresco/refresco-list-ending';
import { DashboardLayout } from '../components/dashboard-layout';

class Refrescos extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      refrescos: []
    };
  }

  componentDidMount() {
    axios.get('https://localhost:7263/api/refrescos').then(response => {
      this.setState({ refrescos: response.data });
    });
  }

  render() {
    return (
      <>
        <Head>
          <title>
            Refrescos | Examen 2
          </title>
        </Head>
        <Box
          component="main"
          sx={{
            flexGrow: 1,
            py: 8
          }}
        >
          <Container maxWidth={false}>
            <RefrescoListToolbar />
            <Box sx={{ mt: 3 }}>
              <RefrescoListResults refrescos={this.state.refrescos} />
            </Box>
            <RefrescoListEnding />
          </Container>
        </Box>

      </>
    );
  }
}

Refrescos.getLayout = (page) => (
  <DashboardLayout>
    {page}
  </DashboardLayout>
);

export default Refrescos;
