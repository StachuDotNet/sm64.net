module SM64.Net.Views.Home

open Feliz.Bulma.ViewEngine
open Feliz.ViewEngine
open SM64.Net
    
let bracketLink path (text: string) = Html.span [
    Html.text " ["
    Html.a [
        prop.href path
        prop.text text
    ]
    Html.text "]"
]
    
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
                                    bracketLink SiteRoute.Plot.PrimaryPath "plot"
                                ]
                                Html.li [
                                    Html.text "core "
                                    bracketLink SiteRoute.Mechanics.PrimaryPath "mechanics"
                                ]
                                Html.li [
                                    Html.text "varied "
                                    bracketLink SiteRoute.Characters.PrimaryPath "characters"
                                ]
                                Html.li [
                                    Html.text "the "
                                    bracketLink SiteRoute.Castle.PrimaryPath "castle"
                                    Html.text ", its "
                                    bracketLink SiteRoute.Stages.PrimaryPath "stages"
                                    Html.text ", and their "
                                    bracketLink SiteRoute.Stars.PrimaryPath "stars"
                                ]
                            ]
                        ]
                    ]
                    
                    Html.li [
                        prop.children [
                            Html.text "the "
                            bracketLink SiteRoute.Speedrunning.PrimaryPath "speedrunning"
                            Html.text " of SM64"
                            
                            Html.ul [
                                Html.li [
                                    Html.text "world "
                                    bracketLink SiteRoute.Records.PrimaryPath "records"
                                    Html.text " and "
                                    bracketLink SiteRoute.Rankings.PrimaryPath "rankings"
                                    Html.text " of major and minor "
                                    bracketLink SiteRoute.Categories.PrimaryPath "categories"
                                ]
                                Html.li [
                                    Html.text "speedrunner "
                                    bracketLink SiteRoute.Profiles.PrimaryPath "profiles"
                                ]
                                Html.li [
                                    Html.text "a directory of "
                                    bracketLink SiteRoute.Strategies.PrimaryPath "strategies"
                                    Html.text " and "
                                    bracketLink SiteRoute.Routes.PrimaryPath "routes"
                                    Html.text " used in speedrunning"
                                ]
                                Html.li [
                                    Html.text "speedrunning "
                                    bracketLink SiteRoute.Competitions.PrimaryPath "competitions"
                                    Html.text " and "
                                    bracketLink SiteRoute.Challenges.PrimaryPath "competitions"
                                ]
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
                bracketLink SiteRoute.Contribute.PrimaryPath "Contributions"
                Html.text " are welcome. Contact "
                bracketLink "https://stachu.net" "me"
                Html.text "or create a GitHub issue to connect."
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