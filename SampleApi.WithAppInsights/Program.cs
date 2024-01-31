var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();

app.MapGet("/", () =>
{
    app.Logger.LogWarning("Get invoked.");
    return "Hello World!";
});

app.Run();