## Prova de LP3 do Segundo Bimestre

Aplicação console da prova de LP3 do Segundo Bimestre

## Funcionalidades 

- Cadastra/insere um novo produto
- Remove um produto por id
- Habilita um produto por id
- Desabilita um produto por id
- Retorna todos os produtos
- Retorna os produtos dentro de um intervalo de preço
- Retorna os produtos com preço maior que o valor informado
- Retorna os produtos com preço menor que o valor informado
- Retorna a média dos preço de todos os produtos

## Tecnologias

- C#
- .NET (Versão 6.0)
- Dapper (Versão 2.0.123)
- Sqlite (Versão 6.0.6)

## Uso

Utilize o comando a seguir para baixar o repositório no seu computador:

git clone `https://github.com/giovanna-alves-de-farias/ProvaLP3SegundoBimestre.git`

## Execução 

Use os comandos a seguir para manipular a aplicação console:

- Para cadastrar um novo produto:

`dotnet run -- Product New`

- Para remover um produto por id:

`dotnet run -- Product Delete`

- Para habilitar um produto por id:

`dotnet run -- Product Enable`

- Para desabilitar um produto por id: -->

`dotnet run -- Product Disable`

- Para retornar todos os produtos:

`dotnet run -- Product List`

- Para retornar os produtos dentro de um intervalo de preço:

`dotnet run -- Product PriceBetween`

- Para retornar os produtos com preço maior que o valor informado;

`dotnet run -- Product PriceHigherThan`

- Para retornar os produtos com preço menor que o valor informado:

`dotnet run -- Product PriceLowerThan`

- Para retornar a média dos preço de todos os produtos:

`dotnet run -- Product AveragePrice`