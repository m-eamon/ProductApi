FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /webapi

COPY *.csproj ./

RUN dotnet restore

EXPOSE 8080

COPY . ./

RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "watch", "run"]
