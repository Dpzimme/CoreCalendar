#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["WebApp/CalendarE2.WebApp.csproj", "WebApp/"]
COPY ["CalendarE2.Data/CalendarE2.Data.csproj", "CalendarE2.Data/"]
COPY ["CalendarE2.Domain/CalendarE2.Domain.csproj", "CalendarE2.Domain/"]
COPY ["CalendarE2.Infrastructure/CalendarE2.Infrastructure.csproj", "CalendarE2.Infrastructure/"]
RUN dotnet restore "WebApp/CalendarE2.WebApp.csproj"
COPY . .
WORKDIR "/src/WebApp"
RUN dotnet build "CalendarE2.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CalendarE2.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalendarE2.WebApp.dll"]