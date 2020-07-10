module SM64.Website.Layout

open Feliz.Bulma.ViewEngine
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
     |> Giraffe.ResponseWriters.htmlString