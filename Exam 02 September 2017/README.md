# Practical Exam – Shopping List - Tech-Module
Shopping List(in C#, Java, JS and PHP) - Practical Exam for the Tech Module @ SoftUni (September 2017)

You have been tasked to create a simple application that simulates a **Shopping List App**. The application should hold **products**, which are the main app entities. The app is called ShoppingList.
The functionality of the application should support creating, listing, editing products.
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

The `Product` entity holds 5 properties:
*	`id` – technology-dependent identifier (`ObjectID` for JavaScript, `int` for all other technologies)
*	`priority` – non-null integer
*	`name` – non-empty text
*	`quantity` – non-null integer
*	`status` – non-empty text(will either be **"bought"** or **"not bought"**).

## User Interface
This is the user interface or how the application’s pages should look in their final form (fully implemented).

### Index Page
Route: `/` (GET)

Displays all the products from the database with an option to modify them.

### Create Page
Route: `/create` (GET and POST)

`GET` shows a form to add a product. `POST` saves the form data into the database as new product.

### Edit Page
Route: `/edit/{id}` (GET and POST)

`GET` shows a form to edit a certain product. `POST` confirms editing a product and modifies the product in the database.

## Languages and Technologies
Implement the **Shopping List App** on all mentioned 4 technology stacks.
