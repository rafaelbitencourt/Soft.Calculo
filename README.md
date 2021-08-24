# API Soft.CalculoJuros

#### API desenvolvida com .NET Core 3.1, com objetivo de realizar o cálculo de juros compostos

### Endpoints

- /calculajuros

Faz o cálculo de juros compostos e retorna o valor final, conforme fórmula abaixo: 
Valor Final = Valor Inicial * (1 + juros) ^ Tempo

<b>Valor inicial</b> é um decimal recebido como parâmetro;
--Valor do Juros é consultado na [API Soft.Taxas](https://github.com/rafaelbitencourt/Soft.Taxas);
--Tempo representa meses, também recebido como parâmetro;
--^ representa a operação de potência
--O resultado final é truncado em duas casas decimais.

- /showmethecode
Retorna a URL do repositório da API no GitHub.

### Pré-requisitos

Instalações necessárias para rodar a aplicação localmente:
  - [Git](https://git-scm.com)
  - [Docker Desktop](https://www.docker.com/products/docker-desktop)
  - Rodar a [API Soft.Taxas](https://github.com/rafaelbitencourt/Soft.Taxas) conforme instruções no repositório, para criar a imagem docker

### 🚀 Rodando a API

```bash
# Clone este repositório
$ git clone <https://github.com/rafaelbitencourt/Soft.CalculoJuros>

# Acesse a pasta do projeto no terminal/cmd
$ cd Soft.CalculoJuros

# Construa a aplicação usando Docker Compose
$ docker compose up

# A API iniciará na porta:8081 - acesse <http://localhost:8081>

```

### 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)
- [Visual Studio 2019 Community](https://visualstudio.microsoft.com/pt-br/vs/community/)
- [Swagger](https://www.nuget.org/packages/swashbuckle.aspnetcore.swagger/)
- [xUnit](https://xunit.net/)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Autor
---
<a href="https://github.com/rafaelbitencourt/">
 <img style="border-radius: 50%;margin: 0px;" src="https://avatars.githubusercontent.com/u/15696857?v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Rafael Bitencourt</b></sub></a>
 
 
Feito por Rafael Bitencourt 👋🏽 Entre em contato!

[![LinkedIn](https://img.shields.io/badge/linkedin-%230077B5.svg?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/rafael-bitencourt-642772123/)
[![Outlook](https://img.shields.io/badge/Microsoft_Outlook-0078D4?style=for-the-badge&logo=microsoft-outlook&logoColor=white)](mailto:rafael_silbit@hotmail.com)
