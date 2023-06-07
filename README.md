# TesteKognit
Projeto criado em dotnet core (backend) e angular 16 no frontend

## Gerar migrations e atualizar banco de dados
 - Executar o comando abaixo dentro do kognito.repository
    
    dotnet ef --startup-project ../kognito.api migrations add Init
    dotnet ef --startup-project ../kognito.api databse update