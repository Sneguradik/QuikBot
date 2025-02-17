using GrpcWorker;
using GrpcWorker.Dto;
using GrpcWorker.Handlers;
using GrpcWorker.Services;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(opt=>
    opt.AddDefaultPolicy(policy => policy
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()));

builder.Services.AddControllers();

builder.Services.AddOpenApi("v1");
builder.Services.AddLogging();

builder.Services.AddHostedService<Worker>();

builder.Services.Configure<ConnectionDto>(builder.Configuration.GetSection("Connection"));
builder.Services.Configure<List<ClassesTradingDto>>(builder.Configuration.GetSection("Trading"));
builder.Services.Configure<TradingAccount>(builder.Configuration.GetSection("TradingAccount"));

builder.Services.AddMassTransit(x =>
{
    x.SetKebabCaseEndpointNameFormatter();
    x.AddConsumers(typeof(Program).Assembly);
    x.UsingInMemory((context, cfg) =>
    {
        cfg.ConfigureEndpoints(context);
    });
});

builder.Services.AddSingleton<ISocketService, SocketService>();
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<IOrderService, OrderService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapScalarApiReference(options =>
{
    options.WithTheme(ScalarTheme.Mars)
        .WithDarkMode(true)
        .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient)
        .WithDarkModeToggle(false);
});

app.Run();