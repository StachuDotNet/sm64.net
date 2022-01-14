module SM64.Speedrunning.Categories

type SpeedrunningCategoryRestriction =
    | BeatTheGame // defeat final bowser
    | NoBlj // no abuse of "backwards long jumps" allowed 
    | MinimumStarCount of int // must collect at least N stars

type SpeedrunningCategory =
    | ZeroStar
    | OneStar
    | SixteenStar
    | FiftyStar
    | SeventyStar
    | OneTwentyStar
    // todo: more categories
    // todo: maybe turn ^ into the "main" categories?
    
type SpeedrunningCategoryMetadata =
    { Name: string
      Restrictions: SpeedrunningCategoryRestriction list }
 
let getStandardName cat =
    match cat with
    | ZeroStar -> 0
    | OneStar -> 1
    | SixteenStar -> 16
    | FiftyStar -> 50
    | SeventyStar -> 70
    | OneTwentyStar -> 120
    |> sprintf "%i-Star"
   
let getSpeedrunningCategoryMetadata category =
    match category with
    | ZeroStar ->
        { Name = getStandardName category
          Restrictions = [ BeatTheGame ] }
    | OneStar ->
        { Name = getStandardName category
          Restrictions = [
              BeatTheGame
              MinimumStarCount 1
          ] }
    | SixteenStar ->
        { Name = getStandardName category
          Restrictions = [
              BeatTheGame
              MinimumStarCount 16
          ] }
    | FiftyStar ->
        { Name = getStandardName category
          Restrictions = [
              BeatTheGame
              MinimumStarCount 50
          ] }
    | SeventyStar ->
        { Name = getStandardName category
          Restrictions = [
            BeatTheGame
            MinimumStarCount 70
          ] }
    | OneTwentyStar ->
        { Name = getStandardName category
          Restrictions = [
              BeatTheGame
              MinimumStarCount 120
          ] }
