# Kamaljeet_Kaur_Web315AssignmentAsp
 dotnet new webapp -o KamalBag --no-https
 cd .\KamalBag\
dotnet watch run
Add NuGet packages and EF tools

dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet-aspnet-codegenerator razorpage -m Bag -dc KamalBagContext -udl -outDir Pages/Bags --referenceScriptLibraries -sqlite

 dotnet watch run

 dotnet ef migrations add InitialCreate
 dotnet ef database update
