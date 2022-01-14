// A Route is a collection of ordered Segments that optimizes towards a Category
module SM64.Speedrunning.Routes

open System

open SM64.Routing
open SM64.Speedrunning.Categories

type CategoryRoute =
    SpeedrunningCategory * Segment list
    
type RouteValidationError =
    | FailsCategoryRestriction of SpeedrunningCategoryRestriction
    | TriesToDoSameStarTwice

let validateRoute: Result<unit, RouteValidationError> =
    raise (NotImplementedException("lazy"))
    
// from a shortlist of major achievements in a route (e.g. star-gets or bowser-fights),
// we should be able to "fill in" the minor steps in between such as castle movement
let fullRouteFromBasicSegments =
    []
