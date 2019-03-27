# Base image for the container
FROM microsoft/dotnet:2.1-aspnetcore-runtime

# Set image metadata
LABEL Author="Gaurav Gahlot"
LABEL Description="Image for WebApp Client"

# Create working directory
WORKDIR /app

# Set environment 
ENV ASPNETCORE_ENVIRONMENT Testing

# Copy the binaries to /app (.)
COPY  publish/ .

# Set application entrypoint 
ENTRYPOINT ["dotnet", "WebApp.dll", "--server.urls", "http://*:80"]
