module SM64.Net.Views.BowserStage

open Feliz.ViewEngine


let view (abbreviation: string) =
    Html.h2 ("Bowser Stage: " + abbreviation)