using _2_SERVICES;
using _2_SERVICES.Interfaces;
using _2_SERVICES.Services;
using AutoMapper;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(opt => opt.AddPolicy("PolicyName", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IApplicationBuilder, ApplicationBuilder>();

builder.Services.AddServices();
builder.Services.AddAutoMapper(typeof(Mapping));

//builder.Services.AddRepoDependencies();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<IChildService, ChildService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("PolicyName");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
