# Crear
Crear un proyecto asp:
```bash
dotnet new webapi -o testAsp
```

# Agregar Swagger
Agregar todas las dependencias del Swagger
```bash
dotnet add package Swashbuckle.AspNetCore
```

# Agregar cerficado https
Para agregar un certificado https en ubuntu:
```bash
dotnet dev-certs https --trust
```

# Compilar
Compilar aplicación ASP
```bash
dotnet build
```

# Correr
Correr aplicación ASP
```bash
dotnet run
```