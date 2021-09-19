# Microservices Architecture and Implementation on .NET 5

[![Udemy](https://www.udemy.com/staticx/udemy/images/v7/logo-udemy.png)](https://www.udemy.com/)

Curso Udemy: [Microservices Architecture and Implementation on .NET 5](https://www.udemy.com/course/microservices-architecture-and-implementation-on-dotnet/)

Segui esse curso utilizando o [Visual Studio Code](https://code.visualstudio.com/) e utilizei a função de workspaces dele para separar os códigos por seção. Eu preferi fazer assim pois consigo ter uma melhor noção do progresso e caso exista alguma refatoração em uma seção posterior do curso, eu consigo ter uma visão melhor de como era um código até uma parte do curso e como ficou depois sem ter que ficar pulando entre commits.  
As configurações dos workspaces estão no arquivo [workspace.code-workspace](./workspace.code-workspace).

Obs.: Como estou seguindo curso onde o projeto base é [aspnetrun/run-aspnetcore-microservices](https://github.com/aspnetrun/run-aspnetcore-microservices), eu selecionei a mesma [licensa](https://github.com/aspnetrun/run-aspnetcore-microservices/blob/master/LICENSE) para esse repositório.

## Instrutor

### Mehmet Özkaya - Software Architect

[Dados da página do curso](https://www.udemy.com/course/microservices-architecture-and-implementation-on-dotnet/#instructor-1):

> Creator of github aspnetrun repositories
>
> - 15+ years hands on experience in Microsoft .NET Development. Experience in Web Application Development using C#, .NET Core, ASP.NET/MVC/ASP.NET Core, JavaScript, Angular, TypeScript
> - Strong experience Design and implement RESTful APIs JSON design, SOAP Web Services using WCF and ASP.NET Core Web API
> - Excellent knowledge on Object-Oriented Design and Development, SOLID principles, DDD, Design Patterns, SOA, TDD and Unit Testing.
> - Strong experience using Web Front End Technologies such as DOM, HTML5, CSS3 and JavaScript, JSON, JQuery, TypeScript
> - Experience using ORM tools such as Entity Framework Core, NHibernate, Dapper.
> - Strong experience of Distributed Software Architecture and Messaging Technologies in Microservices Architecture, API Gateways (Orleans), BDD, DDD/CQRS patterns, Distributed Message Broker Service Bus Applications(MQTT, AMQT, MassTransit, RabbitMQ, Azure Service Bus), Event Sourcing, Cloud Computing Architectures, IAAS platforms (AWS, Azure), Application Containerization, Docker.
> - Using Distributed Caching and Related Open Source Tools such as Redis, Camunda, Castle Windsor, AutoMapper, Log4Net.
>
> GitHub : mehmetozkaya  
> GitHub : aspnetrun

Links:

- [GitHub](https://github.com/mehmetozkaya)
- [Linkedin](https://www.linkedin.com/in/mehmet-%C3%B6zkaya-444a935/)
- [Twitter](https://twitter.com/ezozkme)
- [Medium](https://mehmetozkaya.medium.com/)
- [YouTube](https://www.youtube.com/user/mehmetozkaya)

## Progresso do curso

16 seções • 177 aulas • Duração total: 24h 31m

### [Introduction](01-Introduction/Notes.md)

- [x] Introduction 06:34
- [x] Prerequisites and Source Code 03:09
- [x] Run Final Application 13:48
- [x] What are Microservices ? 01:38
- [x] Monolithic Architecture Pros-Cons 03:01
- [x] Microservices Architecture Pros-Cons 04:36
- [x] Monolithic vs Microservices Architecture Comparison 02:52
- [x] What is Containers and Docker ? 01:15
- [x] Docker Containers, Images, and Registries 01:54

### [Developing Your First Microservice - Catalog.API with MongoDb](02-Developing-Your-First-Microservice-Catalog.API-with-MongoDb/Notes.md)

- [x] Introduction 01:29
- [x] Create New Github Repository For Our Microservice Project 01:48
- [x] Clone Github Repository and Create New Solution with Visual Studio 04:54
- [x] Create Asp.Net Web Api Project for Catalog.API Microservice 05:34
- [x] MongoDb in Catalog Microservices 01:56
- [x] Setup Mongo Docker Database for Catalog.API Microservices 08:00
- [x] MongoDb CLI Commands using Interactive Terminal For MongoDb Connection 06:48
- [x] Analysis and Architecting of Catalog Microservices 06:32
- [x] Repository Design Pattern 02:55
- [x] Developing Catalog.API Microservices Creating Entities and MongoDB.Driver Nuget 07:37
- [x] Developing Data Layer - Connect Mongo Docker Container from Catalog.API 16:06
- [x] Developing Business Layer - Repository Pattern on Catalog.API Microservice 13:10
- [x] Developing Presentation Layer - Create CatalogController Class for Catalog.API 22:29
- [x] Test and Run Catalog Microservice 07:22
- [x] Containerize Catalog Microservices with MongoDB using Docker Compose 10:26
- [x] Adding MongoDb image into Docker-Compose File for Multi-Container Docker Environment 11:26
- [x] Test on Docker environment - Catalog.API and MongoDb into Docker-Compose File 07:30
- [x] Debugging Docker-Compose on Visual Studio for Catalog.API with MongoDb 16:10
- [x] Mongo GUI Options for MongoDb Docker Image 04:41

### [Developing Basket.API Microservices with Redis](03-Developing-Basket.API-Microservices-with-Redis/Notes.md)

- [x] Introduction 01:31
- [x] Create Asp.Net Web Api Project for Catalog.API Microservice 05:31
- [x] Redis in Basket Microservices 02:06
- [x] Setup Redis Cache Docker Database for Basket.API Microservices 05:18
- [x] Redis CLI Commands using Interactive Terminal For Redis Connection 03:36
- [x] Analysis and Architecting of Basket Microservices 07:20
- [x] Developing Basket.API Microservices Creating Entities 06:08
- [x] Connect Redis Docker Container from Basket.API Microservice w/ AddStackExchange 07:30
- [x] Developing Repository Pattern on Basket.API Microservice 12:56
- [x] Create BasketController Class for Basket.API Microservice 12:22
- [x] Test and Run Basket Microservice 07:17
- [x] Containerize Basket Microservices with Redis using Docker Compose 10:28
- [x] Adding Redis image into Docker-Compose File for Multi-Container Docker Env 05:46
- [x] Test on Docker environment - Catalog.API and MongoDb into Docker-Compose File 07:18
- [x] Container management with Portainer 12:20

### [Developing Discount.API Microservices with PostgreSQL](04-Developing-Discount.API-Microservices-with-PostgreSQL/Notes.md)

- [x] Introduction 01:46
- [x] Create Asp.Net Web Api Project for Discount.API Microservice 05:24
- [x] PostgreSQL in Discount Microservices 01:53
- [x] Setup PostgreSQL Docker Database for Discount.API Microservices 05:20
- [x] Setup pgAdmin Management Portal for PostgreSQL Database for Discount.API Microse 13:07
- [x] Create Coupon Table in the DiscountDb of PostgreSQL Database with pgAdmin Manage 06:36
- [x] Analysis and Architecting of Discount Microservices 05:42
- [x] Developing Discount.API Microservices Creating Entities 01:42
- [x] Developing Repository Pattern Connect PostgreSQL use Dapper on Discount.API 19:03
- [x] Create DiscountController Class for Discount.API Microservice 08:15
- [x] Test and Run Discount Microservice 09:21
- [x] Containerize Discount Microservices with PostgreSQL using Docker Compose 05:50
- [x] Adding PostgreSQL image into Docker-Compose File for Multi-Container Docker Env 02:37
- [x] Migrate PostreSQL Database When Discount Microservices Startup 22:30
- [x] Test on Docker environment - Discount.API and PostgreSQL into Docker-Compose 09:50

### [Developing Discount.Grpc Microservices for Microservices Grpc Communication](05-Developing-Discount.Grpc-Microservices-for-Microservices-Grpc-Communication/Notes.md)

- [x] Introduction 01:52
- [x] gRPC usage of Microservices Communication 02:28
- [x] Using gRPC in Microservices Communication with .Net - Example Repository 01:49
- [x] Create Discount Grpc Microservices Project in Microservices Solution 13:56
- [x] Managing PostreSQL Database Operations in Discount Grpc 08:59
- [x] Developing discount.proto ProtoBuf file for Exposing Crud Services Discount Grpc 09:57
- [x] Generate Proto Service Class from Discount proto File in Discount Grpc 05:01
- [x] Developing DiscountService class to Implement Grpc Proto Service Methods 09:47
- [x] Implementing AutoMapper into DiscountService Class of Discount Grpc Microservice 05:20
- [x] Developing CRUD in DiscountService class to Implement CRUD Grpc Proto Service 05:35

### [Consuming Discount Grpc Service From Basket Microservice When Adding Cart Item](06-Consuming-Discount-Grpc-Service-From-Basket-Microservice-When-Adding-Cart-Item/Notes.md)

- [x] Introduction 01:45
- [x] Consuming Discount Grpc Service From Basket Microservice When Adding Cart Item 1 08:49
- [x] Consuming Discount Grpc Service From Basket Microservice When Adding Cart Item 2 11:57
- [x] Register Discount Grpc Client and Discount Grpc Service into the Basket.API 07:54
- [x] Test and Run Discount Grpc and Basket Microservice 09:05
- [x] Containerize Discount Grpc Microservices with PostgreSQL using Docker Compose 06:27
- [x] Adding Grpc DiscountUrl Configuration in Basket.API image configuration on DC 04:24
- [x] Test on Docker environment - Basket.API integrate Discount.Grpc into DC 20:46

### [Developing Ordering Microservices with Clean Architecture and CQRS Implemntation](07-Developing-Ordering-Microservices-with-Clean-Architecture-and-CQRS-Implemntation/Notes.md)

- [x] Introduction 01:57
- [x] Analysis and Architecting of Ordering Microservices 06:35
- [x] Design Principles - SOLID 03:08
- [x] Design Principles - Dependency Inversion Principles (DIP) 02:40
- [x] Design Principles - Separation of Concerns (SoC) 01:52
- [x] Domain Driven Design - DDD 04:30
- [x] Clean Architecture with Domain Driven Design(DDD) 09:44
- [x] CQRS (Command Query Responsibility Segregation) Design Pattern 02:19
- [x] Eventual Consisteny and Event Sourcing with CQRS Design Pattern 05:45
- [x] Code Structure on CQRS and DDD Implementation in Ordering Microservices 06:07
- [x] Create Asp.Net Web Api Project for Ordering.API Microservice 04:21
- [x] Create Clean Architecture Layers that Ordering Domain - Application and Infra 04:21
- [x] Adding Project References Between Clean Architecture Layers 04:30
- [x] Developing Ordering.Domain Layer in Clean Architecture 06:20
- [x] Developing Ordering.Application Layer with CQRS Pattern Implementation in Clean 03:40
- [x] Developing Ordering.Application Layer - Application Contracts 15:52
- [x] CQRS Implementation with Mediator Design Pattern 03:15
- [x] Developing Ordering.Application Layer- Application Features - GetOrdersListQuery 19:00
- [x] Developing Ordering.Application Layer - Application Command Features - Checkout 25:01
- [x] Developing Ordering.Application Layer- Application Command Features- UpdateOrder 14:52
- [x] Developing Ordering.Application Layer- Application Command Features- DeleteOrder 13:42
- [x] Developing Ordering.Application Layer - Application Behaviours 17:33
- [x] Developing Ordering.Application Layer - Application Service Registrations 14:44
- [x] Developing Ordering.API Presentation Layer in Clean Architecture 17:24
- [x] Developing Ordering.Infrastructure Layer in Clean Architecture - Persistence 12:43
- [x] Developing Ordering.Infrastructure Layer in Clean Architecture - Repositories 22:50
- [x] Developing Ordering.Infrastructure Layer - Infrastructure Service Registrations 10:48
- [x] Register Application and Infrastructure Layer Dependencies into Ordering.API 07:42
- [x] Adding EF Core Migrations for Code-First Approach in Ordering Microservices 06:21
- [x] Applying EF.Core Migrations to Sql Server Automatically When Ordering.API 18:36
- [x] Adding SqlServer image into Docker-Compose File for Multi-Container Docker Env 09:07
- [x] Test and Run Ordering Microservice 07:22
- [x] Test Ordering Microservices CQRS and Clean Architecture Flows 19:36
- [x] Containerize Ordering Microservices with SqlServer using Docker Compose 10:49
- [x] Test on Docker environment - Ordering.API and SqlServer into Docker-Compose File 13:01

### [Microservices Async Communication w/ RabbitMQ & MassTransit for Checkout Order](08-Microservices-Async-Communication-with-RabbitMQ-and-MassTransit-for-Checkout-Order/Notes.md)

- [x] Introduction 03:59
- [x] Microservices Communication Types Request-Driven or Event-Driven Architecture 03:31
- [x] What is RabbitMQ, Main Components of RabbitMQ 03:49
- [x] RabbitMQ Exchange Types 04:18
- [x] Adding RabbitMQ image into Docker-Compose File for Multi-Container Docker Env 09:20
- [x] Analysis & Design BuildingBlocks EventBus.Messages Class Library Project 04:20
- [x] Developing BuildingBlocks EventBus.Messages Class Library 10:56
- [x] Produce RabbitMQ Event From Basket Microservice Publisher of BasketCheckoutEvent 17:41
- [x] Publish BasketCheckout Queue Message Event in Basket.API Controller Class 20:58
- [x] Publish BasketCheckout Queue Message Event in Basket.API Controller Class Part 2 07:42
- [x] Test BasketCheckout Event in Basket.API Microservices 11:51
- [x] Consume RabbitMQ Event From Ordering Microservice Subscriber of BasketCheckout 21:48
- [x] Subscribe BasketCheckout Queue Message Event in Ordering BasketCheckoutConsumer 18:09
- [x] Test BasketCheckout Event in Basket.API and Ordering.API Microservices 17:17
- [x] Test MassTransit Retry Mecanism of RabbitMQ Connection Problems 07:57
- [x] Containerize Basket and Ordering Microservices w/ RabbitMQ using Docker Compose 18:16
- [x] Test on Docker environment - Basket and Ordering with RabbitMQ in Docker-Compose 13:04

### [Building API Gateways with Ocelot and Applying Gateway Routing Pattern](09-Building-API-Gateways-with-Ocelot-and-Applying-Gateway-Routing-Pattern/Notes.md)

- [x] Introduction 01:39
- [x] Gateway Routing pattern 01:26
- [x] API Gateway Pattern 02:34
- [x] BFF Backend for Frontend Pattern 02:32
- [x] Main features in the API Gateway pattern 02:01
- [x] Ocelot API Gateway 02:32
- [x] Authentication and authorization in Ocelot API Gateway 02:13
- [x] Analysis & Design of API Gateway Microservices 02:26
- [x] Developing Ocelot Api Gateway Microservices with Adapting Ocelot Nuget Package 12:01
- [x] Adding ocelot.json Configuration File For Routing Microservices in Ocelot Api Gw 33:00
- [x] Test Ocelot Api Gateway With Routing Internal Microservices 15:40
- [x] Rate Limiting in Ocelot Api Gateway with Configuring Ocelot.json File 09:54
- [x] Response Caching in Ocelot Api Gateway with Configuring Ocelot.json File 06:35
- [x] Configure Ocelot Json For Docker Development Environment in Ocelot Api Gateway 10:58
- [x] Containerize Ocelot Api Gateway Microservices using Docker Compose 06:02
- [x] Test on Docker environment - Ocelot API Gateway into Docker-Compose File 12:51

### [Api Gateway - Requests Aggregation Pattern in Shopping.Aggregator](10-Api-Gateway-Requests-Aggregation-Pattern-in-Shopping.Aggregator/Notes.md)

- [x] Introduction 01:51
- [x] Gateway Aggregation pattern 03:18
- [x] Analysis & Design of Shopping.Aggregator Microservices - Gateway Aggregation 03:22
- [x] Developing Shopping.Aggregator Microservices 05:01
- [x] Developing Dto Model Class for Api Aggreation Operations 11:13
- [x] Developing Service Classes for Consuming Internal Microservices in Shopping.Aggr 21:31
- [ ] Developing Service Classes Consuming Internal Microservices in Shopping.Aggr-2 30:02
- [ ] Test Shopping.Aggreation Microservices with Docker Internal Microservices 15:28
- [ ] Containerize Shopping.Aggregator Microservices using Docker Compose 07:14
- [ ] Test on Docker environment - Shopping.Aggregator into Docker-Compose File 06:29

### Securing Microservices with IdentityServer4 and Ocelot

- [ ] Introduction 02:04

### Building Shopping Web Application Microservices

- [ ] Introduction 01:50
- [ ] Background of Project 02:20
- [ ] Analysis & Design Shopping Web Application Microservice 03:07
- [ ] Developing AspnetBasics Shopping Web Application Microservices 08:28
- [ ] Overview of AspnetBasics Shopping Web Application Microservices 12:54
- [ ] Refactoring of AspnetBasics Shopping Web Application Microservices 11:11
- [ ] Register Http Client Factory for Consuming Api Gateway in AspnetBasics Shopping 06:41
- [ ] Developing Service Implementations for Consuming Api Gateway in AspnetBasics 10:31
- [ ] Developing Index Page in AspnetBasics Shopping Web Application Microservices 06:20
- [ ] Developing Product Page in AspnetBasics Shopping Web Application Microservices 07:03
- [ ] Developing Product Detail Page in AspnetBasics Shopping Web Application 02:36
- [ ] Developing Cart and Order Page in AspnetBasics Shopping Web Application 08:36
- [ ] Developing CheckOut Page in AspnetBasics Shopping Web Application Microservices 07:16
- [ ] Refactoring Developments in AspnetBasics Shopping Web Application Microservices 04:37
- [ ] Test AspnetBasics Shopping Web Application Microservices Over Ocelot Api Gateway 16:53
- [ ] Containerize AspnetBasics Shopping Web Application Microservices using DC 06:39
- [ ] Test on Docker environment - AspnetBasics Shopping Web Microservices into Docker 09:02

### Assignment - Developing Blazor Single Page Application with Custom Api Gateway

- [ ] Developing Blazor Single Page Application with Custom Api Gateway for CRUD 02:06

### Cross-Cutting Concerns - Microservices Observability with Distributed Logging

- [ ] Microservices Observability with Distributed Logging, Health Monitoring, Resilie 02:17

### Deploying Microservices to Kubernetes, Automating with Azure DevOps into AKS

- [ ] Deploying Microservices to Kubernetes, Automating with Azure DevOps into AKS 02:15

### Thanks and Bonus Lecture

- [ ] Bonus Lecture 05:41
- [ ] Thanks 00:37
