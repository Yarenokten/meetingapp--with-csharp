using toplant�uygulamas�server.hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddControllers();
builder.Services.AddMvc();
var app = builder.Build();
app.MapControllers();
app.MapHub<kullan�c�vetoplant�hub>("kullanicivetoplantibilgileri");
app.MapHub<chathub>("chathub");


app.Run();
