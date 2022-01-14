module SM64.Net.Utils

open Feliz.ViewEngine

/// helper that formats a link [like this] 
let bracketLink path (text: string) = Html.span [
    Html.text " ["
    Html.a [
        prop.href path
        prop.text text
    ]
    Html.text "]"
]