module SM64.Net.Views.Speedrunning.Categories

open Feliz.ViewEngine

let view =
    """
    <h1>speedrunning categories</h1>
    <p>
      There are many categories to speedrunning SM64.
      The community generally focuses on a few select categories, but there are many additional categories worth
      checking out!
    </p>
    
    <h2>Main Categories</h2>
    <p>These are the categories that the majority of speedrunners focus on</p>
    <ul>
      <li>120-star</li>
      <li>70-star</li>
      <li>16-star</li>
      <li>1-star</li>
      <li>0-Star</li>
    </ul>
        
    <h3>Additional Categories</h3>
    <p>
      These are less focused on, but still legitimate categories!
    </p>
    <ul>
      <li>All-Coins</li>
      <li>All-Signs</li>
    </ul>
    """
    |> Html.rawText