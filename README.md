# Task App
Task App é uma aplicação backend, construído a partir dos princícipios de arquitetura hexagonal, seguindo os principios de [Alistair Cockburn blog post.](http://alistair.cockburn.us/Hexagonal+architecture) e seus domínios criados a partir do DDD.

## Compilando a partid do código
Para executar a partir do código, clone o repositório para a sua máquina, compilar e testar:

```sh
git clone https://github.com/flavrance/task-app-backend.git
cd task-app-backend/src/TaskApp.WebApi
dotnet run
```
## A Arquitetura
![Arquitetura Hexagonal](https://raw.githubusercontent.com/flavrance/task-app-backend/main/docs/hexagonal_style-1.jpg)
Permitir que um aplicativo seja igualmente conduzido por usuários, programas, testes automatizados ou scripts em lote, e que seja desenvolvido e testado isoladamente de seus eventuais dispositivos de tempo de execução e bancos de dados.

À medida que os eventos chegam do mundo externo em uma porta, um adaptador específico de tecnologia os converte em uma chamada de procedimento utilizável e os passa para o aplicativo. O aplicativo é felizmente ignorante da natureza do dispositivo de entrada. Quando o aplicativo tem algo para enviar, ele envia através de uma porta para um adaptador, que cria os sinais apropriados necessários para a tecnologia receptora (humana ou automatizada). O aplicativo tem uma interação semanticamente sólida com os adaptadores em todos os lados, sem realmente conhecer a natureza das coisas do outro lado dos adaptadores.

| Concept | Description |
| --- | --- |
| DDD | Os Casos de Uso do Fluxo de Caixa são a Linguagem Ubíqua projetada nas camadas de Domínio e Aplicação, usamos os termos de Eric Evans como Entities, Value Object, Aggregates Root and Bounded Context. |
| SOLID | Os princípios SOLID estão em toda a solução. O conhecimento do SOLID não é um pré-requisito, mas é altamente recomendado. |
| Entity-Boundary-Interactor (EBI) | O objetivo da arquitetura EBI é produzir uma implementação de software independente de tecnologia, estrutura ou banco de dados. O resultado é o foco em casos de uso e entrada/saída. |
| Microservice | Projetamos o software em torno do Domínio de Negócios, tendo Entrega Contínua e Implantação Independente. |
| Logging |Logging é um detalhe. Conectamos o Serilog e o configuramos para redirecionar todas as mensagens de log para o sistema de arquivos. |
| Docker | Docker é um detalhe. Ele foi implementado para nos ajudar a fazer uma implantação mais rápida e confiável. |
| MongoDB | MongoDB é um detalhe. É possível criar uma nova implementação de acesso a dados e configurá-la com o Autofac. |
| .NET Core 6.0 | .NET Core é um detalhe. Quase tudo nesta base de código pode ser portado para outras versões. |
| CQRS | **[CQRS](https://martinfowler.com/bliki/CQRS.html)** é um acrônimo para *Segregação de responsabilidade de consulta de comando*. Esse padrão permite dividir nosso modelo de negócios conceitual em duas representações. A representação principal reside na Pilha de Comandos, para executar criações, atualizações e exclusões. O modelo de exibição reside dentro da pilha de consulta, onde podemos criar um modelo de consulta que facilite a agregação de informações para exibir aos clientes e à interface do usuário. |

![Arquitetura Hexagonal Adotada](https://raw.githubusercontent.com/flavrance/task-app-backend/main/docs/TaskApp.drawio.png)

## Requisitos
* [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/vs/community/)
* [.NET SDK 6.0 ou superior](https://www.microsoft.com/net/download/core)
* [Docker](https://docs.docker.com/docker-for-windows/install/)

## Setup Pré requisitos 

O único pré-requisito para executar a API da Web é uma string de conexão válida para o MongoDB e RabbitMq. Para ajudá-lo a executá-lo sem muito trabalho, siga as etapas na página [configuração de pré-requisitos](https://github.com/flavrance/task-app-backend/wiki/Setup-Pré-Requisitos).
Verifique qual a versão sdk instalada em sua máquina.
```sh
$ dotnet --lists-sdk
```
Atualize com a versão 6 e adicione no arquivo global.json na raiz do projeto.
## Executando os projetos
Docker compose (setup)
```sh
$ cd task-app-backend
$ cd setup
$ docker compose up -d
```
Worker e TaskApp API
1. Abra a solução TaskApp-Backend.sln
2. Configure o modo de depuração (debugging) para inicializar ambos os projetos: TaskApp.WorkerService.csproj e projeto TaskApp.WebApi.csproj

<!--
## Executando o Dockerfile

Você pode executar o container Docker  deste projeto com o seguinte comando:
Verificar os Ip's do rabbitmq e mongodb para substituir nos arquivos appsettings.json respectivos de cada aplicação.

```sh
$ cd task-app-backend
$ cd setup
$ docker compose up -d
$ cd ..
$ docker container inspect <docker-container-id-rabbit> | grep -i IPAddress
$ docker container inspect <docker-container-id-mongo> | grep -i IPAddress
$ docker build -t task-app-worker -f ./worker/Dockerfile .
$ docker run -d --name task-app-worker  task-app-worker:latest	
$ docker build -t task-app .
$ docker run -d -p 8000:80 --name task-app task-app:latest		
```
```sh
# Restore as distinct layers
$ dotnet restore TaskApp-Backend.sln
# Build a release
$ dotnet build TaskApp-Backend.sln -c Release -o ../out/build

# Publish a release
$ dotnet publish TaskApp-Backend.sln -c Release -o ../out/publish

$ dotnet ../out/publish/TaskApp.WorkerService.dll
```
-->
Então navegue para http://localhost:8000/swagger e visualize o documento Swagger gerado.
Para que cada container (docker) de aplicação (API e Worker) consiga acessar os container's (MongoDb e RabbitMq) precisam ter acesso externo aos respectivos IP's e portas.
para descobrir o IP e estarem dentro da mesma rede (network).
```sh
$ docker container inspect <docker-container-id> | grep -i IPAddress
```

## Verificando o HealthCheck

Navegue para http://localhost:8000/status-text ou http://localhost:8000/status-json
