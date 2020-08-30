## Setting up

Resource Group:

    az login
    az group create -n "Projects" -l "uksouth"

SQL Server creation:

    az sql server create -g "Projects" -n "tsql-server12345" -l "uksouth" --admin-user "admin1" --admin-password "ui!Pl9PFV5" --no-wait

SQL Database creation:

    az sql db create -n "tsql-sql" -g "Projects" -s "tsql-server12345" --no-wait

Connect using preferred integrated environment for databases, I will be using SSMS.

## Preparation

