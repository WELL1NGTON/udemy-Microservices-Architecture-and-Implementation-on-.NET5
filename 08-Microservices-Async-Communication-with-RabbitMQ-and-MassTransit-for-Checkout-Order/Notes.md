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
