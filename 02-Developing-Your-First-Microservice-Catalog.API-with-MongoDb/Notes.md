# Anotações do curso

## Developing Your First Microservice - Catalog.API with MongoDb

### Create Asp.Net Web Api Project for Catalog.API Microservice

O instrutor desmarcou a opção **HTTPS** no Visual Studio quando ele estava criando o projeto Catalog.API para que ele pudesse "deploy to Kubernets without certification".

Comando executado com netcore cli:

```bash
dotnet new webapi --auth none --no-https -o Catalog.API
```

### Setup Mongo Docker Database for Catalog.API Microservices

Está usando a imagem oficial do MongoDB do [DockerHub](https://hub.docker.com/) para testes.

Link da imagem oficial no DockerHub: [mongo](https://hub.docker.com/_/mongo).

### MongoDb CLI Commands using Interactive Terminal For MongoDb Connection

Foram executados alguns [comandos de teste](16-Comandos-Testados.md) para demonstrar o mongo.

### Analysis and Architecting of Catalog Microservices

Métodos (REST) da API Catalog:

| Method | Request URI                                    | Use Case                        |
|--------|------------------------------------------------|---------------------------------|
| GET    | api/v1/Catalog                                 | Listing Products and Categories |
| GET    | api/v1/Catalog/{id}                            | Get Product with product Id     |
| GET    | api/v1/Catalog/GetProductByCategory/{category} | Get Products with category      |
| POST   | api/v1/Catalog                                 | Create new Product              |
| PUT    | api/v1/Catalog                                 | Update Product                  |
| DELETE | api/v1/Catalog/{id}                            | Delete Product                  |

Arquitetura da API Catalog:

![Catalog Layered Archictecture](images/catalog-layered-archictecture.png)

![Simple CRUD Microservices](images/simple-crud-microservices.png)

![Simple Data-Driven, CRUD Microservice](images/simple-data-driven-crud-microservice.png)

Pacotes Nuget que serão utilizados:

- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/)
- [MongoDB.Driver](https://www.nuget.org/packages/mongodb.driver)

### Repository Design Pattern

Vai utilizar o Repository Pattern na API Catalog

![Repository Pattern](images/repository-pattern.png)

### Developing Data Layer - Connect Mongo Docker Container from Catalog.API

Configura a "Data Layer" e criou uma seed de dados iniciais para o banco.

Obs.: Adicionei o pacote StyleCop.Analyzers e configurei ele para auxiliar na edição do código.

### Test and Run Catalog Microservice

Testes da API Catalog pelo Swagger e pelo Postman (Utilizando arquivo [json](Resources/23-Microservices.Net.postman_collection.json) de collections do postman)

### Containerize Catalog Microservices with MongoDB using Docker Compose

Como estou usando vscode no linux, não foi possível gerar o arquivo `docker-compose.dcproj` para integrar o compose a solution, então apenas criei os arquivos docker-compose.yaml e docker-compose.override.yaml em src.

### Test on Docker environment - Catalog.API and MongoDb into Docker-Compose File

Apenas testes com `docker-compose up` e `docker-compose down`.

### Mongo GUI Options for MongoDb Docker Image

O instrutor apenas demonstrou que é possível utilizar outra imagem em conjunto com os que estão rodando atualmente para acessar o banco de dados mongo com uma interface gráfica, ele demonstra isso utilizando a imagem docker [mongoclient/mongoclient](https://hub.docker.com/r/mongoclient/mongoclient/).
