FROM mcr.microsoft.com/mssql/server

COPY populateProduct.sql populateProduct.sql

USER root

RUN chown -R 10001:0 populateProduct.sql

USER 10001
