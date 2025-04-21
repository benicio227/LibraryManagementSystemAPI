## Sobre o projeto

O projeto Sistema de Gerenciamento de Biblioteca é um projeto desenvolvido com **.NET 8**, que permite o gerenciamento de livros e da biblioteca para facilitar o cadastro de
um livro, o empréstimo, a criação e remoção. Construído seguindo os princípios da Clean Architecture para garantir uma organização modular e escalável do código. A estrutura
camadas  separa as responsabilidades de domínio, aplicação, infraestrutura e interface, promovendo  um código mais limpo, testável e fácil de manter.

A aplicação utiliza **Entity Framework Core** para o mapeamento e manipulação do banco de dados **SQL Server**, garantindo eficiência e flexibilidade no acesso aos dados.
Além disso, foram aplicadas as melhores práticas de **Clean Code**, visando legibilidade, reutilização e padronização do código.

### Features

- **Casastrar um Livro**: Permite ao usuário criar um livro e armazenar no banco de dados. As propriedades são validadas utilizando o FluentValidation.
- **Cadastrar Empréstimo**: Permite registrar uma data para a devolução do livro, garantindo um maior controle sobre empréstimo/devolução.
- **Devolução de um livro**: Essa funcionalidade permite manter o controle entre a data que foi feito o empréstimo do livro e a data em que ele foi devolvido. Para isso, uma mensagem é exibida, dizendo se a devolução está em atraso ou se está em dias.
- 
## Getting Started

Para obter uma cópia local funcionando, siga estes passos simples.

### Requisitos

- Visual Studio versão 2022+ ou Visual Studio Code
- Windows 10+ ou Linux/MacOS com [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) instalado
- SQL Server

### Construído com

![.NET Badge](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge)  ![badge-windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white) ![visual-studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white) ![badge-sqlserver](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)

![badge-swagger](http://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge)  

### Instalação

1. Clone o repositório:
    ```sh
    git clone git@github.com:benicio227/LibraryManagementSystemAPI.git
    ```

2. Preencha as informações no arquivo `appsettings.json`
3. Execute a API
