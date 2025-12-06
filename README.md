# SGHSS - Sistema de Gestão Hospitalar VidaPlus

Projeto Multidisciplinar desenvolvido como requisito para aprovação em Análise e Desenvolvimento de Sistemas.
Este repositório contém o Back-end (API) do sistema de gestão hospitalar.

## 🚀 Tecnologias Utilizadas

- **Linguagem:** C# (.NET 8.0)
- **Framework:** ASP.NET Core Web API
- **Banco de Dados:** Entity Framework Core (In-Memory Database)
- **Segurança:** Autenticação via JWT (JSON Web Token)
- **Documentação:** Swagger (OpenAPI)

## ⚙️ Como Rodar o Projeto

### Pré-requisitos
- Visual Studio 2022 ou .NET 8 SDK instalado.

### Passo a Passo
1. Clone este repositório ou baixe o ZIP.
2. Abra o arquivo `.sln` no Visual Studio.
3. Aguarde a restauração dos pacotes NuGet.
4. Execute o projeto (F5).
5. O navegador abrirá automaticamente na interface do **Swagger** (`/swagger`).

## Credenciais de Acesso (Para Testes)

O sistema possui autenticação JWT. Utilize as credenciais abaixo na rota `/api/auth/login` para gerar o Token de acesso:

- **Usuário:** `admin`
- **Senha:** `1234`

Após gerar o token, clique no botão **Authorize** (cadeado) no Swagger e insira: `Bearer SEU_TOKEN_AQUI`.

## Endpoints Principais

- `POST /api/auth/login`: Autenticação.
- `GET /api/consultas`: Listar consultas (Requer Token).
- `POST /api/consultas`: Agendar nova consulta (Requer Token).
- `PUT api/consultas/{id}`: Alterar consulta existente (Requer Token).
- `DELETE api/consultas/{id}`: Deletar consulta existente (Requer Token).

---
**Aluno:** [MATHEUS CONDE]
**RU:** [4325759]
