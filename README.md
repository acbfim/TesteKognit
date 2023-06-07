# TesteKognit
Projeto criado em dotnet core (backend) e angular 16 no frontend

Os projetos estão juntos na mesma pasta.

## Frontend

 - Login: admin
 - Senha: admin


 ## Backend
 
 - Utilizei o sqllite como banco local, pois como uso MacOS, seria mais complicado rodar uma instancia do SqlServer aqui no meu ambiente. 

## Gerar migrations e atualizar banco de dados
 - Executar o comando abaixo dentro do kognito.repository
    
    dotnet ef --startup-project ../kognito.api migrations add Init
    dotnet ef --startup-project ../kognito.api databse update