# To-Do List Blazor

This is a **To-Do List** project developed with **Blazor Server** and **Entity Framework Core**.

## Technologies Used

- Blazor Server
- .NET 8.0
- Entity Framework Core
- SQL Server

## Features

- Create new tasks
- List existing tasks
- Edit tasks
- View task details
- Delete tasks

## Installation and Setup

### 1. Clone the repository
```sh
git clone https://github.com/Gabriel-Steps/To-Do-List-Basic-Blazor
cd To-Do-List-Basic-Blazor
```

### 2. Configure the database
Make sure you have a running SQL Server database. Update the **connection string** in the `appsettings.json` file:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=ToDoListDb;Trusted_Connection=True;"
}
```

### 3. Apply Migrations and Update the Database
If you haven't created migrations yet, run:
```sh
dotnet ef migrations add InitialCreate
```

To apply migrations and create the database:
```sh
dotnet ef database update
```

### 4. Run the project
```sh
dotnet run
```
The project will be available at: `https://localhost:5001/`.

## Project Structure

```sh
ToDoListBlazor/
│── Connected Services/
│── Dependencies/
│── Properties/
│── wwwroot/
│── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   ├── NavMenu.razor
│   ├── Pages/
│   │   ├── TarefaPages/
│   │   │   ├── Error.razor
│   │   │   ├── Home.razor
│   │   │   ├── _Imports.razor
│   │   ├── App.razor
│   │   ├── Routes.razor
│── Context/
│   ├── ListaDeTarefasContext.cs
│── Migrations/
│   ├── 20250304172549_ToDoListMig.cs
│   ├── ListaDeTarefasContextModelSnapshot.cs
│── Models/
│   ├── Tarefa.cs
│── appsettings.json
│── Program.cs
```

## Contribution
If you want to contribute to the project, feel free to open a **Pull Request** or report issues in the **Issues** tab.

## License
This project is licensed under the MIT License. Feel free to use and modify it!

