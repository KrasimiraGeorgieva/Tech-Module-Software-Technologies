# TODO-List-Tech-Module
TODO List (in C#, Java, JS and PHP) - Exam Preparation for the Tech Module @ SoftUni (August 2017)

You are assigned to create a **Simple TODO List App**. The application should hold **tasks**, which are the main app entities.
The functionality of the app should support creating, listing and deleting tasks. The application should persist the data into a database.

## Overview
Your application should be built on each one of the following technologies:

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

## Data Model
The `Task` entity holds 3 properties:
* `id` - technology-dependent identifier (`ObjectID` for JavaScript, `int` for all other technologies)
* `title` - string
* `comments` - string, which can hold any ASCII character.

## User Interface
This is the user interface should consists of the following pages (under the designated routes):

### Index Page
Route: `/` (GET)

List all tasks.
 
### Create Page
Route: `/create` (GET and POST)

`GET` shows a form to create a task. `POST` saves the form data into the database as new task.
 
### Delete Page
Route: `/delete/{id}` (GET and POST)

`GET` shows a form to delete a certain task. `POST` confirms deleting a task and removes the task from the database.
 
## Languages and Technologies
Implement the **TODO List App** on all mentioned 4 technology stacks.