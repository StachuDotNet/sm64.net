module SM64.Net.Views.BowserStages

open Feliz.ViewEngine

let view =
    """
    <h1>Bowser Stages</h1>
    <p>There are three Bowser Stages in SM64</p>
    <ul>
      <li>Bowser in the Dark World</li>
      <li>Bowser in the Fire Sea</li>
      <li>Bowser in the Sky</li>
    </ul>
    
    <h2>Bowser in the Dark World</h2>
    """
    |> Html.rawText