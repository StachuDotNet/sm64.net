module SM64.Net.Views.Home

open Feliz.Bulma.ViewEngine
open Feliz.ViewEngine

open SM64.Net
open SM64.Net.Utils
    
let private contents = [
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
                                Html.li [
                                    Html.text "the "
                                    bracketLink SiteRoute.Plot.Path "plot"
                                ]
                                Html.li [
                                    Html.text "core "
                                    bracketLink SiteRoute.Mechanics.Path "mechanics"
                                ]
                                Html.li [
                                    Html.text "varied "
                                    bracketLink SiteRoute.Characters.Path "characters"
                                ]
                                Html.li [
                                    Html.text "the "
                                    bracketLink SiteRoute.Castle.Path "castle"
                                    Html.text ", its "
                                    bracketLink SiteRoute.Stages.Path "stages"
                                    Html.text ", and their "
                                    bracketLink SiteRoute.AllStars.Path "stars"
                                ]
                            ]
                        ]
                    ]
                    
                    Html.li [
                        prop.children [
                            Html.text "the "
                            bracketLink SiteRoute.Speedrunning.Path "speedrunning"
                            Html.text " of SM64"
                            
                            Html.ul [
                                Html.li [
                                    Html.text "world "
                                    bracketLink SiteRoute.Records.Path "records"
                                    Html.text " and "
                                    bracketLink SiteRoute.Rankings.Path "rankings"
                                    Html.text " of major and minor "
                                    bracketLink SiteRoute.Categories.Path "categories"
                                ]
                                Html.li [
                                    Html.text "speedrunner "
                                    bracketLink SiteRoute.Speedrunners.Path "profiles"
                                ]
                                Html.li [
                                    Html.text "a directory of "
                                    bracketLink SiteRoute.Strategies.Path "strategies"
                                    Html.text " and "
                                    bracketLink SiteRoute.Routes.Path "routes"
                                    Html.text " used in speedrunning"
                                ]
                                Html.li [
                                    Html.text "speedrunning "
                                    bracketLink SiteRoute.Competitions.Path "competitions"
                                    Html.text " and "
                                    bracketLink SiteRoute.Challenges.Path "challenges"
                                ]
                            ]
                        ]                                        
                    ]
                    
                    Html.li "the world of [ROM Hacks], variants of the original Super Mario 64 game"
                    
                    Html.li [
                        Html.text "a directory of software "
                        bracketLink SiteRoute.Tools.Path "tools"
                        Html.text " to assist with speedrunning"
                        
                        Html.ul [
                            Html.li "[a trainer] to help you improve your speedrunning"
                            Html.li [
                                bracketLink SiteRoute.TwitchBot.Path "a  Twitch bot"
                                Html.text "  you can use to provide helpful '!sm64 ___' commands"
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
                        prop.href "https://github.com/stachudotnet/sm64.net"
                        prop.text "on GitHub"
                    ]
                    Html.text "."
                ]
            ]
            
            Html.p [
                bracketLink SiteRoute.Contribute.Path "Contributions"
                Html.text " are welcome."
            ]
        ]
    ]
]

let homeView =
    Bulma.columns [
        columns.isDesktop
        columns.isCentered
        prop.children [
            Bulma.column [
                column.isTwoThirdsDesktop
                prop.children contents 
            ]
        ]
    ]