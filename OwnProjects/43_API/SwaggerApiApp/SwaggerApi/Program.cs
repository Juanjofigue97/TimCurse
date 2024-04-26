using Microsoft.OpenApi.Models;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opts =>
{
    opts.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Our User API (This is our Title)",
        Description = "This is description About API",
        TermsOfService = new Uri("https://jjfnportfolio.azurewebsites.net"),
        Contact = new OpenApiContact
        {
            Name = "Juan",
            Url = new Uri("https://jjfnportfolio.azurewebsites.net")
        },
        License = new OpenApiLicense 
        { 
            Name = "Cool License (License Name)",
            Url = new Uri("https://jjfnportfolio.azurewebsites.net")
        }
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    opts.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory,xmlFile));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(opts =>
    {
        // opts.SerializeAsV2 = true;
    });
    app.UseSwaggerUI(opts =>
    {
        opts.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        opts.RoutePrefix = string.Empty;
        opts.InjectStylesheet("css/theme-outline.css");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
