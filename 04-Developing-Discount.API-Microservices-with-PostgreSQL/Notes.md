# Anotações do curso

## Developing Discount.API Microservices with PostgreSQL

### Introdução

Implementar Discount.API com PostgreSQL:

![Big Picture](images/big-picture.png)

### Create Asp.Net Web Api Project for Discount.API Microservice

Criado novo projeto `csproj` em `src/Services/Discount` com o comando:

```bash
# Obs.: adicionei o parâmetro --exclude-launch-settings pois aquelas configurações são inúteis no vscode
dotnet new webapi --auth None --no-https --exclude-launch-settings -o Discount.API
```
