# IMDB(Internet Movie Database)-Tech-Module
IMDB(in C#, Java, JS and PHP) - Exam Preparation for the Tech Module @ SoftUni (August 2017)

You are assigned to create a simple **IMDB App**. The application should hold **films**, which are the main app entities. 
The functionality of the application should support creating, listing, editing and deleting films.
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

The `Film ` entity holds 5 properties:
*	`id` – technology-dependent identifier (`ObjectID` for JavaScript, `int` for all other technologies)
*	`name` – non-empty text
*	`genre` – non-empty text
*	`director` – non-empty text
*	`year` – non-null integer

## User Interface
This is the user interface or how the application’s pages should look in their final form (fully implemented).

Index Page
Route: `/` (GET)

List all films from the database with 2 options as actions to modify them.

### Create Page
Route: `/create` (GET and POST)

`GET` shows a form to create a film. `POST` saves the form data into the database as new film.

### Edit Page
Route: `/edit/{id}` (GET and POST)

`GET` shows a form to edit a certain film. `POST` confirms editing a film and modifies the film in the database.

### Delete Page
Route: `/delete/{id}` (GET and POST)

`GET` shows a form to delete a certain film. `POST` confirms deleting a film and removes the film from the database.
