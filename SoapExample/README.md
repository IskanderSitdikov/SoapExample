# Svcutil
## Install
```shell
dotnet tool install --global dotnet-svcutil --version 8.0.0
```
## Check installation
```shell
dotnet-svcutil --help
```

## Adding soap client
```shell
dotnet add package System.ServiceModel.Primitives
dotnet add package System.ServiceModel.Http

cd ./SoapExample/SoapService
dotnet-svcutil globalweather.wsdl --namespace "*,ExternalServices.GlobalWeather"
```