# Practical Exam – Anime List - Tech-Module
Anime List(in C#, Java, JS and PHP) - Practical Exam for the Tech Module @ SoftUni (September 2017)

You have been tasked to create a simple application that simulates an **Anime List App**. The application should hold **animes**, which are the main app entities. The app is called AnimeList.
The functionality of the application should support creating, listing, deleting animes.
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

The `Anime` entity holds 5 properties:
*	`id` – technology-dependent identifier (`ObjectID` for JavaScript, `int` for all other technologies)
*	`rating` – non-null integer
*	`name` – non-empty text
*	`description` – non-empty text
*	`watched` – non-empty text(will either be **"watched"** or **"not watched"**).

## User Interface
This is the user interface or how the application’s pages should look in their final form (fully implemented).

### Index Page
Route: `/` (GET)

Displays all the animes from the database with an option to modify them.

### Create Page
Route: `/create` (GET and POST)

`GET` shows a form to add an anime. `POST` saves the form data into the database as new anime.

### Delete Page
Route: `/delete/{id}` (GET and POST)

`GET` shows a form to delete a certain anime. `POST` confirms deleting a anime and modifies the anime in the database.

## Languages and Technologies
Implement the **Anime List App** on all mentioned 4 technology stacks.
