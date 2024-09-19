# MalaDiretaCSharp
O projeto MalaDiretaCSharp é um sistema de cadastro e validação de destinatários e seus endereços, desenvolvido em C#. Este sistema permite que os usuários gerenciem destinatários e seus endereços de forma eficiente, utilizando a integração com o serviço externo ViaCEP para consulta e verificação de CEPs.



## Etiquetas

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
![.NET 8](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet)


## Funcionalidades

- **Cadastro de Destinatários**: Permite o cadastro de novos destinatários com seus respectivos endereços.
- **Validação de Endereços**: Valida os endereços dos destinatários utilizando o serviço ViaCEP.
- **Consulta de CEP**: Integração com o serviço ViaCEP para consulta de CEPs.



## Arquitetura

O diagrama de contexto abaixo ilustra o contexto geral do sistema e sua relação com qualquer sistema externo:

![Diagrama de Contexto](https://github.com/samorysundjata/MalaDiretaCSharp/blob/master/docs/C4/out/Context/MalaDireta-Context.png)

O diagrama de container abaixo demonstra a interação entre os componentes do sistema:

![Diagrama de Container](https://github.com/samorysundjata/MalaDiretaCSharp/blob/master/docs/C4/out/Container/Maladireta-Container.png)

O diagrama de componente do EnderecoController:

![Diagrama de Componente](https://github.com/samorysundjata/MalaDiretaCSharp/blob/master/docs/C4/out/EnderecoController/EnderecoController-Component.png)

O diagrama de componente do DestinatarioController:

![Diagrama de Componente](https://github.com/samorysundjata/MalaDiretaCSharp/blob/master/docs/C4/out/DestinatarioController/DestinatarioController-Component.png)

Diagrama de Código da classe Endereco

![Diagrama de Codigo](https://github.com/samorysundjata/MalaDiretaCSharp/blob/master/docs/C4/out/Endereco/Endereco-Code.png)

Diagrama de Código da classe Destinatario

![Diagrama de Codigo](https://github.com/samorysundjata/MalaDiretaCSharp/blob/master/docs/C4/out/Destinatario/Destinatario-Code.png)

## Licença

Este projeto está licenciado sob a [MIT License](https://choosealicense.com/licenses/mit/)


## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/MalaDiretaCSharp.git
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd MalaDiretaCSharp
   ```
3. Restaure as dependências do projeto:
   ```bash
   dotnet restore
   ```
4. Execute a aplicação:
   ```bash
   dotnet run
   ```
    
