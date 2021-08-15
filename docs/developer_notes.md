# Developer Notes

### Running application in containers
```shell
docker-compose up --build
```

To run in the background
```shell
docker-compose up --build -d
```



### Populating Products Table
```shell
docker exec products-db /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "Passw0rd" -i "./populateProduct.sql"
```
