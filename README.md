## Build technologies:

### PHP
* **Symfony** framework
* **Twig** view engine
* **Doctrine** ORM
* **MySQL** database

### JavaScript
* **NodeJS** + **ExpressJS** frameworks
* **Handlebars.js** view engine
* **Mongoose** data access
* **MongoDB** database

### Java
* **Spring** framework (Spring MVC + Spring Boot + Spring Data)
* **Thymeleaf** view engine
* **JPA** / **Hibernate** ORM + **Spring Data** data access
* **MySQL** database

### C#
* **ASP.NET** framework (ASP.NET MVC + Entity Framework)
* **Razor** view engine
* **Entity Framework** ORM
* **MSSQL Server** database


## Setup
Before you start working, make sure you download all the dependencies (packages) required for each technology and set up the databases! Below are instructions on how to do this:

### PHP and Symfony
1. Go into the root directory of the project (where the bin folder resides)
2. Make sure you’ve started your MySQL server (either from XAMPP or standalone)
3. Open a shell / command prompt / PowerShell window in that directory (shift + right click --> open command window here)
4. Enter the `php composer.phar install` command to restore its **Composer** dependencies (described in `composer.json`)
5. Enter the `php bin/console doctrine:database:create` command
6. Done!

### JavaScript and Node.js
1. Go into the root directory of the project (where the bin folder resides)
2. Make sure you’ve started your MongoDB server: `mongod.exe --dbpath path/to/db/directory`
3. Open a shell / command prompt / PowerShell window in the root directory (shift + right click --> open command window here)
4. Enter the `npm install` command to restore its **Node.js** dependencies (described in `package.json`)
5. Done!

### C# and ASP.NET MVC
The C# project will automatically resolve its **NuGet** dependencies (described in `packages.config`) using the NuGet package restore when the project is built.

### Java and Spring MVC
The Java project will automatically resolve its **Maven** dependencies (described in `pom.xml`) when the project is built.



