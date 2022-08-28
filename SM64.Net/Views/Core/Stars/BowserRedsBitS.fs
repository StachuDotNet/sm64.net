module SM64.Net.Views.Core.Stars.BowserRedsBitS


open Feliz.ViewEngine

let view = 
    Html.div[
      Html.h1 [
        Html.text "Bowser in the Sky"
        Html.small "(BitS)"
      ]
      
      Html.div [
        Html.text "Stuff to talk about (TODOs)"
        
        Html.ul [
          Html.li "This is the third/final Bowser stage"
          Html.li "it's in the [tip-top of the castle](tippy)"
          
          Html.li "structure of the course"
          Html.li "intended route"
          
          Html.li "8 red coins"
          Html.li "Enemies"
          Html.li "goombas"
          Html.li "Cycles"
          
          Html.li "Requirements for entry"
          Html.ul [
            Html.li "Star count (the door to the hallway)"
            Html.li "how to get around it (with [BLJ]())"
          ]
          
          Html.li "number of coins. the fact that it's not really tracked"
          
          Html.li "speedrunning stuff"
          Html.ul [
            Html.li "route with reds"
            Html.li "route without reds"
            Html.li "that huge jump"
          ]
        ]
      ]
    ]