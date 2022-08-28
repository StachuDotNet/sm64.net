module SM64.Net.Views.Castle

open Feliz.ViewEngine

let view =
    """
    <h1>Peach's Castle</h1>
    <p>
      All of Super Mario 64 gameplay exists within Peach's castle and its grounds (land).
      The castle has [4 levels](), as well as the [exterior grounds]().
    </p>
    
    <h2>The Four Levels</h2>
    
    <h3>The First Level</h3>
    <p>This is where Mario initially enters the castle. It features:</p>
    <ul>
      <li>
        Many early stages:
        <ul>
          <li>Bob-Omb's Battlefield</li>
          <li>Whomp's Fortress</li>
          <li>Cool Cool Mountain</li>
          <li>Jolly Roger Bay</li>
          <li>Big Boo's Haunt</li>
        </ul>
      </li>
      <li>The door, hallway, and entrance to the first Bowser stage, [???]()</li>
    </ul>
    <p>CCM, JRB</p>
    <p>bowser 1...</p>
    
    <h3>Basement</h3>
    
    <h3>Upstairs</h3>
    <h4>The Courtyard</h4>
    <p></p>
    
    <h3>"Tippy" - the tip-top of the castle</h3>
    
    <h2>The courtyard</h2>
    
    """
    |> Html.rawText 