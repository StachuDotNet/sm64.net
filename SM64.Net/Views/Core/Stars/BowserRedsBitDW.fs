module SM64.Net.Views.Core.Stars.BowserRedsBitDW

open Feliz.ViewEngine

let view = 
    Html.div[
      Html.h1 [
        Html.text "Bowser in the Dark World"
        Html.small "(BitDW)"
      ]
      
      Html.div [
        Html.text "Stuff to talk about (TODOs)"
        
        Html.ul [
          Html.li "This is the first Bowser stage"
          
          Html.li "8 red coins"
          Html.li "Enemies"
          Html.li "goombas"
          Html.li "Cycles"
          Html.li "minimum star count"
          Html.li "how to get around the minimum star count"
          Html.li "number of coins. the fact that it's not really tracked"
          
          Html.li "speedrunning stuff"
          Html.ul [
            Html.li "route with reds"
            Html.li "route without reds"
          ]
        ]
      ]
    ]