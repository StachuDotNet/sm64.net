module SM64.Website.Views

open Feliz.Bulma.ViewEngine
open Feliz.ViewEngine
    
let contents = [
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
            
            Html.p "Contributions will be welcome once the site is a bit more settled!"
        ]
    ]
]

let bulmaIndexView =
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