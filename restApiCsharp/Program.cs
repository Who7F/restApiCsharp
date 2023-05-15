var app = WebApplication.Create();

app.MapGet("/people", () => new[]
{
    new Person("Sue"), new Person("Tom"), new Person("Em"),
});

app.MapGet("/tea", () => new[]
{
    new Tea("Builder"), new("Earl Grey, Hot")
});



app.Run();

record Person(string Name);
record Tea(string Name);
