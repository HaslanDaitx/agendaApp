## 📒 Agenda 2.0

Aplicação Desktop desenvolvida em C# com Windows Forms e banco de dados PostgreSQL para manter um cadastro simples de pessoas, com os campos Nome (texto) e Telefone (número).

Este projeto foi desenvolvido como parte de um teste de desenvolvimento, atendendo aos requisitos especificados.

---

## 🚀 Tecnologias Utilizadas

C# .NET 9.0 (Windows Forms)

PostgreSQL 17

Npgsql (driver para conexão C# ↔ PostgreSQL)

---

## 📋 Requisitos do Teste

A aplicação deverá manter um cadastro com um campo texto e um campo numérico.

O banco de dados deverá ter uma tabela com estes dois campos.

O banco deverá registrar em uma tabela de log todas as operações (Insert, Update, Delete).

A aplicação poderá acessar apenas a tabela de cadastro.

Todos os campos deverão ser obrigatórios.

O campo numérico deverá ser maior que zero e não poderá se repetir.

Todas as validações deverão ser implementadas no banco de dados.

---

## 🖥️ Funcionalidades da Aplicação

Salvar um novo cadastro (nome + telefone).

Editar o nome de um cadastro já existente (busca pelo telefone).

Excluir um cadastro pelo telefone.

Listar todos os cadastros em ordem alfabética.

Todas as operações são registradas automaticamente no log do banco de dados.

---

## ✅ Validações no Banco de Dados

Todas as regras de negócio foram implementadas diretamente no PostgreSQL, garantindo integridade e consistência:

NOT NULL → Nome e telefone obrigatórios.

CHECK (telefone > 0) → Telefone deve ser maior que zero.

CHECK (length(telefone::TEXT) BETWEEN 10 AND 11) → Telefone deve ter 10 ou 11 dígitos.

UNIQUE → Telefone não pode se repetir.

---

## 🏁 Como Rodar o Projeto

Configure o banco rodando o script criacao_banco.sql.

Ajuste a string de conexão no arquivo Form1.cs:
private string connString = "Host=localhost;Port=5432;Username=postgres;Password=SUA_SENHA;Database=agenda_2.0";

Compile o projeto no Visual Studio.

Execute o arquivo AppAgenda.exe na pasta Executavel.

Utilize a interface para inserir, editar, excluir e listar registros.

---

## 👨‍💻 Autor

Desenvolvido por Haslan Borges Daitx
