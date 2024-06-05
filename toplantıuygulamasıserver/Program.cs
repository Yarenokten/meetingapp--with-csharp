using toplantýuygulamasýserver.hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddControllers();
builder.Services.AddMvc();
var app = builder.Build();
app.MapControllers();
app.MapHub<kullanýcývetoplantýhub>("kullanicivetoplantibilgileri");
app.MapHub<chathub>("chathub");


app.Run();
