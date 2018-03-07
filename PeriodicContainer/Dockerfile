FROM microsoft/dotnet:2.0-runtime
WORKDIR /app
COPY bin/Debug/netcoreapp2.0/publish/ /app
ENTRYPOINT ["dotnet", "PeriodicContainer.dll"]
