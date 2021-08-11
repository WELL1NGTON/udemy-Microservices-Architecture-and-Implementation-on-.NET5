# Anotações do curso

## Developing Basket.API Microservices with Redis

### Introdução

Implementar Basket.API com Redis (Web API com CRUD):

![Big Picture](images/big-picture.png)

### Create Asp.Net Web Api Project for Catalog.API Microservice

Criado novo projeto `csproj` em `src/Services/Basket` com o comando:

```bash
# Obs.: adicionei o parâmetro --exclude-launch-settings pois aquelas configurações são inúteis no vscode
dotnet new webapi --auth None --no-https --exclude-launch-settings -o Basket.API
```
