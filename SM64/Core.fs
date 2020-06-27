module SM64.Core

open System

(* half-organized TODOs:
- need to record what a star unlocks
    - e.g. the ship star in DDD unlocks 2nd bowser pipe opening (or whatever)

*)

type StandardCourse =
    | BobOmbBattlefield
    | JollyRogerBay
    | WhompsFortress
    | CoolCoolMountain
    | BigBoosHaunt
    | HazyMazyCave
    | LethalLavaLand
    | ShiftingSandLand
    | DireDireDocks
    | SnowmanLand
    | WetDryWorld
    | TallTallMountain
    | TinyHugeIsland
    | TickTockClock
    | RainbowRide
    
    member this.CourseNumber =
        match this with
        | BobOmbBattlefield -> 1
        | WhompsFortress -> 2
        | JollyRogerBay -> 3
        | CoolCoolMountain -> 4
        | BigBoosHaunt -> 5
        | HazyMazyCave -> 6
        | LethalLavaLand -> 7
        | ShiftingSandLand -> 8
        | DireDireDocks -> 9
        | SnowmanLand -> 10
        | WetDryWorld -> 11
        | TallTallMountain -> 12
        | TinyHugeIsland -> 13
        | TickTockClock -> 14
        | RainbowRide -> 15
        
    member this.EntryRequirements = []
        
    member this.Name =
        match this with
        | BobOmbBattlefield -> "Bob-Omb Battlefield"
        | JollyRogerBay -> "Jolly Roger Bay"
        | WhompsFortress -> "Whomp's Fortress"
        | CoolCoolMountain -> "Cool, Cool Mountain"
        | BigBoosHaunt -> "Big Boo's Haunt"
        | HazyMazyCave -> "Hazy Mazy Cave"
        | LethalLavaLand -> "Lethal Lava Land" 
        | ShiftingSandLand -> "Shifting Sand Land" 
        | DireDireDocks -> "Dire, Dire Docks" 
        | SnowmanLand -> "Snowman's Land" 
        | WetDryWorld -> "Wet-Dry World" 
        | TallTallMountain -> "Tall, Tall Mountain" 
        | TinyHugeIsland -> "Tiny-Huge Island" 
        | TickTockClock -> "Tick Tock Clock" 
        | RainbowRide -> "Rainbow Ride" 


type SecretStage =
    | VanishCapUnderTheMoat
    | CavernOfTheMetalCave
    
    member this.Abbreviation =
        match this with
        | CavernOfTheMetalCave -> "CotMC"
        | VanishCapUnderTheMoat -> "VCutM"
    
    member this.Name =
        match this with
        | VanishCapUnderTheMoat -> "Vanish Cap Under the Moat"
        | CavernOfTheMetalCave -> "Cavern of the Metal Cap"
    

/// Each of the 15 (?) standard courses have 6 "regular" stars
type StarNumber = One | Two | Three | Four | Five | Six

// 
type StandardCourseStar =
    | BehindChainChompsGate
    | BigBobOmbOnTheSummit
    
    member this.CourseConnection: StandardCourse * StarNumber =
        match this with
        | BigBobOmbOnTheSummit -> BobOmbBattlefield, One
        | BehindChainChompsGate -> BobOmbBattlefield, Six
        
    member this.Name =
        match this with
        | BehindChainChompsGate -> "Behind Chain Chomp's Gate"
        | BigBobOmbOnTheSummit -> "Big Bob-omb on the Summit"
    
    
type SpeedrunningRestriction =
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
        
    member this.Restrictions: SpeedrunningRestriction list =
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

type BowserStage =
    | BitDW
    | BitFS
    | BitS
    
    member this.Order =
        match this with
        | BitDW -> 1
        | BitFS -> 2
        | BitS -> 3
    
    member this.Name =
        match this with
        | BitDW -> "Bowser in the Dark World"
        | BitFS -> "Bowser in the Fire Sea"
        | BitS -> "Bowser in the Sky"

type Cap = Wing | Metal | Vanish
    
type Obtainable =
    | Cap of Cap
    | BowserKey of stage: BowserStage

type StarType =
    | Standard of StandardCourseStar
    | HundredCoin of StandardCourse
    | SecretStar of SecretStage
    | BowserReds of BowserStage

type CastleMovement =
    | FromStartToFrontDoor
    | FromFrontDoorToBob
    | FromBobTo
    
type Cutscene =
    | StarGet
    | SingleDeath

type TextSegment =
    | LakituBridge 
    
    member this.TextPanelCount =
        match this with
        | LakituBridge -> raise (NotImplementedException("idk, like 3?"))

type Segment =
    | CastleMovement of CastleMovement
    | Cutscene of Cutscene
    | Text of TextSegment
    | Star of StarType

type CategoryRoute =
    SpeedrunningCategory * Segment list
    
let mySixteenStarRoute =
    [ ]
    
type RouteValidationError =
    | DoesNotMeetStarRequirement
    | DisobeysCategoryConstraints
    
let validateRoute: Result<unit, RouteValidationError> =
    raise (NotImplementedException("lazy"))
    
// tech ideas
(*
- graph DB?
    - options: arango, orient, neo4j, custom?
    - interface: Cypher via F#?
    - thoughts:
        - do I care more about the computation or the storage?
            (triple store or property graph options)
            
- tech stack
    F#?
    TS stuff

- related software
    - autosplitter
        doesn't work on linux
*)