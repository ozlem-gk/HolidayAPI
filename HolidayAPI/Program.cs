
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.WithOrigins("http://localhost:3000")  // Sadece localhost:3000'den gelen istekleri kabul et
              .AllowAnyMethod()                      // Herhangi bir HTTP metoduna izin verir
              .AllowAnyHeader();                     // Herhangi bir header'a izin verir
    });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");  // CORS middleware'ini burada kullanýn
app.UseRouting();
app.UseAuthorization(); 
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
