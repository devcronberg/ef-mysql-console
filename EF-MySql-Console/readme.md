# EF6 + MySql

## NuGet (MySql.Data.Entity)

```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="EntityFramework" version="6.2.0" targetFramework="net47" />
  <package id="MySql.Data" version="6.10.8" targetFramework="net47" />
  <package id="MySql.Data.Entity" version="6.10.8" targetFramework="net47" />
</packages>
```

## Tilføj connectionstrings.user

```
<connectionStrings>
    <add name="MysqlContext" connectionString="Server=?;Database=?;Uid=?;Pwd=?;" providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```

Husk at sætte den til at kopiere til output
