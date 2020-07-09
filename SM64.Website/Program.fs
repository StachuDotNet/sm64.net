open System
open Feliz.Bulma.ViewEngine
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Giraffe
open Feliz.ViewEngine

let layout content =
    Html.html [
        prop.children [
            Html.head [
                Html.link [
                    prop.href "https://cdn.jsdelivr.net/npm/bulma@0.9.0/css/bulma.css"
                    prop.rel "stylesheet"
                ]
            ]
            Html.body [
                Bulma.container [
                    prop.children content
                ]
            ]
        ]
    ]
    |> Render.htmlView

let bulmaIndexView =
        Bulma.columns [
            Bulma.column [
                column.isOffset3
                column.is6
                prop.children [
                    Bulma.title.h1 "sm64.net"
                    
                    Bulma.content [
                        content.isMedium
                        
                        prop.children [
                            Bulma.box [
                                Html.text "This is a website centered around:"
                                Html.ul [
                                    Html.li [
                                        prop.text "Super Mario 64, the core game itself"
                                        prop.children [
                                            Html.ul [
                                                Html.li "the love [story]"
                                                Html.li "core [mechanics]"
                                                Html.li "varied [characters]"
                                                Html.li "the [castle], its [stages], and their [stars]"
                                            ]
                                        ]
                                    ]
                                    
                                    Html.li [
                                        prop.text "the [speedrunning] of SM64, [as a sport]"
                                        prop.children [
                                            Html.ul [
                                                Html.li "world [records] and [rankings] of major and minor [categories]"
                                                Html.li "speedrunner [profiles]"
                                                Html.li "a directory of [strategies and routes] used in speedrunning"
                                                Html.li "speedrunning [competitions] and [challenges]"
                                                Html.li "[a trainer] to help you improve your speedrunning"
                                                Html.li "a directory of software [tools]"
                                            ]
                                        ]                                        
                                    ]
                                    Html.li "a software development-focused [log] of how this site is being built"
                                ]
                            ]
                        ]
                    ]
                    
                    Bulma.content [
                        content.isSmall
                        prop.children [
                            Html.p "This website is currently proof-of-concept / work-in-progress."
                            Html.p [
                                prop.children [
                                    Html.text "Development is often streamed "
                                    Html.a [
                                        prop.href "https://twitch.tv/stachudotent"
                                        prop.text "on Twitch"
                                    ]
                                    Html.text " and source code available "
                                    Html.a [
                                        prop.href "https://github.com/stachudotnet/SM64.net"
                                        prop.text "on GitHub"
                                    ]
                                    Html.text "."
                                ]
                            ]
                            
                            Html.p [
                                prop.text "Contributions welcome! For now, please just reach out to "
                                prop.children [
                                    Html.a [
                                        prop.href "https://stachu.net"
                                        prop.text "me"
                                    ]
                                ]
                                prop.text "."
                            ]
                        ]
                    ]
                ]
            ]
        ]
    
let webApp =
    choose
      [ route "/ping"   >=> text "pong"
        route "/"       >=> (bulmaIndexView |> layout |> Giraffe.ResponseWriters.htmlString)
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