module SM64.Net.Layouts

open Feliz.Bulma.ViewEngine
open Feliz.ViewEngine

let navLink (text: string) path =
    Html.a [
        prop.classes ["navbar-item"]
        prop.text text
        prop.href path
    ]

let nav =
  Bulma.navbar [
    prop.ariaLabel "main navigation"
    prop.role "navigation"
    prop.children [
      Html.div [
        prop.classes ["navbar-brand"]
        prop.children [
          Html.a [
              prop.classes ["navbar-item"]
              prop.href SiteRoute.Home.Path
              prop.children [
                  Bulma.title.h1 "sm64.net"
              ]
          ]
          Html.a [
              prop.role "button"
              prop.classes ["navbar-burger"; "burger"]
              prop.ariaLabel "menu"
              prop.ariaExpanded false
              prop.custom("data-target","navbarBasicExample")
              prop.children (Html.span [ prop.ariaHidden true ] |> Seq.replicate 3) 
          ]
        ]
      ]
      
      Bulma.navbarMenu [
        Html.div [
            prop.classes ["navbar-end"]
            prop.children [
                Html.a [
                    prop.classes ["navbar-item"]
                    prop.text "?"
                    prop.href SiteRoute.Home.Path
                ]
                Html.div [
                    prop.classes ["navbar-item"; "has-dropdown"; "is-hoverable"]
                    prop.children [
                       Html.a [
                           prop.classes ["navbar-link"]
                           prop.text "The Game"
                           prop.href SiteRoute.Game.Path
                       ]
                       Html.div [
                           prop.classes ["navbar-dropdown"]
                           prop.children [
                                navLink "The Game" SiteRoute.Game.Path
                                Html.hr [prop.classes ["navbar-divider"]]
                                navLink "Plot" SiteRoute.Plot.Path
                                navLink "Mechanics" SiteRoute.Mechanics.Path
                                navLink "Castle" SiteRoute.Castle.Path
                                navLink "Characters" SiteRoute.Characters.Path
                                navLink "Stages" SiteRoute.Stages.Path
                                navLink "Stars" SiteRoute.AllStars.Path
                           ]
                       ]
                    ]
                ]
                Html.div [
                    prop.classes ["navbar-item"; "has-dropdown"; "is-hoverable"]
                    prop.children [
                       Html.a [
                           prop.classes ["navbar-link"]
                           prop.text "Speedrunning"
                           prop.href SiteRoute.Speedrunning.Path
                       ]
                       Html.div [
                           prop.classes ["navbar-dropdown"]
                           prop.children [
                                navLink "Speedrunning" SiteRoute.Speedrunning.Path
                                Html.hr [prop.classes ["navbar-divider"]]
                                navLink "Records" SiteRoute.Records.Path
                                navLink "Rankings" SiteRoute.Rankings.Path
                                navLink "Categories" SiteRoute.Categories.Path
                                navLink "Routes" SiteRoute.Routes.Path
                                navLink "Speedrunners" SiteRoute.Speedrunners.Path
                                navLink "Strategies" SiteRoute.Strategies.Path
                                navLink "Competitions" SiteRoute.Competitions.Path
                                navLink "Challenges" SiteRoute.Challenges.Path
                           ]
                       ]
                    ]
                ]
                Html.div [
                    prop.classes ["navbar-item"; "has-dropdown"; "is-hoverable"]
                    prop.children [
                       Html.a [
                           prop.classes ["navbar-link"]
                           prop.text "Tools"
                           prop.href SiteRoute.Tools.Path
                       ]
                       Html.div [
                           prop.classes ["navbar-dropdown"]
                           prop.children [
                                navLink "Tools" SiteRoute.Tools.Path
                                Html.hr [prop.classes ["navbar-divider"]]
                                navLink "Usamune" SiteRoute.Usamune.Path
                                navLink "Twitch Bot" SiteRoute.TwitchBot.Path
                           ]
                       ]
                    ]
                ]
            ]
        ]
      ]
    ] 
  ]

let layout shouldDisplayNav content =
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
                    if shouldDisplayNav then
                        yield! [
                            nav
                            Bulma.content [ prop.children [content] ]
                        ]
                    else
                        yield! [content]
                ]
            ]
        ]
    ]
    |> Render.htmlView
    |> Giraffe.ResponseWriters.htmlString
     
let layoutWithoutNav content =
    layout false content

let layoutWithNav content =
    layout true content