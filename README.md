

\# Student Management System



A C# console application built with .NET 9 to practice Object-Oriented Programming (OOP), clean code, and structured application design.



\## Features



\- Add, view, search, update, and delete students.

\- Prevent duplicate student IDs.

\- Validate student IDs and names.

\- Validate grades within the range of 0–100.

\- Validate gender selection.

\- Handle invalid user input.



\## Technologies



\- C#

\- .NET 9

\- Object-Oriented Programming (OOP)

\- Git and GitHub



\## Project Structure



```text

StudentManagement/

├── Models/

│   ├── Gender.cs

│   ├── Grade.cs

│   └── Student.cs

├── Services/

│   └── StudentService.cs

├── UI/

│   └── Menu.cs

├── Program.cs

├── StudentManagement.csproj

├── StudentManagement.sln

└── README.md

```



\## Design and Concepts



\- \*\*Models:\*\* Represent student data and related types.

\- \*\*Services:\*\* Contain the student management operations.

\- \*\*UI:\*\* Handles the console menu and user input.

\- \*\*Encapsulation:\*\* Keeps student management data and operations organized.

\- \*\*Separation of Concerns:\*\* Separates models, business operations, and user interaction.

\- \*\*Input Validation:\*\* Checks user input before processing operations.



\## Getting Started



\### Prerequisites



Install the \[.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0).



\### Run the Application



Clone the repository:



```bash

git clone https://github.com/Ahmed-Mattar11/StudentManagement\_C-.git

```



Navigate to the project directory:



```bash

cd StudentManagement\_C-

```



Run the application:



```bash

dotnet run

```



\## Current Limitations



\- Student data is stored in memory and is lost when the application closes.

\- The application uses a console-based interface.

\- No database integration is implemented yet.



\## Future Improvements



\- Integrate SQL Server for persistent data storage.

\- Use Entity Framework Core.

\- Build a RESTful API with ASP.NET Core.

\- Add unit tests.

\- Improve the application architecture as the project evolves.



\## Learning Goals



This project is part of my journey toward .NET Backend Development, with a focus on C#, OOP, application structure, CRUD operations, and input validation.



