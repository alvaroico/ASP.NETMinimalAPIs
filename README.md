Criar diretorio WEB

```dotnet new web -o MiniTodo```

Rodar Prod

```dotnet run ```

Rodar Dev

```dotnet watch run```

Add Pacote

```
dotnet add package Microsoft.EntityFrameworkCore.SqLite

dotnet add package Microsoft.EntityFrameworkCore.Design
```

Criar Migration

```
dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreation
```

Criar Banco ou Atualizar

```
dotnet ef database update
```

```
dotnet add package Flunt
```

Documenta a API com 

```
dotnet add package Swashbuckle.AspNetCore -v 6.2.3
```