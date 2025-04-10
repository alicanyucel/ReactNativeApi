using Microsoft.EntityFrameworkCore;
using ReactNativeApi.Context;
using ReactNativeApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Swagger servisini ekle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#region Table 1 
app.MapPost("/api/tableone", async (TableOne input, AppDbContext db) =>
{
    db.TableOnes.Add(input);
    await db.SaveChangesAsync();
    return Results.Created($"/api/tableone/{input.Id}", input);
});

app.MapGet("/api/tableone", async (AppDbContext db) =>
    Results.Ok(await db.TableOnes.ToListAsync()));

app.MapGet("/api/tableone/{id}", async (int id, AppDbContext db) =>
    await db.TableOnes.FindAsync(id) is TableOne found
        ? Results.Ok(found)
        : Results.NotFound());
#endregion

#region Table 2
app.MapPost("/api/tabletwo", async (TableTwo input, AppDbContext db) =>
{
    db.TableTwos.Add(input);
    await db.SaveChangesAsync();
    return Results.Created($"/api/tabletwo/{input.Id}", input);
});

app.MapGet("/api/tabletwo", async (AppDbContext db) =>
    Results.Ok(await db.TableTwos.ToListAsync()));

app.MapGet("/api/tabletwo/{id}", async (int id, AppDbContext db) =>
    await db.TableTwos.FindAsync(id) is TableTwo found
        ? Results.Ok(found)
        : Results.NotFound());
#endregion

#region Table 3 
app.MapPost("/api/tablethree", async (TableThree input, AppDbContext db) =>
{
    db.TableThrees.Add(input);
    await db.SaveChangesAsync();
    return Results.Created($"/api/tablethree/{input.Id}", input);
});

app.MapGet("/api/tablethree", async (AppDbContext db) =>
    Results.Ok(await db.TableThrees
        .Include(t => t.UygunsuzlukTespitListesi)
        .ToListAsync()));

app.MapGet("/api/tablethree/{id}", async (int id, AppDbContext db) =>
    await db.TableThrees
        .Include(t => t.UygunsuzlukTespitListesi)
        .FirstOrDefaultAsync(t => t.Id == id) is TableThree found
        ? Results.Ok(found)
        : Results.NotFound());
#endregion

app.Run();
