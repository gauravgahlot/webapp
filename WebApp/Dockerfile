FROM microsoft/dotnet:2.1-sdk AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore 

COPY . .
RUN dotnet publish -c Release -o /out

# Build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
LABEL Author="Gaurav Gahlot"
LABEL Maintainer="quickdevnotes"
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "WebApp.dll", "--server.urls", "http://*:80"]
