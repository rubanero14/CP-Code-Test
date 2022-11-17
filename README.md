# CP Code Test .NET MVC using Entity Framework

## This code test is part of the .Net Developer role to:
- Assess ability to perform CRUD operations
- Assess ability to build user interfaces
- Understand the concept of MVC in .Net framework and Entity Framework
________________________________________________________________________________________________________________________

## Choice of Tech Stack
- ASP.NET Web Application (.NET Framework 4.7.2)
- Entity Framework for DB interfacing, create scaffolding for Models, Controllers and Views
- I should have done everything from grounds up, by writing own Controller, Model, View and LINQ queries but due to limited timeframe and this is my first attempt to build .NET MVC Web App, I chose EF

________________________________________________________________________________________________________________________

## Systems Required to run locally:
- Microsoft SQL Server Management Studio 18 (SSMS Developer edition) 
- MySQL Workbench 8.0
- IDE: Visual Studio 2019 and above

-------------------------------------------------------------------------------------------------------------------------
## Database Setup
- Open SSMS tool, create new DB Engine connection
- Enter new `Server Name`
- Choose `SQL Server Authentification` from dropdown
- Enter new Login ID (Password is optional), click `Connect`
- On `Object Explorer` panel, left click on `Databases` folder, Click `New Database`
- Enter `Database Name`, and click `Okay`
- Again, in `Object Explorer` panel, expand recursively the Databases folder until you found the DB you just created
- Left click on the your new DB, and click `New Query`
- On the Query file just opened, paste the contents of the SQL file attached in this repo
- Execute the query
- Again on `Object Explorer` panel, open recursively the new DB folder again, under `Tables` folder, you will find the the 3 new tables added
- Perform test queries to see if the DB is working
- Keep database connection online

![image](https://user-images.githubusercontent.com/85555894/202455734-b46126c8-e0ba-45bf-86d2-b699d27427c1.png)
![image](https://user-images.githubusercontent.com/85555894/202456161-1103e1a5-3bd9-4d77-9c3a-b633b1838c2c.png)
![image](https://user-images.githubusercontent.com/85555894/202456506-c9325b7b-b6e1-4523-b142-c352e9449737.png)
<br/>
![image](https://user-images.githubusercontent.com/85555894/202457396-4b696bff-36b2-49c5-bb16-9001f278f30f.png)

-----------------------------------------------------------------------------------------------------------------------------

## MVC Setup
- Open new project in your Visual Studio IDE
- Click `Clone a repository`
- Under `Repository Location`, enter this URL => `https://github.com/rubanero14/CP-Code-Test.git`
- Click `Clone`
- Run/Debug the program, and wait for the browser to pop up
- Now you are ready to test this Web Application locally
 
 ___________________________________________________________________________________________________________________________
