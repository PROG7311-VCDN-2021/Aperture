#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PROG7311/PROG7311.csproj", "PROG7311/"]
RUN dotnet restore "PROG7311/PROG7311.csproj"
COPY . .
WORKDIR "/src/PROG7311"
RUN dotnet build "PROG7311.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PROG7311.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PROG7311.dll"]