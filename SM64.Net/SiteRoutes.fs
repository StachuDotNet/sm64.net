namespace SM64.Net

open SM64.Core
open SM64.Courses
open SM64.Stars.StandardCourseStars

type SpeedrunnerUserHandle = string

[<RequireQualifiedAccess>]
type SiteRoute =
    | Home
    | Contribute
    
    // Core
    | Game
    | Plot
    | Mechanics
    | Castle
    | Characters
    
    | Stages
    | StandardCourses
    | StandardCourse of StandardCourse
    | StandardCourseStar of StandardCourseStar
    | SecretStages
    | SecretStage of SecretStage
    | SecretStageStar of SecretStage
    | BowserStages
    | BowserStage of BowserStage
    | BowserStageReds of BowserStage
    | AllStars
    
    // Speedrunning
    | Speedrunning
    | Records
    | Rankings
    | Categories
    | Speedrunners
    | Speedrunner of SpeedrunnerUserHandle
    | Strategies
    | Routes
    | Competitions
    | Challenges
    
    | Tools
    | Usamune
    | TwitchBot
    
    member this.Path =
        match this with
        | Home -> "/"
        | Contribute -> "/contribute"
        
        // Core
        | Game -> "/game"
        | Plot -> "/plot"
        | Mechanics -> "/mechanics"
        | Characters -> "/characters"
        | Castle -> "/castle"
        
        | Stages -> "/stages"
        
        | StandardCourses -> "/stages/courses"
        | StandardCourse stage ->
            let stageInfo = getInfoForStandardCourse SupportedGameRelease.NA stage
            sprintf "/stages/courses/%s" stageInfo.Abbreviation
        | StandardCourseStar star ->
            let course, placement = (StandardCourseStar.getStandardCourseStarInfo star).CourseConnection
            let courseInfo = getInfoForStandardCourse SupportedGameRelease.NA course
            sprintf "/stars/%s/%i" courseInfo.Abbreviation placement.ToInt
        
        | SecretStages -> "/stages/secret"
        | SecretStage stage ->
            let stageInfo = getSecretStageInfo SupportedGameRelease.NA stage
            sprintf "/stages/secret/%s" stageInfo.Abbreviation
        | SecretStageStar stage ->
            let stageInfo = getSecretStageInfo SupportedGameRelease.NA stage
            sprintf "/stages/secret/%s/star" stageInfo.Abbreviation
        | BowserStages -> "/stages/bowser"
        | BowserStage stage ->
            let stageInfo = getBowserStageInfo SupportedGameRelease.NA stage
            sprintf "/stages/bowser/%s" stageInfo.Abbreviation
        | BowserStageReds stage ->
            let stageInfo = getBowserStageInfo SupportedGameRelease.NA stage
            sprintf "/stages/bowser/%s/reds" stageInfo.Abbreviation
        
        | AllStars -> "/stars"

                        
        // Speedrunning
        | Speedrunning -> "/speedrunning"
        | Records -> "/speedrunning/records"
        | Rankings -> "/speedrunning/rankings"
        | Categories -> "/speedrunning/categories"
        | Routes -> "/speedrunning/routes"
        | Speedrunners -> "/speedrunning/speedrunners"
        | Speedrunner handle -> sprintf "/speedrunning/speedrunners/%s" handle
        | Strategies -> "/speedrunning/strategies"
        | Competitions -> "/speedrunning/competitions"
        | Challenges -> "/speedrunning/challenges"

        // Tools
        | Tools -> "/tools"
        | Usamune -> "/tools/usamune"
        | TwitchBot -> "/tools/twitch-bot"