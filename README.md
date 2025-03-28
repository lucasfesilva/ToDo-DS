# Projeto Backend

Este projeto é uma API desenvolvida em ASP.NET Core que se conecta a um banco de dados SQL Server. Abaixo estão os passos para configurar o projeto localmente, rodar a aplicação e informações sobre o banco de dados utilizado.

## Passos para configurar o projeto localmente

1. **Abrir o Projeto no Visual Studio 2022**

   - Abra o Visual Studio 2022 e carregue o projeto da pasta onde está localizado o código-fonte.

2. **Configuração da Conexão com o Banco de Dados**

   - Na pasta raiz do projeto, localize o arquivo chamado `appsettings.json`.
   - Dentro desse arquivo, você encontrará a chave `ConnectionStrings` e o campo `DefaultConnection`.
   - Substitua o valor de `DefaultConnection` pela URL de conexão com o seu banco de dados SQL Server.

3. **Criar as Tabelas no Banco de Dados**

   - Após configurar a URL de conexão, abra o terminal no Visual Studio 2022.
   - Execute o comando abaixo para aplicar as migrações e criar as tabelas no banco de dados:

     dotnet ef database update

4. **Rodar a API (Backend)**

   - Para rodar o Backend, navegue até a pasta raiz do projeto Backend no terminal e execute o seguinte comando:


     dotnet watch run


   - O comando `dotnet watch run` iniciará a API Backend e você poderá acessá-la localmente.

5. **Rodar o Frontend**

   - Para rodar o Frontend, navuegue até a pasta raiz do projeto do Frontend no terminal e execute o seguinte comando:
  
     dotnet watch run
