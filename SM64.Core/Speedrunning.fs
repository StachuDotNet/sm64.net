module SM64.Speedrunning

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

let getSpeedrunningCategoryMetadata category =
    let commonName = sprintf "%i-Star"
    
    match category with
    | ZeroStar ->
        { Name = commonName 0
          MinimumStarCount = 0
          Restrictions = [] }
    | OneStar ->
        { Name = commonName 1
          MinimumStarCount = 1
          Restrictions = [] }
    | SixteenStar ->
        { Name = commonName 16
          MinimumStarCount = 16
          Restrictions = [] }
    | FiftyStar ->
        { Name = commonName 50
          MinimumStarCount = 50
          Restrictions = [] }
    | SeventyStar ->
        { Name = commonName 70
          MinimumStarCount = 70
          Restrictions = [] }
    | OneTwentyStar ->
        { Name = commonName 120
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