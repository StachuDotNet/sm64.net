module SM64.Net.Views.StandardCourse

open Feliz.ViewEngine

let view (courseAbbreviation: string) = 
    Html.div[
      Html.h1 courseAbbreviation
      Html.text "Here's a view for a specific 'standard course', out of the 15."
    ]