module SM64.Net.Views.StandardCourse

open Feliz.ViewEngine

let view (courseAbbreviation: string) =
    Html.div [
        Html.text "There are 15 'core' stages that we call 'courses'"
        Html.h1 courseAbbreviation
    ]
    