# Support Web Application Management System

 

This project is a simple web application that allows users to manage tickets in a support service. Users can submit new appeals, mark them as resolved, and view active appeals with consideration to their deadlines.

 

## Features

 

- Users can enter a description for the appeal and set its deadline.

- Appeals are displayed in a list of active appeals, taking into account their deadlines. Overdue appeals and those with less than 1 hour remaining until the deadline are highlighted in red.

- Users can mark appeals as resolved, after which they are removed from the list of active appeals.

 

## Technologies

 

- Backend is implemented on the .NET platform using ASP.NET Core MVC(Model-View-Controller).

- The data type string was chosen for the Id in the Appeal model to generate a unique identifier for appeals in the form of a GUID.

- The sorting of appeals in descending order is implemented using LINQ.

- Frontend includes HTML, CSS, and JavaScript.

- Data is stored in memory, without using a database.
