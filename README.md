# 📌 MeuCRUDAPI – API REST com ASP.NET Core

Este projeto é uma API RESTlike simples, desenvolvida com **ASP.NET Core** e **C#**, com o objetivo de gerenciar tarefas e usuários.

A aplicação foi construída utilizando tecnologias como **Entity Framework Core** para acesso e manipulação de dados, **SQL Server** como banco de dados relacional.

Toda a estrutura do projeto foi separada por camadas para garantir clareza e manutenibilidade do código. Os **Controllers** são responsáveis por tratar as requisições HTTP. 
A camada **Models** representa as entidades do sistema. 
A pasta **Data** contém o `DbContext`, os arquivos de **Migrations** e os mapeamentos. 
Os **Repositórios** encapsulam a lógica de negócio e a comunicação com o banco de dados.

O projeto também faz uso do padrão **Repository** e de **injeção de dependência** através do método `AddScoped`, permitindo que as classes responsáveis pela lógica de negócio sejam instanciadas automaticamente quando requisitadas.
-
-
-
-
-
Para executar o projeto, é necessário clonar o repositório, ajustar a string de conexão no arquivo de configuração, aplicar as migrations com o comando `dotnet ef database update` e rodar a aplicação com `dotnet run`.

Este projeto foi desenvolvido com foco em aprendizado prático!

O projeto é bem basico , mas penso em expandi-lo com **autenticação via JWT** e **integração com frontend** futuramente.


