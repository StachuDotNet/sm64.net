module SM64.Net.Views.Tools.Index

open Feliz.ViewEngine
open SM64.Net

let view =
    Html.div [
        Html.h2 "Tools (hardware and software) that aid in speedrunning"

        Html.div [        
            Html.h3 "Hardware"
        ]
        
        Html.div [
            Html.h3 "Emulator Set-up"
        ]
        
        Html.div [
            Html.h3 "Speedrunning"
            
            Html.h4 "software"
            Html.p [
                Html.text "The "
                Html.a [
                    prop.href SiteRoute.Usamune.Path
                    prop.text "Usamune"
                ]
                Html.text " ROM is ideal for practicing SM64 speedrunning."
            ]
            
            Html.h4 "hardware"
        ]
    ]