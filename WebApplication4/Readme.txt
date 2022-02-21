Pacotes instalados
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL

Comandos do Migration executados para criação do banco
Add-Migration Criacao-Inicial -Context Contexto
Update-database -Context Contexto