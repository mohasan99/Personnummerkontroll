# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Kopiera lösningsfilen och projektfilerna separat för att utnyttja cache
COPY PersonnummerProjekt.sln ./
COPY PersonnummerApp/*.csproj ./PersonnummerApp/
COPY PersonnummerApp.Tests/*.csproj ./PersonnummerApp.Tests/

RUN dotnet restore

# Kopiera resten av källkoden och bygg
COPY . .
WORKDIR /src/PersonnummerApp
RUN dotnet publish -c Release -o /out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app
COPY --from=build /out ./

ENTRYPOINT ["dotnet", "PersonnummerApp.dll"]