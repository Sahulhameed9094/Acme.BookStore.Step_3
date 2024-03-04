import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44388/',
  redirectUri: baseUrl,
  clientId: 'Step_3_App',
  responseType: 'code',
  scope: 'offline_access Step_3',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Step_3',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44388',
      rootNamespace: 'Acme.BookStore.Step_3',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
