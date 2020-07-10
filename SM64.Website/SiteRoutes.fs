namespace SM64.Website

[<RequireQualifiedAccess>]
type SiteRoute =
    | Home
    
    // Core
    | Game
    | Plot
    | Mechanics
    | Castle
    | Stars
    | Characters
    | Stages
    
    // Speedrunning
    | Speedrunning
    | Records
    | Rankings
    | Categories
    | Profiles
    | Strategies
    | Routes
    | Competitions
    | Challenges
    member this.PrimaryPath =
        match this with
        // Core
        | Home -> "/"
        | Game -> "/game"
        | Plot -> "/plot"
        | Mechanics -> "/mechanics"
        | Castle -> "/castle"
        | Stars -> "/stars"
        | Characters -> "/characters"
        | Stages -> "/stages"
        
        // Speedrunning
        | Speedrunning -> "/speedrunning"
        | Records -> "/records"
        | Rankings -> "/rankings"
        | Categories -> "/categories"
        | Routes -> "/routes"
        | Profiles -> "/profiles"
        | Strategies -> "/strategies"
        | Competitions -> "/competitions"
        | Challenges -> "/challenges"
        
        // Tools (todo)
        
    member this.AlternativePaths =
        match this with
        | Strategies -> ["/strats"]
        | _ -> []