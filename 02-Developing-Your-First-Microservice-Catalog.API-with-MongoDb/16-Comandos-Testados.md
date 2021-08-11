
# Comandos de teste utilizados na aula 16

Comando para inicializar a imagem:

```bash
docker pull mongo
docker run -d -p 27017:27017 --name shopping-mongo mongo
```

Comandos utilizados para demonstrar o MongoDB:

```bash
# Entrar no bash do container em modo interativo
docker exec -it shopping-mongo /bin/bash

# Verificadno as pastas na raiz
ls

# Abrindo o mongo cli para executar comandos no banco de dados
mongo

# Lista dbs
show dbs

# Cria CatalogDb no mongo
use CatalogDb

# Cria a collection "Products"
db.createCollection('Products')

# Insere documentos/dados na collection
db.Products.insertMany([{ 'Name':'Asus Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':54.93 }, { 'Name':'HP Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':88.93 } ])

# Visualiza os dados presentes na collection Products
db.Products.find({}).pretty()

# Remove todos os dados da collection Products
db.Products.remove({})

# Lista dbs (equivalente a show dbs)
show databases

# Lista as collections
show collections

# Lista os dados presentes na collection Products (vazia agora por conta do remove)
db.Products.find({}).pretty()
```
