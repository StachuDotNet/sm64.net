namespace SM64.Stars

open System
open SM64.Courses

type SecretStageStar =
    | WingMarioOverTheRainbow
    | PrincessSlide1
    | PrincessSlide2
    
type SecretStageStarInfo =
    { Name: string
      Abbreviation: string
      Location: SecretStage
      RuntimeRequirements: RuntimeRequirement list }
    
module SecretStageStar = 
    let getSecretStarInfo secretStar =
        match secretStar with
        | WingMarioOverTheRainbow ->
            { Name = "Wing Mario over the Rainbow"
              Abbreviation = NotImplementedException("TODO") |> raise
              Location = NotImplementedException("TODO") |> raise
              RuntimeRequirements = NotImplementedException("TODO") |> raise }
        | PrincessSlide1 ->
            { Name = ""
              Abbreviation = NotImplementedException("TODO") |> raise
              Location = NotImplementedException("TODO") |> raise
              RuntimeRequirements = NotImplementedException("TODO") |> raise }
        | PrincessSlide2 ->
            { Name = NotImplementedException("TODO") |> raise
              Abbreviation = NotImplementedException("TODO") |> raise
              Location = NotImplementedException("TODO") |> raise
              RuntimeRequirements = [ThisTimeOrBetter (TimeSpan.FromSeconds(21.0))] } // I think?