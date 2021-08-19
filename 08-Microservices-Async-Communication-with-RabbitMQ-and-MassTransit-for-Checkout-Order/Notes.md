# Anotações do curso

## Microservices Async Communication w/ RabbitMQ & MassTransit for Checkout Order

### Introdução

Implementar comunição assíncrona com RabbitMQ e MassTransit para "Checkout Order" entre os microserviços Basket e Ordering.

![Big Picture](images/big-picture.png)

![Pub/Sub RabbitMQ Architecture](images/pub-sub-rabbitmq-architecture.png)

![Publisher/Subscriber of BasketCheckout Event w/ Basket and Ordering Microservices](images/publisher-subscriber-of-basketcheckout-event-w-basket-and-ordering-microservices.png)

### Microservices Communication Types Request-Driven or Event-Driven Architecture

![Microservice Communication Types](images/microservices-communication-types.png)

### What is RabbitMQ, Main Components of RabbitMQ

![What is RabbitMQ](images/what-is-rabbitmq.png)

![Main Components of RabbitMQ](images/main-components-of-rabbitmq.png)

![RabbitMQ Queue Properties](images/rabbitmq-queue-properties.png)

### RabbitMQ Exchange Types

![RabbitMQ Exchange Types](images/rabbitmq-exchange-types.png)

![RabbitMQ Topic & Fanout Exchange Types](images/rabbitmq-topic-and-fanout-exchange-types.png)

### Adding RabbitMQ image into Docker-Compose File for Multi-Container Docker Env

Adiciona a imagem oficial do [RabbitMQ](https://hub.docker.com/_/rabbitmq) no docker-compose.

### Analysis & Design BuildingBlocks EventBus.Messages Class Library Project

![Analysis & Design RabbitMQ & BuildingBlocks EventBus.Messages](images/analysis-and-design-rabbitmq-and-buildinblocks-eventbus-messages.png)

![Publisher/Subscriber of BasketCheckout Event](images/publisher-subscriber-of-basketcheckout-event.png)

#### RabbitMQ Nuget Packages

- [MassTransit](https://www.nuget.org/packages/MassTransit/)
- [MassTransit.RabbitMQ](https://www.nuget.org/packages/MassTransit.RabbitMQ/)
- [MassTransit.AspNetCore](https://www.nuget.org/packages/MassTransit.AspNetCore/)
- REST API principles, CRUD operations
- Add Project Reference - EventBus.Messages

### Developing BuildingBlocks EventBus.Messages Class Library

Adicionado novo projeto "EventBus.Messages" em "src/BuildingBlocks" com os comandos:

```bash
# Criando um projeto classlib em src/BuildingBlocks/EventBus.Messages
dotnet new classlib -o EventBus.Messages

# Voltando para a pasta que contém a solution "aspnetrun-microservices.sln" (pasta 'src')
cd ..

# Adicionado o projeto csproj no arquivo de solution
dotnet sln add ./BuildingBlocks/EventBus.Messages/EventBus.Messages.csproj
```

### Produce RabbitMQ Event From Basket Microservice Publisher of BasketCheckoutEvent

Adicionada referência do projeto EventBus.Messages no projeto Basket.API executando o seguinte comando dentro de src/Services/Basket/Basket.API¨

```bash
dotnet add reference ../../../BuildingBlocks/EventBus.Messages/EventBus.Messages.csproj
```

E depois adicionados os pacotes necessários para o EventBus em Basket.API:

```bash
dotnet add package MassTransit
dotnet add package MassTransit.RabbitMQ
dotnet add package MassTransit.AspNetCore
```
