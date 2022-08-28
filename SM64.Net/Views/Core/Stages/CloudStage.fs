module SM64.Net.Views.Core.Stages.CloudStage

open Feliz.ViewEngine

let view = 
    Html.div[
      Html.h1 [
        Html.text "Cloud stage"
        Html.text "secret star location"
      ]
      
      Html.div [
        Html.text "Stuff to talk about (TODOs)"
        
        Html.ul [
          Html.li "location and access"
          Html.li "it's in the [tip-top of the castle](tippy)"
          
          Html.li "structure of the course"
          Html.li "intended route"
          
          Html.li "8 red coins"
          
          Html.li "Requirements for entry"
          Html.ul [
            Html.li "Star count (the door to the hallway)"
            Html.li "how to get around it (with [BLJ]())"
          ]
          
          Html.li "number of coins. the fact that it's not really tracked"
          
          Html.li "speedrunning stuff"
          Html.ul [
          ]
        ]
      ]
    ]