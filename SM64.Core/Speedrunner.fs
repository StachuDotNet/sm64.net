module SM64.Speedrunner

open SM64.Speedrunning

type Speedrunner =
    { Name: string
      Routes: CategoryRoute list }

type Recommendation = string

let getRouteRecommendations (_route: CategoryRoute): Recommendation list =
    // TODO
    []