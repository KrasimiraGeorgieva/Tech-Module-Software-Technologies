# Kanban-Board-Tech-Module
Kanban Board(in C#, Java, JS and PHP) - Exam Preparation for the Tech Module @ SoftUni (August 2017)

You are assigned to create a simple **Kanban Board App**. The application should hold **tasks**, which are the main app entities. 
Tasks can change their status: open -> in progress -> done. The app is called TeisterMask, like the popular Kanban board task management app “Meister Task”.
The functionality of the application should support creating, listing and editing tasks.
The application should persist the data into a database.

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
*	`id` – technology-dependent identifier (`ObjectID` for JavaScript, `int` for all other technologies)
*	`title` – non-empty text
*	`status` – non-empty text, which can hold either of the following values:
	-`Open`
	-`In progress`
	-`Finished`

## User Interface
This is the user interface or how the application’s pages should look in their final form (fully implemented).

### Index Page
Route: `/` (GET)

List all tasks in three columns.

### Create Page
Route: `/create` (GET and POST)

`GET` shows a form to create a task. `POST` saves the form data into the database as new task.

### Edit Page
Route: `/edit/{id}` (GET and POST)

`GET` shows a form to edit a certain task. `POST` confirms editing a task and modifies the task in the database.

## Languages and Technologies
Implement the **Kanban Board App** on all mentioned 4 technology stacks.
