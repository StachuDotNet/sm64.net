module SM64.Website.Layouts

open Feliz.Bulma.ViewEngine
open Feliz.ViewEngine

let baseLayout content =
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
     |> Giraffe.ResponseWriters.htmlString

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
              prop.href SiteRoute.Home.PrimaryPath
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
                    prop.href SiteRoute.Home.PrimaryPath
                ]
                Html.div [
                    prop.classes ["navbar-item"; "has-dropdown"; "is-hoverable"]
                    prop.children [
                       Html.a [
                           prop.classes ["navbar-link"]
                           prop.text "The Game"
                           prop.href SiteRoute.Game.PrimaryPath
                       ]
                       Html.div [
                           prop.classes ["navbar-dropdown"]
                           prop.children [
                                navLink "The Game" SiteRoute.Game.PrimaryPath
                                Html.hr [prop.classes ["navbar-divider"]]
                                navLink "Plot" SiteRoute.Plot.PrimaryPath
                                navLink "Mechanics" SiteRoute.Mechanics.PrimaryPath
                                navLink "Castle" SiteRoute.Castle.PrimaryPath
                                navLink "Characters" SiteRoute.Characters.PrimaryPath
                                navLink "Stages" SiteRoute.Stages.PrimaryPath
                                navLink "Stars" SiteRoute.Stars.PrimaryPath
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
                           prop.href SiteRoute.Speedrunning.PrimaryPath
                       ]
                       Html.div [
                           prop.classes ["navbar-dropdown"]
                           prop.children [
                                navLink "Speedrunning" SiteRoute.Speedrunning.PrimaryPath
                                Html.hr [prop.classes ["navbar-divider"]]
                                navLink "Records" SiteRoute.Records.PrimaryPath
                                navLink "Rankings" SiteRoute.Rankings.PrimaryPath
                                navLink "Categories" SiteRoute.Categories.PrimaryPath
                                navLink "Routes" SiteRoute.Routes.PrimaryPath
                                navLink "Profiles" SiteRoute.Profiles.PrimaryPath
                                navLink "Strategies" SiteRoute.Strategies.PrimaryPath
                                navLink "Competitions" SiteRoute.Competitions.PrimaryPath
                                navLink "Challenges" SiteRoute.Challenges.PrimaryPath
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
                    prop.children (if shouldDisplayNav then [nav; content] else [content]) 
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