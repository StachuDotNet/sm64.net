module SM64.Net.Views.Core.Stars.BowserRedsBitFS

open Feliz.ViewEngine

let view = 
    Html.div[
      Html.h1 [
        Html.text "Bowser in the Fire Sea"
        Html.small "(BitFS)"
      ]
      
      Html.div [
        Html.text "Stuff to talk about (TODOs)"
        
        Html.ul [
          Html.li "This is the second Bowser stage"
          Html.li "it's in the basement"
          
          Html.li "8 red coins"
          Html.li "Enemies"
          Html.li "goombas"
          Html.li "Cycles"
          
          Html.li "Requirements for entry"
          Html.ul [
            Html.li "Star count (the door to the hallway)"
            Html.li "DDD sub"
            Html.li "how to get around both of these with SBLJs"
          ]
          
          Html.li "number of coins. the fact that it's not really tracked"
          
          Html.li "speedrunning stuff"
          Html.ul [
            Html.li "route with reds"
            Html.li "route without reds"
          ]
        ]
      ]
    ]