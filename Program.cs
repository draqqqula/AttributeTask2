// Создать атрибут, который будет валидировать на null для ссылочных и nullable типов, и на default для value типов
// Т.е. не валидные кейсы:
//
// class == null
//
// int = 0
//
// int? = null
//
// string = ""
//
// Для прохождения тестов повесить атрибут на все поля модели TestDto
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();

public partial class Program { }