var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllerUtility();

services.AddEndpointsApiExplorer();

services.AddSwaggerGen();

using (var app = builder.Build())
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.MapControllers();

    app.Run();
}