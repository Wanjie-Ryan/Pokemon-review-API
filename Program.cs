var builder = WebApplication.CreateBuilder(args);
//this line creates a new instance of the WebApplicationBuilder class, which is used to configure the web application.

// Add services to the container.

builder.Services.AddControllers();
//This line registers the controllers with the dependency injection container. Controllers handle incoming HTTP requests and produce responses.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//This line adds API explorer services to the dependency injection container. API explorer is used to generate documentation for the API endpoints.

builder.Services.AddSwaggerGen();
// This line adds Swagger generation services to the dependency injection container. Swagger is a tool that helps document and interact with the APIs.

var app = builder.Build();
//This line builds the web application using the configured services and settings.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//This block of code is used to configure additional middleware for the development environment. Here, it enables Swagger UI and Swagger JSON endpoints for API documentation.

app.UseHttpsRedirection();
//This middleware redirects HTTP requests to HTTPS. It's used to enforce secure communication.

app.UseAuthorization();
//his middleware configures authorization. It's used to handle authentication and authorization in the application

app.MapControllers();
//This line maps controllers to their respective routes. It's responsible for routing incoming HTTP requests to the appropriate controller actions.

app.Run();
//This method starts processing HTTP requests. It's the entry point for the application's request processing pipeline.
