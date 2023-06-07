const protocol = 'https';
const server = 'qakognito.com.br';
const host = protocol + '://' + server;

export const environment = {
  production: false,
  ambiente: 'qa',
  ambienteAbrev: 'QA',
  urlApiAuth: `${host}/api`,
  urlApiGds: `http://localhost:5068/api`,
  secretKey: 'as8&6a*h$#oa(23)K8t$#',

};
