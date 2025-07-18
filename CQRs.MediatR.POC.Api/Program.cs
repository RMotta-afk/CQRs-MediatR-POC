var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies
    (typeof(Program).Assembly)); // Register MediatR for this assembly.
builder.Services.AddApplication();
builder.Services.AddDomain();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();