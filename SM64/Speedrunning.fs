module SM64.Speedrunning

open System
open SM64.Core

type SpeedrunningCategoryRestriction =
    | NoBlj

type SpeedrunningCategory =
    | ZeroStar
    | OneStar
    | SixteenStar
    | FiftyStar
    | SeventyStar
    | OneTwentyStar
    
    member this.StarRequirement: int =
        match this with
        | ZeroStar -> 0
        | OneStar -> 1
        | SixteenStar -> 16
        | FiftyStar -> 50
        | SeventyStar -> 70
        | OneTwentyStar -> 120
        
    member this.Restrictions: SpeedrunningCategoryRestriction list =
        raise (NotImplementedException("lazy"))
    
    member this.Name =
        let commonName = sprintf "%i-Star"
        
        match this with
        | ZeroStar -> commonName 0
        | OneStar -> commonName 1
        | SixteenStar -> commonName 16
        | FiftyStar -> commonName 50
        | SeventyStar -> commonName 70
        | OneTwentyStar -> commonName 120

type CategoryRoute =
    SpeedrunningCategory * Segment list
    
type RouteValidationError =
    | DoesNotMeetStarRequirementForCategory
    | DisobeysCategoryConstraints
    | TriesToDoSameStarTwice
    
let validateRoute: Result<unit, RouteValidationError> =
    raise (NotImplementedException("lazy"))