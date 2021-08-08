USE master
GO 
    IF NOT EXIST
        (SELECT productdb FROM sys.databases)
    CREATE DATABASE productdb;