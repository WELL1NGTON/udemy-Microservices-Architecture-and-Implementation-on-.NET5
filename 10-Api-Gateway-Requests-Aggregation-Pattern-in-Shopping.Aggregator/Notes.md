# Anotações do curso

## Api Gateway - Requests Aggregation Pattern in Shopping.Aggregator

### Introdução

Utilizar o Aggragation Pattern para facilitar a comunicação com as apis (um request para aggregation vão ser vários requests para as apis).

![Big Picture](images/big-picture.png)

### Gateway Aggregation pattern

![Gateway Aggregation pattern](images/gateway-aggregation-pattern.png)

### Analysis & Design of Shopping.Aggragator Microservices - Gateway Aggregation

![Direct Synchronous Communication](images/direct-synchronous-communication.png)

![Chaining HTTP Calls](images/chaining-http-calls.png)

![Gateway Aggregation Pattern](images/gateway-aggregation-pattern2.png)

![Architecture of Shopping.Aggregator](images/architecture-of-shoppingaggregator.png)

### Developing Shopping.Aggregator Microservices

Adicionado o novo projeto Shopping.Aggregator em ApiGateways:

```bash
# Criando o projeto
cd src/ApiGateways
dotnet new webapi -o Shopping.Aggregator --no-https --exclude-launch-settings

# Adicionando a solução
cd ..
dotnet sln add ApiGateways/Shopping.Aggregator/Shopping.Aggregator.csproj
```

### Developing Dto Model Class for Api Aggreation Operations

