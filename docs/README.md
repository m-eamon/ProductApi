## Getting Started

Run on Ubuntu version..

dotnet new webapi -o ProductApi
cd ProductApi
dotnet add package Microsoft.EntityFrameworkCore.InMemory
code -r ../Product

Trust the HTTPS development certificate by running the following command
dotnet dev-certs https 

Add Product and ProductContext models

Scaffold the Products Controller

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator controller -name ProductsController -async -api -m Product -dc ProductContext -outDir Controllers