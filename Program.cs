var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();
//http://localhost:8000/swagger/index.html

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
