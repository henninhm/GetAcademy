using Test_3.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.Add(new ServiceDescriptor(typeof(UserContext), 
    new UserContext("Server=localhost;Port=3306;Database=revrything;Uid=root;Pwd=Born to Run 1975;")));
builder.Services.Add(new ServiceDescriptor(typeof(ProductContext),
    new ProductContext("Server=localhost;Port=3306;Database=revrything;Uid=root;Pwd=Born to Run 1975;")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();