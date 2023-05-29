## Add migration

```
dotnet ef migrations add "Init" --startup-project EnterWellTest --project EnterWellTest.Infrastructure -o Persistence/Migrations --context EnterWellTestDbContext
```


## Remove migration

```
dotnet ef migrations remove --startup-project EnterWellTest --project EnterWellTest.Infrastructure --context EnterWellTestDbContext
```