module SM64.Net.Views.StandardCourses

open Feliz.ViewEngine

let view  =
    Html.div [
        Html.text "There are 15 'core' stages that we call 'courses'"
        Html.ol [
            Html.li "Whomp's Fortress"
            Html.li "Big Boo's Haunt"
            Html.li "Cool Cool Mountain"
            Html.li ""
        ]    
    ]
    