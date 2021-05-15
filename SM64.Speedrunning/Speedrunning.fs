module SM64.Speedrunning.Core

open System
open SM64.Routing

type SpeedrunningCategoryRestriction =
    | NoBlj

type SpeedrunningCategory =
    | ZeroStar
    | OneStar
    | SixteenStar
    | FiftyStar
    | SeventyStar
    | OneTwentyStar

type SpeedrunningCategoryMetadata =
    { Name: string
      MinimumStarCount: int
      Restrictions: SpeedrunningCategoryRestriction list }
 
let categoryName cat =
    match cat with
    | ZeroStar -> 0
    | OneStar -> 1
    | SixteenStar -> 16
    | FiftyStar -> 50
    | SeventyStar -> 70
    | OneTwentyStar -> 120
    |> sprintf "%i-Star"
   
let getSpeedrunningCategoryMetadata category =
    let name = categoryName category
    match category with
    | ZeroStar ->
        { Name = name
          MinimumStarCount = 0
          Restrictions = [] }
    | OneStar ->
        { Name = name
          MinimumStarCount = 1
          Restrictions = [] }
    | SixteenStar ->
        { Name = name
          MinimumStarCount = 16
          Restrictions = [] }
    | FiftyStar ->
        { Name = name
          MinimumStarCount = 50
          Restrictions = [] }
    | SeventyStar ->
        { Name = name
          MinimumStarCount = 70
          Restrictions = [] }
    | OneTwentyStar ->
        { Name = name
          MinimumStarCount = 120
          Restrictions = [] }


type CategoryRoute =
    SpeedrunningCategory * Segment list
    
type RouteValidationError =
    | DoesNotMeetStarRequirementForCategory
    | DisobeysCategoryConstraints
    | TriesToDoSameStarTwice
    
let validateRoute: Result<unit, RouteValidationError> =
    raise (NotImplementedException("lazy"))
    
// from a shortlist of major achievements in a route (e.g. star-gets or bowser-fights),
// we should be able to "fill in" the minor steps in between such as castle movement
let fullRouteFromBasicSegments =
    []