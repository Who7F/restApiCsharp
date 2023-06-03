
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.Data.SqlClient;
//Add `Microsoft.Data.SqlClient` package

try
{
    SqlConnectionStringBuilder myBuilder = new SqlConnectionStringBuilder();
    myBuilder.DataSource = "localhost - Not telling";
    myBuilder.UserID = "SQLEXPRESS - Not telling";
    myBuilder.TrustServerCertificate = true;
    
    myBuilder.InitialCatalog = "TeaShop";
    Console.WriteLine(myBuilder.ConnectionString.ToString());//check string
    //using (SqlConnection connection = new SqlConnection(myBuilder.ConnectionString))
}
catch (SqlException e) 
{
    Console.WriteLine(e.ToString());
}



var app = WebApplication.Create();

app.MapGet("/people", () => new[]
{
    new Person("Sue"), new Person("Tom"), new Person("Em"),
});

app.MapGet("/tea", () => new[]
{
    new Tea("Builder"), new("Earl Grey, Hot")
});

app.MapDelete("/todo", () => { });

app.MapPost("/todo", () => { });

app.MapPut("/todo", () => { });



app.Run();

record Person(string Name);
record Tea(string Name);
