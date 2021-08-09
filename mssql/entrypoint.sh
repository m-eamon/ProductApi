#!/bin/bash

for i in {1..50};
do
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Passw0rd -d master -i setupdb.sql
    if [ $? -eq 0 ]
    then
        echo "setupdb.sql completed"
        break
    else
        echo "waiting for setupdb.sql to complete"
        sleep 1
    fi    
done
