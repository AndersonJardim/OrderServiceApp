# OrderServiceApp - C# / CSharp / Projeto de Arquitetura de Software com C#

[![Status do Build](https://img.shields.io/badge/build-passing-brightgreen)](https://github.com/AndersonJardim/OrderServiceApp/actions)
[![Licença](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md)

## 📖 Sobre o Projeto

**OrderServiceApp** é uma API RESTful para gerenciamento de pedidos e serviços, desenvolvida como um exemplo prático de aplicação dos princípios de Domain-Driven Design (DDD) e Test-Driven Development (TDD). A aplicação permite aos usuários criar, visualizar, atualizar e excluir seus pedidos de forma organizada e eficiente.

Este projeto foi construído utilizando as tecnologias mais recentes do ecossistema .NET, com o objetivo de demonstrar uma arquitetura robusta, escalável e de fácil manutenção.

---

## ✨ Funcionalidades

- **CRUD de pedidos**:
  - Criar novas pedidos com título, descrição e data de vencimento.
  - Listar todos os pedidos cadastradas.
  - Buscar um pedido específica por seu ID.
  - Atualizar o status ou qualquer outra informação de um pedido.
  - Excluir um pedido.
- **Validações de Negócio**: Regras de negócio implementadas no domínio para garantir a consistência dos dados.
- **API Documentada**: Endpoints da API documentados utilizando Swagger/OpenAPI.

---

## 🛠️ Tecnologias e Arquitetura

Este projeto foi desenvolvido utilizando as seguintes tecnologias e conceitos:

- **[.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0)**: Framework principal da aplicação.
- **[ASP.NET Core 8](https://docs.microsoft.com/aspnet/core)**: Para a construção da API RESTful.
- **[Entity Framework Core 8](https://docs.microsoft.com/ef/core)**: ORM para a persistência de dados com o banco de dados.
- **Arquitetura Limpa (Clean Architecture) com [Domain-Driven Design (DDD)](https://martinfowler.com/tags/domain%20driven%20design.html)**: A estrutura do projeto é dividida em camadas (Domínio, Aplicação, Infraestrutura e Apresentação) para garantir baixo acoplamento e alta coesão.
- **[Test-Driven Development (TDD)](https://en.wikipedia.org/wiki/Test-driven_development)**: O desenvolvimento foi guiado por testes, garantindo a qualidade e a confiabilidade do código.
- **[xUnit](https://xunit.net/)**: Framework de testes unitários para validar as regras de negócio e o comportamento da aplicação.
- **[Swagger/OpenAPI](https://swagger.io/)**: Para documentação e teste interativo dos endpoints da API.
- **Banco de Dados**: Configurável, por padrão utilizando SQL Server (pode ser alterado no `appsettings.json`).

---

## 🚀 Começando

Siga as instruções abaixo para configurar e executar o projeto em seu ambiente de desenvolvimento local.

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Um editor de código de sua preferência (Visual Studio, VS Code, etc.)
- SQL Server ou outro banco de dados compatível com o Entity Framework Core.

### Instalação e Execução

1.  **Clone o repositório:**

    ```bash
    git clone [https://github.com/AndersonJardim/OrderServiceApp.git](https://github.com/AndersonJardim/OrderServiceApp.git)
    cd OrderServiceApp
    ```

2.  **Configure a String de Conexão:**

    - Abra o arquivo `src/OrderServiceApp.Api/appsettings.Development.json`.
    - Altere a `DefaultConnection` para apontar para o seu banco de dados.

3.  **Aplique as Migrations:**

    - Navegue até o projeto de infraestrutura e execute o comando para criar o banco de dados e as tabelas.

    ```bash
    cd src/OrderServiceApp.Infrastructure
    dotnet ef database update
    ```

4.  **Execute a Aplicação:**

    - Navegue até o projeto da API e inicie o servidor.

    ```bash
    cd ../OrderServiceApp.Api
    dotnet watch run
    ```

5.  **Acesse a API:**
    - A aplicação estará disponível em `https://localhost:5001`.
    - A documentação do Swagger pode ser acessada em `https://localhost:5001/swagger`.

---

## ✅ Executando os Testes

O projeto segue a metodologia TDD, e a cobertura de testes é uma prioridade. Para executar todos os testes unitários e de integração, utilize o seguinte comando na raiz do projeto:

```bash
dotnet test
```
