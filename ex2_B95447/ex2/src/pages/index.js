import Head from 'next/head';
import React from 'react';
import axios from 'axios';
import { Box, Container } from '@mui/material';
import { BenefitListResults } from '../components/benefit/benefit-list-results';
import { BenefitListToolbar } from '../components/benefit/benefit-list-toolbar';
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
            <BenefitListToolbar />
            <Box sx={{ mt: 3 }}>
              <BenefitListResults refrescos={this.state.refrescos} />
            </Box>
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
