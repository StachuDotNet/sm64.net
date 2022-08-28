module SM64.Net.Views.AllStars

open Feliz.ViewEngine

let view =
  """
  <h2>The Stars</h2>
  <p>There are 120 unique obtainable stars in Super Mario 64.</p>
  <ul>
    <li>105? of them come from courses (7 in each of the 15 [courses]())</li>
    <li>3 of them from [bowser stages]()</li>
    <li>2 [given away by Toad]()</li>
    <li>10 of them from other [secret stages]()</li>
    <li>
  </ul>
  """
  |> Html.rawText