2024-01-25

13:39

Task 4

- Added a data model class  in Models/Movie.cs
- Used scaffolding tools to create CRUD models.
- Did the initial imigration with help of these commands- Add-Migration InitialCreate Update-Database
- Tested the task on browser and it was running fine.

Task 5 

-  Mapping Movie objects to database records.
-  Creating new class SeedData.
-  Replacing few contents of program.cs file.

Task 6
-  Make changes in Models/Movie.cs file.
-  Examining two edit actions in the Movies controller.
-  Run the application and navigate to the /Movies URL.


2024-02-01

13:21

Task 7

- Adding search capability to the Index action method.
- Open Views/Movies/Index.cshtml and update the file by adding the provided <form> markup.
- Modify the Index method parameter. Replace the searchString parameter with id if you want to use route data for search.
- Introduce a MovieGenreViewModel class in the Models folder. Replace the Index method in MoviesController.cs 
- After implementing these changes, run your ASP.NET Core MVC app and navigate to the /Movies/Index endpoint. Test the search and genre filter functionalities to ensure they work as expected.


Task 8

- Opened Models/Movie.cs and added the Rating property to the Movie class.
- Open Controllers/MoviesController.cs and update the [Bind] attribute for both the Create and Edit action methods to include the Rating property.
- Updated the view templates to include the new Rating property. Opened Views/Movies/Index.cshtml and added a new table column for the Rating field.
- Open the SeedData.cs file and update the sample data with values for the new Rating property.
- Run the app and verify that you can create, edit, and display movies with the new Rating field


Task 9 

- Open Models/Movie.cs and apply validation attributes to the properties in the Movie class.
- Run the app and navigate to the Movies controller. Select the "Create New" link and attempt to add a new movie with invalid values
- Examine the Create methods in the MoviesController (GET and POST). The [HttpPost] version checks ModelState.IsValid to determine if the movie has validation errors.
