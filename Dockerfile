FROM microsoft/dotnet:2.1-sdk AS build-env
WORKDIR /app

COPY WebApp/*.csproj ./
COPY . ./
RUN dotnet restore 

FROM build-env AS publish
RUN dotnet publish -c Release -o /app

# Build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
LABEL Author="Gaurav Gahlot"
LABEL Maintainer="quickdevnotes"
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApp.dll", "--server.urls", "http://*:80"]
