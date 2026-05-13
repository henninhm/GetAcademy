using Test_2.Models;

var builder = WebApplication.CreateBuilder(args);


    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    /* builder.Services.AddSwaggerGen(); */
    builder.Services.Add(new ServiceDescriptor(typeof(UserContext), new UserContext("Server=localhost;Database=test_db;Uid=admin;Pwd=admin;")));
    var app = builder.Build();

    /*
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }*/

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    /*builder.Services.AddControllersWithViews();

    var app = builder.Build();

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseRouting();

    app.UseAuthorization();

    app.MapStaticAssets();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
        .WithStaticAssets();

    */

    app.Run();
