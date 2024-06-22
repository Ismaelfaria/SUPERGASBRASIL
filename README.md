
<h1 align="center">
  <br>
  <a href="http://www.amitmerchant.com/electron-markdownify"><img src="https://escolaeducacao.com.br/wp-content/uploads/2019/04/super-gas.png" alt="Markdownify" width="200"></a>
  <br>
  SuperGasBrasil
  <br>
</h1>

<h4 align="center">Uma aplicação Web feita com Asp.Net Core. <a href="https://www.supergasbras.com.br" target="_blank">SuperGasBrasil</a>.</h4>

<p align="center">
  <a href="#Dependências">Dependências</a> •
  <a href="#Principais-Características">Principais Características</a> •
  <a href="#EndPoints">EndPoints</a> •
  <a href="#Modo-de-Utilização">Modo de Utilização</a> 
</p>

## Principais Características

CRUD:
* Clientes Juridicos - Para validar o CNPJ, uso da API "https://brasilapi.com.br/api/cnpj/v1/{cnpj}".
* Clientes Fisicos
* Funcionários
* Usuários que vão ter acesso ao sistema
  
AUTENTICAÇÃO:
* JWT Authentication - Acesso de ADM e Secretárias.

CONTROLE DE ESTOQUE(CRUD):
* Produto
* Inventário
* Transações 

## EndPoints
```bash
#Clientes
$ api/Cliente/Juridico
$ api/Cliente/Fisico

#Funcionarios
$ api/Funcionario

#Produto
$ api/Produto

#Estoque
$ api/Inventario - para gerenciar o estoque.

#Transação
$ api/Transacao - para controlar Venda|Reposição.

#Login
$ api/Login - para obter o Token de validação, caso cadastrado.

#Login
$ api/Login - para obter o Token de validação, caso cadastrado.

#Cadastro
$ api/Usuarios - para se cadastrar.
```
## Modo de Utilização

Coloque as configurações do seu Banco de Dados, e faça a conexão:

```bash
# Clone this repository
$ git clone https://github.com/Ismaelfaria/SUPERGASBRASIL
# Go into the repository

# Install dependencies
$ npm install

# Run the app
$ npm start
```

## Dependências

Este software usa os seguintes pacotes de código aberto:

- [EntityFrameworkCore](https://learn.microsoft.com/pt-br/ef/core/)
- [JWT Authentication](https://jwt.io/)
- [Mapeamento de dados - AutoMapper](https://docs.automapper.org/en/stable/)
- [Validação dos dados - FluentValidator](https://docs.fluentvalidation.net/en/latest/)

---
