# Sistema de Roteamento de Pedidos - .NET Core

Este projeto implementa um sistema simples de roteamento de pedidos de cozinha utilizando ASP.NET Core. O sistema recebe pedidos através de uma API e roteia cada pedido para uma área específica da cozinha, armazenando os pedidos em memória.

## Estrutura do Projeto

- **Controllers/**: Contém os controladores que lidam com as requisições HTTP.
- **Models/**: Contém os modelos de dados utilizados no sistema (ex: `Pedido`).
- **Services/**: Contém os serviços que processam os pedidos e os roteiam para as áreas corretas.
- **Program.cs**: Configura e executa a aplicação.
- **README.md**: Instruções para rodar o projeto.

## Como Executar o Projeto

1. **Clone o Repositório**:
   git clone https://seu-repositorio.git
   cd PedidoRoteamento

2. **Restaurar Dependências**:
   No diretório do projeto, execute o seguinte comando para restaurar as dependências do .NET:
   dotnet restore

3. **Rodar a Aplicação**:
   Execute o projeto com o comando:
   dotnet run

4. **Acessar a API**:
   A API estará disponível no endereço: https://localhost:5001/api/pedido (ou a porta configurada no seu ambiente).

## Endpoints Disponíveis

- **POST** /api/pedido
  - Descrição: Envia um novo pedido para a cozinha.
  - Exemplo de corpo da requisição (JSON):
    {
      "id": 1,
      "descricao": "Batata Frita",
      "tipo": "fritos"
    }

- **GET** /api/pedido
  - Descrição: Retorna todos os pedidos armazenados em memória.

## Funcionalidades

- Recebe pedidos de diferentes tipos (fritos, grelhados, saladas, bebidas, sobremesas).
- Roteia os pedidos para as respectivas áreas da cozinha.
- Armazena os pedidos em memória enquanto a aplicação está rodando.
- Exibe os pedidos armazenados por meio de um endpoint GET.

## Tecnologias Utilizadas

- .NET Core 6.0
- ASP.NET Core Web API
- Injeção de Dependência
- Armazenamento em Memória

## Como Executar os Testes (Opcional)

Se você implementar testes, poderá rodar com o seguinte comando:
dotnet test

## Observações

- Como o sistema utiliza armazenamento em memória, os dados não persistem entre reinicializações da aplicação.
- O projeto foi configurado para rodar em ambientes Windows e Linux.

---

Se precisar de mais detalhes ou tiver dúvidas sobre a execução do projeto, sinta-se à vontade para entrar em contato.
