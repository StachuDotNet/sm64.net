module SM64.Net.Views.Characters

open Feliz.ViewEngine

let view =
    Html.rawText
      """
      There are a number of characters in the game. Mario is a playable character.
      
      <ul>
        <li>Goombas</li>
        <li>Toad</li>
        <li>Princess Peach</li>
        <li>Bowser</li>
        <li>Chain Chomp</li>
        <li>Ukiki (the eel)</li>
      </ul>
      
      """