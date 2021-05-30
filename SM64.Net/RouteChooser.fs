module SM64.Net.RouteChooser

open Feliz.ViewEngine
open Giraffe
open SM64.Net
open SM64.Net.Layouts
open SM64.Net.Views

let routeChooser: (HttpFunc -> Microsoft.AspNetCore.Http.HttpContext -> HttpFuncResult) =
    choose
      [ route "/ping" >=> text "pong"
        
        route "/" >=> (Home.homeView |> layoutWithoutNav)
        route "/contribute" >=> (Contribute.contributeView |> layoutWithoutNav)
        
        // Game - Meta
        route  "/game" >=> (Views.Game.view|> layoutWithNav)
        route  "/plot" >=> (Views.Plot.plotView |> layoutWithNav)
        route  "/mechanics" >=> (Views.Mechanics.view  |> layoutWithNav)
        route  "/castle" >=> (Views.Castle.view |> layoutWithNav)
        route  "/characters" >=> (Views.Characters.view |> layoutWithNav)

        // Game - Stages and Stars    
        route "/stages" >=> (Views.Stages.view |> layoutWithNav)
        route  "/stages/courses" >=> (Views.StandardCourses.view |> layoutWithNav)
        routef "/stages/courses/%s" (Views.StandardCourse.view >> layoutWithNav)
        routef "/stars/%s/%i" (Views.StandardCourseStar.view >> layoutWithNav)
        route  "/stages/bowser" >=> (Views.BowserStages.view |> layoutWithNav)
        routef "/stages/bowser/%s" (Views.BowserStage.view >> layoutWithNav)
        routef "/stages/bowser/%s/reds" (Views.BowserStageReds.view >> layoutWithNav)
        route  "/stages/secret" >=> (Views.SecretStages.view |> layoutWithNav)
        routef "/stages/secret/%s" (Views.SecretStage.view >> layoutWithNav)
        routef "/stages/secret/%s/star" (Views.SecretStageStar.view >> layoutWithNav)
        route  "/stars" >=> (Views.AllStars.view |> layoutWithNav)
        
        // speedrunning and speedrunners
        route  "/speedrunning" >=> (Views.Speedrunning.Index.view |> layoutWithNav)
        route  "/speedrunning/records" >=> (Views.Speedrunning.Records.view |> layoutWithNav)
        route  "/speedrunning/rankings" >=> (Views.Speedrunning.Rankings.view |> layoutWithNav)
        route  "/speedrunning/categories" >=> (Views.Speedrunning.Categories.view |> layoutWithNav)
        route  "/speedrunning/routes" >=> (Views.Speedrunning.Routes.view |> layoutWithNav)
        route  "/speedrunning/speedrunners" >=> (Views.Speedrunning.Speedrunners.view |> layoutWithNav)
        routef "/speedrunning/speedrunners/%s" (Views.Speedrunning.Speedrunner.view >> layoutWithNav)
        route  "/speedrunning/strategies" >=> (Views.Speedrunning.Strategies.view |> layoutWithNav)
        route  "/speedrunning/competitions" >=> (Views.Speedrunning.Competitions.view |> layoutWithNav)
        route  "/speedrunning/challenges" >=> (Views.Speedrunning.Challenges.view |> layoutWithNav)
        
        // tools
        route  "/tools" >=> (Views.Tools.Index.view |> layoutWithNav)
        route  "/tools/usamune" >=> (Views.Tools.Usamune.view |> layoutWithNav)
      ]