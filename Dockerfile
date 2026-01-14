# stage 1 - bygg programmet
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src
# kopiera projektfilen instalera beroenden
COPY .sln .
COPY PersonnummerApp/.csproj ./PersonnummerApp/
RUN dotnet restore
# kopiera resten av koden och bygg appen
COPY . .
WORKDIR /app/PersonnummerApp
RUN dotnet publish -c Release -o out

# stage 2 - Runtime-miljö
FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app
COPY --from=build /app/PersonnummerApp/out .

ENTRYPOINT [ "dotnet", "PersonnummerApp.dll" ]
