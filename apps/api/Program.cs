using AngularDotnetDemo.Core.Dtos;
using AngularDotnetDemo.Core.Entities;
using AngularDotnetDemo.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddProblemDetails();

builder.Services.AddDbContext<EventDbContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/Events/{id:long}", async (long id, EventDbContext context) =>
  // just for testing purpose
  await context.Events.FindAsync(id)
  is Event @event
  ? Results.Ok(new EventDto(@event))
  : Results.NotFound()
)
  .WithName("GetEventById")
  .Produces(StatusCodes.Status404NotFound)
  .Produces<EventDto>(StatusCodes.Status200OK)
  .WithOpenApi();

app.Run();
