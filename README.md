# 📘 GraphQL Demo with ASP.NET Core & HotChocolate

This is a simple project demonstrating how to use **GraphQL** with **ASP.NET Core** and the **HotChocolate** library. The app allows querying a list of students from a SQL Server database.

---

## ✅ Requirements

- [.NET 7.0 SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server installed
- Visual Studio or VS Code
- Install dotnet add package HotChocolate.AspNetCore (ex: 13.8.1)
---

## Query
```
query {
  students {
    id
    fullName
    email
    address
  }
}
```

## Mutation 
### Add student
```
mutation {
  addStudent(input: {
    fullName: "John Doe",
    email: "john@example.com",
    address: "123 Main St"
  }) {
    id
    fullName
    email
    address
  }
}
```

### Update student
```
mutation {
  updateStudent(input: {
    id: 1,
    fullName: "Jane Updated",
    email: "jane.updated@example.com",
    address: "456 New Address"
  }) {
    id
    fullName
    email
    address
  }
}
```

### Delete student
```
mutation {
  deleteStudent(id: 1)
}

```