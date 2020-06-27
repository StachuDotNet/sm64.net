namespace SM64.Stars

open System
open SM64.Meta

type ToadStar =
    | HMCToad
    | UpstairsToad
    | TippyToad
    
type ToadStarInfo =
    { Toad: Toad
      NumberOfTextBoxes: int }

module ToadStar = 

    let getToadStarInfo toadStar =
        match toadStar with
        | HMCToad ->
            { Toad = Toad.HMCToad
              NumberOfTextBoxes = NotImplementedException("haven't counted") |> raise  } 
        | UpstairsToad ->
            { Toad = Toad.UpstairsToad
              NumberOfTextBoxes = NotImplementedException("haven't counted") |> raise  } 
        | TippyToad ->
            { Toad = Toad.TippyToad
              NumberOfTextBoxes = NotImplementedException("haven't counted") |> raise  }