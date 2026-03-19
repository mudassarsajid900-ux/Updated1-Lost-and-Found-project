using GAC.API.Extensions;
using GAC.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiServices(builder.Configuration);

builder.Services.AddExceptionHandler<GenericExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

// Middleware
await app.UseApiPipeline(); 

app.Run();
