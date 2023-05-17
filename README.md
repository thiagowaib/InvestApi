# InvestApi
Repositório criado para o aplicativo InvestApi desenvolvido durante o curso de BSI


## Comandos
dotnet new webapi -o <nome>

dotnet dev-certs https --trust

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0.0

dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.0

dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 6.0.0

dotnet add package Microsoft.EntityFrameworkCore.sqlserver --version 6.0.0

dotnet tool install -g dotnet-aspnet-codegenerator --version 6.0.0

dotnet aspnet-codegenerator controller -name OrdensController -async -api -m Ordem -dc InvestApiContext -outDir Controllers -sqlite