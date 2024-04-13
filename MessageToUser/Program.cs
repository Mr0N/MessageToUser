using MessageToUser.Interface;
using MessageToUser.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IWork, Work>();
var app = builder.Build();
app.Run();