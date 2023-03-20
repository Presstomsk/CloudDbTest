using CloudDbTestSPD011.Database;
using CloudDbTestSPD011.Model;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(); 

var app = builder.Build();

app.MapGet("/ping", () => "pong");


app.MapGet("/all", async (ApplicationDbContext db) => await db.Students.AsNoTracking().ToListAsync());

app.MapGet("/get/{id:int}", async (ApplicationDbContext db, int id) => await db.Students
                                                                .SingleOrDefaultAsync(student => student.Id == id));

app.MapPost("/add", async (Student data, ApplicationDbContext db) =>
{
    db.Add(data);
    await db.SaveChangesAsync();
    return data;
});

app.MapPost("/update", async (Student data, ApplicationDbContext db) =>
{
    db.Update(data);
    await db.SaveChangesAsync();
    return data;
});

app.MapPost("/delete", async (DTO dto, ApplicationDbContext db) =>
{
    var student = await db.Students.SingleOrDefaultAsync(student => student.Id == dto.Id);

    if (student == null) return null;

    db.Remove(student);
    await db.SaveChangesAsync();
    return student;
});


app.Run();


