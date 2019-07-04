# Copa Filmes


## Dependências

[Dotnet Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)

[Flurl](https://flurl.dev/)

[Swashbuckle.Swagger](https://www.nuget.org/packages/Swashbuckle.AspNetCore.Swagger/)

[Angular](http://angular.io)

## Ambiente de desenvolvimento

### Back-end

Execute
```sh
cd CopaFilmes.Api
dotnet run
```

Testes

```
dotnet test
```

### Front-end

Configurar o arquivo CopaFilmesAngular/src/environments/environment.ts
Ajustar a variavel `worldCupUrl` com a url da API (Projeto CopaFilmes.API).

Executar 

```
npm start
```

Navegar até http://localhost:4200/