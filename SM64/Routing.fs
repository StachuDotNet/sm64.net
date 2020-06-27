module SM64.Routing

open System
open SM64.Course
open SM64.Stars

type CastleMovement =
    | FromStartToFrontDoor
    | FromFrontDoorToBobDoor
    | FromBobDoorToBobPainting
    | MIPsClipStuff
    | BLJ50Stairway
    | BLJ70Stairway
    // TODO: lots of cases!
    
type Cutscene =
    | OpeningAnimation
    | StarGet
    | SingleDeath

type TextSegment =
    | OpeningText // a button, b button
    | LakituBridge

let getTextPanelCount textSegment =
    raise (NotImplementedException("need to count"))

/// This is what I'm calling things like "from turning N64 on to starting the game" and 
type ScreenMovement =
    | TurnOnSystemAndGetToMarioFace
    | FromMarioFaceToStarSelect
    
    member this.MinimumTimeSpent: float<Second> =
        match this with
        | TurnOnSystemAndGetToMarioFace -> raise (NotImplementedException("untimed"))
        | FromMarioFaceToStarSelect -> raise (NotImplementedException("untimed"))
    
type BowserSegment =
    | JustGetToBowser of BowserStage
    | GetToBowserWithReds of BowserStage
    | FightBowser of BowserStage

type Segment =
    | ScreenMovement of ScreenMovement
    | CastleMovement of CastleMovement
    | Cutscene of Cutscene
    | Text of TextSegment
    | Star of Star
    | BowserSegment of BowserSegment
