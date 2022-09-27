#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Ca.Bell.Bbm.RpaTektonProveConcept.Api/Ca.Bell.Bbm.RpaTektonProveConcept.Api.csproj", "Ca.Bell.Bbm.RpaTektonProveConcept.Api/"]
RUN dotnet restore "Ca.Bell.Bbm.RpaTektonProveConcept.Api/Ca.Bell.Bbm.RpaTektonProveConcept.Api.csproj"
COPY . .
WORKDIR "/src/Ca.Bell.Bbm.RpaTektonProveConcept.Api"
RUN dotnet build "Ca.Bell.Bbm.RpaTektonProveConcept.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ca.Bell.Bbm.RpaTektonProveConcept.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ca.Bell.Bbm.RpaTektonProveConcept.Api.dll"]