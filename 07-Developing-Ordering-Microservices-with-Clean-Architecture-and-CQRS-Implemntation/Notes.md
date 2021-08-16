# Anotações do curso

## Developing Ordering Microservices with Clean Architecture and CQRS Implemntation

### Introdução

Implementar Ordering.API com Clean Architecture e CQRS:

![Big Picture](images/big-picture.png)

### Analysis and Architecting of Ordering Microservices

#### Ordering REST APIs

| Method | Request URI  | Use Case                 |
|--------|--------------|--------------------------|
| GET    | api/v1/Order | Get Orders with username |

- Get Orders with username
- Consume basketCheckout event from RabbitMQ
- CQRS implementation with triggering OrderCommand to insert Order record

![Ordering Architecture](images/ordering-architecture.png)

![Simplified CQRS and DDD microservice - High level desing](images/simplified-cqrs-and-ddd-microservice-high-level-design.png)

![Architecture of Ordering Microservices](images/architecture-of-ordering-microservices.png)

### Design Principles - SOLID

![Design Principles - SOLID](images/design-principles-solid.png)

### Design Principles - Dependency Inversion Principles (DIP)

![Dependency Inversion Principles (DIP)](images/dependency-inversion-principles-dip.png)

### Design Principles - Separation of Concerns (SoC)

![Separation of Concerns (SoC)](images/separation-of-concerns-soc.png)

### Domain Driven Design - DDD

![Domain Driven Design - DDD](images/domain-driven-design-ddd.png)

### Clean Architecture with Domain Driven Design (DDD)

[![Clean Architecture](images/clean-architecture.png)](https://medium.com/software-alchemy/a-brief-intro-to-clean-architecture-clean-ddd-and-cqrs-23243c3f31b3)

![Clean Architecture](images/clean-architecture-2.png)

### CQRS (Command Query Responsibility Segregation) Design Pattern

![CQRS (Command Query Responsibility Segregation) Design Pattern](images/cqrs-command-query-responsibility-segregation-design-pattern.png)

### Eventual Consistency and Event Sourcing with CQRS Design Pattern

![Eventual Consistent](images/eventual-consistent.png)

![Event Sourcing](images/event-sourcing.png)

![CQRS and Event Sourcing](images/cqrs-and-event-sourcing.png)

### Code Structure on CQRS and DDD Implementation in Ordering Microservices

![Simplified CQRS and DDD microservice - High level design](images/simplified-cqrs-and-ddd-microservice-high-level-design.png)

![Code Structure of Ordering Microservices](images/code-structure-of-ordering-microservices.png)

#### Ordering.Domain Nuget Packages

- Nenhum pacote nuget

#### Ordering.Application Nuget Packages

- [MediatR.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/MediatR.Extensions.Microsoft.DependencyInjection/)
- [FluentValidation](https://www.nuget.org/packages/fluentvalidation)
- [FluentValidation.DependencyInjectionExtensions](https://www.nuget.org/packages/fluentvalidation.dependencyinjectionextensions/)
- [AutoMapper](https://www.nuget.org/packages/AutoMapper/)
- [AutoMapper.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/)
- [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions/)
- ProjectReference - Ordering.Domain

#### Ordering.Infrastructure Nuget Packages

- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/)
- [SendGrid](https://www.nuget.org/packages/sendgrid/)
- ProjectReference - Ordering.Application

#### Ordering.API Nuget Packages

- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools)
- ProjectReference - Ordering.Application
- ProjectReference - Ordering.Infrastructure

#### Menções

Menções do instrutor, duas pessoas que possuem ótimos repositórios/materiais para referência.

![Menções](images/mencoes.png)

| [Jason Taylor](https://github.com/jasontaylordev)                                                                  | [Gill Cleeren](https://github.com/GillCleeren)                                                      |
|--------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------|
| [Repositório GitHub: CleanArchitecture](https://github.com/jasontaylordev/CleanArchitecture)                       | [Twitter](https://twitter.com/gillcleeren/)                                                         |
| [YouTube: Clean Architecture with ASP.NET Core 3.0 - Jason Taylor - NDC Sydney 2019](https://youtu.be/5OtUm1BLmG0) | [YouTube: Gill CLEEREN: Clean architecture with ASP.NET Core UCP2019](https://youtu.be/BxtHt7tsX-c) |
