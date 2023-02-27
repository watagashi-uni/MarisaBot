﻿using Marisa.Backend.Mirai;
using Marisa.BotDriver.DI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using NuGet.Packaging;

namespace Marisa.StartUp;

public static class Program
{
    private static async Task Main(string[] args)
    {
        // asp dotnet
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddRange(MiraiBackend.Config(Plugin.Utils.Assembly()));
        builder.Services.ConfigLogger();
        builder.WebHost.UseUrls("http://localhost:14311");

        var app = builder.Build();
        app.UseSwagger();
        app.UseSwaggerUI();
        app.MapControllers();
        app.UseDeveloperExceptionPage();
        
        app.Use((context, next) =>
        {
            context.Response.Headers["Access-Control-Allow-Origin"] = "*";
            return next.Invoke();
        });

        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "wwwroot")),
            RequestPath  = ""
        });

        app.Services.GetService<DictionaryProvider>()!
            .Add("QQ", long.Parse(args[1]))
            .Add("ServerAddress", args[0])
            .Add("AuthKey", args[2]);

        app.MapGet("/", ctx =>
        {
            ctx.Response.Redirect("/index.html");
            return Task.CompletedTask;
        });

        // run
        await Task.WhenAll(app.RunAsync(), app.Services.GetService<MiraiBackend>()!.Invoke());
    }
}