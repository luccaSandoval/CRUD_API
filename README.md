# 📌API REST com ASP.NET Core

Este projeto é uma API REST-like simples, desenvolvida com **ASP.NET Core** e **C#**, com o objetivo de gerenciar tarefas e usuários.

## 🔧 Tecnologias/Ferramentas Utilizadas

- [.NET 7 / 8]
- C#
- Entity Framework Core
- SQL Server
- Injeção de Dependência
- Migrations (Code First)
- Swagger

---

## 🚀 Funcionalidades

- ✅ CRUD de Usuários
- ✅ CRUD de Tarefas
- ✅ Vincular Tarefas a Usuários
- ✅ Status de Tarefas com Enum
- ✅ Versionamento de banco com Migrations
- ✅ Organização em camadas (Controller, Models, Data, Repository)


Para executar o projeto no VS Code, é necessário clonar o repositório, ajustar a string de conexão no arquivo de configuração, aplicar as migrations com o comando `dotnet ef database update` e rodar a aplicação com `dotnet run`.

Este projeto foi desenvolvido com foco em aprendizado prático!

O projeto é bem basico , mas penso em expandi-lo com **autenticação via JWT** e **integração com frontend** futuramente.


