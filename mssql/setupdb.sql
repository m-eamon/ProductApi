IF EXISTS 
   (
     SELECT name FROM master.dbo.sysdatabases 
    WHERE name = N'ProductsDB'
    )
BEGIN
    SELECT 'Database Name already Exist' AS Message
END
ELSE
BEGIN
    CREATE DATABASE ProductsDB
    SELECT 'New Database is Created'
END