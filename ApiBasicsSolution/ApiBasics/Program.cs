
// Kesteral web server (WebApplication)
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Above this ine is configuring the services usedin the app.
var app = builder.Build();
// After this line is configuring the HTTP pipeline - how individual requests and responses are handled.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Generate the open api spec.
    app.UseSwaggerUI(); // Use the swagger ui web page to show it.
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Create a route table for all controllers in the app.
// Uses the attributes decorating the controller classes to figure this out.
app.MapControllers();

app.Run(); // This is blocking.
