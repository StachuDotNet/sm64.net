open System.Threading
open System.Threading.Tasks
open FSharp.Control.Tasks
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection

open Giraffe

open SM64.Net
open SM64.Net.TwitchBot.Bot

let configureApp (app : IApplicationBuilder) =
    app.UseGiraffe RouteChooser.routeChooser

let configureServices (services : IServiceCollection) =
    services.AddGiraffe() |> ignore

type Test() =
    inherit BackgroundService()
    override this.ExecuteAsync (ct: CancellationToken) =
        let appConfig =
            (ConfigurationBuilder())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json")
                .AddEnvironmentVariables()
                .Build()
        
        let config: BotConfig =
            let twitchConfig = appConfig.GetSection("TwitchConfig")
            { TwitchCredentials =
                { UserName = twitchConfig.GetValue("UserName")
                  OAuthToken = twitchConfig.GetValue("OAuthToken") } }
        startTwitchBot config
        
        Task.Delay 100


[<EntryPoint>]
let main _ =
    
    Host.CreateDefaultBuilder()
        .ConfigureWebHostDefaults(
            fun webHostBuilder ->
                webHostBuilder
                    .Configure(configureApp)
                    .ConfigureServices(configureServices)
                    |> ignore)
        .ConfigureServices(fun z -> z.AddHostedService<Test>() |> ignore)
        .Build()
        .Run()
    0