# Anotações do curso

## Microservices Async Communication w/ RabbitMQ & MassTransit for Checkout Order

### Introdução

Implementar Api Gateways com Ocelot aplicando Gateway Routing Pattern.

![Big Picture](images/big-picture.png)

### Gateway Routing pattern

![Gateway Routing Pattern](images/gateway-routing-pattern.png)

### API Gateway Pattern

![API Gateway Pattern](images/api-gateway-pattern.png)  

### BFF Backend for Frontend Pattern

![Using multiple API Gateways / BFF](images/api-gateway-pattern.png)

### Main features in the API Gateway pattern

#### Ocelot Features

|                                        |                                     |
|----------------------------------------|-------------------------------------|
| Routing                                | Authentication                      |
| Request Aggregation                    | Authorization                       |
| Service Discovery with Consul & Eureka | Throttling                          |
| Load Balancing                         | Logging, Tracing                    |
| Correlation Pass-Through               | Headers/Query String Transformation |
| Quality of Service                     | Custom Middleware                   |

### Ocelot API Gateway

![Ocelot API Gateway](images/ocelot-api-gateway.png)

### Authentication and authorization in Ocelot API Gateway

![Authentication and Authorization in Ocelot](images/authentication-and-authorization-in-ocelot.png)

![Authentication in Ocelot API Gateway](images/authentication-in-ocelot-api-gateway.png)

### Analysis & Desing of API Gateway

- Route Catalog APIs with /Catalog path
- Route Baket APIs wiht /Basket path
- Route Ordering APIs with /Ordering path

| Method   | Request URI      | Use Case                     |
|----------|------------------|------------------------------|
| GET/POST | /Catalog         | Route   /api/v1/Catalog apis |
| GET      | /Catalog/{id}    | Route   /api/v1/Catalog apis |
| GET/POST | /Basket          | Basket  /api/v1/Basket apis  |
| POST     | /Basket/Checkout | Basket  /api/v1/Basket apis  |
| GET      | /Order           | Order   /api/v1/Order apis   |

![Architecture of API Gateway Microservices](images/architecture-of-api-gateway-microservices.png)

#### Nuget Packages of API Gateway

- [Ocelot](https://www.nuget.org/packages/Ocelot/)
- [Microsoft.VisualStudio.Azure.Containers.Tools.Targets](https://www.nuget.org/packages/Microsoft.VisualStudio.Azure.Containers.Tools.Targets)

### Developing Ocelot Api Gateway Microservices with Adapting Ocelot Nuget Package

Adicionado novo projeto "OcelotApiGw" em "src/ApiGateways" com os comandos:

```bash
cd src
mkdir ApiGateways
cd ApiGateways
dotnet new web --no-https --exclude-launch-settings -o OcelotApiGw
```

Adicionada referência do novo projeto ao sln executando o comando a seguir na pasta "src":

```bash
cd src
dotnet sln add ./ApiGateways/OcelotApiGw/OcelotApiGw.csproj
```

E adicionado pacot Nuget [Ocelot](https://www.nuget.org/packages/Ocelot/):

```bash
cd src/ApiGateways/OcelotApiGw
dotnet add package Ocelot
```

### Response Caching in Ocelot Api Gateway with Configuring Ocelot.json File

E adicionado pacot Nuget [Ocelot.Cache.CacheManager](https://www.nuget.org/packages/Ocelot.Cache.CacheManager/):

```bash
cd src/ApiGateways/OcelotApiGw
dotnet add package Ocelot.Cache.CacheManager
```

### Links

- [Documentação Ocelot](https://ocelot.readthedocs.io/en/latest/introduction/gettingstarted.html)
