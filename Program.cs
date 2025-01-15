var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuring CORS Policy for unrestricted access
//This piece of code swill allow any reequest from any domain to access our endpoint "Example.com"
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", policy => {
        policy.AllowAnyOrigin()     //Allows requests from any origin
              .AllowAnyMethod()     //Allows any HTTP request (Get, Post, Put, etc)
              .AllowAnyHeader();    //Allows any headers
    });
});

//Configuring Cors to be more restricted access
builder.Services.AddCors(options => {
    options.AddPolicy("AllowSome",
    policy => {
        policy.WithOrigins("http://localhost:3000")
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
