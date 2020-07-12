module SM64.Net.Views.Contribute

open Feliz.ViewEngine

let contributeView =
    Html.div [
        Html.text "If you care about Super Mario 64 and would like to contribute in some way to this project, I can use help from a variety of different backgrounds:"
        Html.ul [
            Html.li "SM64 domain experts open to serious 1:1 interviews"
            Html.li "software development"
            Html.li "art/graphics"
            Html.li "content help"
            Html.li "connections to the TAS world"
            Html.li "connections to non-English-speaking SM64 communities"
            Html.li "twitch/youtube assistance"
        ]
    ]