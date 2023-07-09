# What's in the box

1. Blazor, Rest Api, Models Project.
2. EfCore with Sqlite for DB.
3. Bootstrap CSS.
4. Net 6.

# Database Setting Up
- You need to install Sqlite in your laptop if need it (Mac already has it).
- Open in terminal CowsOnlineShop.Api

and run the following cmd:
-  dotnet ef migrations add Initial
-  dotnet ef database update

# if any problem came up with the database run:
- delete CowsOnlineShop.Api/Migration directory
- dotnet ef database drop -f -v
- repite steps above to spin up the BD


# Web could be reached at:
- https://localhost:5001/

# Api could be reached at:
- https://localhost:5000/

# Api definitions could be reached at:
- https://localhost:5000/swagger/index.html
