using StudentsPublisherApi.Models;
using StudentsPublisherApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<DatabaseSettings>(
    builder.Configuration.GetSection("StudentsDatabase"));
builder.Services.AddSingleton<DozentService>();
builder.Services.AddSingleton<StudentsService>();
builder.Services.AddSingleton<KursService>();
builder.Services.AddSingleton<KurseLernendeService>();
builder.Services.AddSingleton<LehrbetriebService>();
builder.Services.AddSingleton<LehrbetriebLernendeService>();
builder.Services.AddSingleton<LandService>();

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins");
app.UseAuthorization();
app.MapControllers();
app.Run();
