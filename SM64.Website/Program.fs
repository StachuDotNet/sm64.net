open Feliz.ViewEngine
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Giraffe
open SM64.Website
open SM64.Website.Layouts
open SM64.Website.Views
    
let webApp =
    choose
      [ route "/ping"   >=> text "pong"
        
        route SiteRoute.Home.PrimaryPath >=> (Home.homeView |> layoutWithoutNav)
        
        // the game
        route SiteRoute.Game.PrimaryPath >=> (Html.text "the game (high level)" |> layoutWithNav)
        route SiteRoute.Plot.PrimaryPath >=> (Plot.plotView |> layoutWithNav)
        route SiteRoute.Mechanics.PrimaryPath >=> (Mechanics.mechanicsView  |> layoutWithNav)
        route SiteRoute.Castle.PrimaryPath >=> (Html.text "castle stuff" |> layoutWithNav)
        route SiteRoute.Stars.PrimaryPath >=> (Html.text "stars overview" |> layoutWithNav)
        route SiteRoute.Characters.PrimaryPath >=> (Html.text "characters overview" |> layoutWithNav)
        route SiteRoute.Stages.PrimaryPath >=> (Html.text "stages overview" |> layoutWithNav)
        
        // speedrunning and speedrunners
        route SiteRoute.Speedrunning.PrimaryPath >=> (Html.text "some people beat this game really fast" |> layoutWithNav)
        route SiteRoute.Records.PrimaryPath >=> (Html.text "records overview" |> layoutWithNav)
        route SiteRoute.Rankings.PrimaryPath >=> (Html.text "rankings overview" |> layoutWithNav)
        route SiteRoute.Categories.PrimaryPath >=> (Html.text "categories overview" |> layoutWithNav)
        route SiteRoute.Routes.PrimaryPath >=> (Html.text "routes overview" |> layoutWithNav)
        route SiteRoute.Profiles.PrimaryPath >=> (Html.text "profiles overview" |> layoutWithNav)
        route SiteRoute.Strategies.PrimaryPath >=> (Html.text "strategies overview" |> layoutWithNav)
        route SiteRoute.Competitions.PrimaryPath >=> (Html.text "competitions overview" |> layoutWithNav)
        route SiteRoute.Challenges.PrimaryPath >=> (Html.text "challenges overview" |> layoutWithNav)
      ]

let configureApp (app : IApplicationBuilder) =
    // Add Giraffe to the ASP.NET Core pipeline
    app.UseGiraffe webApp

let configureServices (services : IServiceCollection) =
    // Add Giraffe dependencies
    services.AddGiraffe() |> ignore

[<EntryPoint>]
let main _ =
    Host.CreateDefaultBuilder()
        .ConfigureWebHostDefaults(
            fun webHostBuilder ->
                webHostBuilder
                    .Configure(configureApp)
                    .ConfigureServices(configureServices)
                    |> ignore)
        .Build()
        .Run()
    0