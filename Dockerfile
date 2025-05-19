# Image cơ sở cho runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Image build ứng dụng
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy file .csproj trước để tận dụng cache
COPY Quiz/Quiz.csproj Quiz/
RUN dotnet restore "Quiz/Quiz.csproj"

# Copy toàn bộ source code
COPY . .

# Thiết lập thư mục làm việc và build
WORKDIR "/src/Quiz"
RUN dotnet build "Quiz.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish ứng dụng
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Quiz.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Image cuối để chạy ứng dụng
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Chạy ứng dụng
ENTRYPOINT ["dotnet", "Quiz.dll"]
