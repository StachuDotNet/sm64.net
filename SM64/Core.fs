module SM64.Core

open System

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

/// Each of the 15 (?) standard courses have 6 "regular" stars
type StarNumber = One | Two | Three | Four | Five | Six


// 
type StandardCourseStar =
    // BoB
    | BigBobOmbOnTheSummit // 1
    | FootraceWithKoopaTheQuick // 2
    | ShootIntoTheWildSky // 3
    | FindThe8RedCoins // 4
    | MarioWingsToTheSky // 5
    | BehindChainChompsGate // 6
    
    
    // Whomp's
    | ChipOffWhompsBlock // 1
    | ToTheTopOfTheFortress // 2
    | ShootIntoTheWildBlue // 3
    | RedCoinsOnTheFloatingIsle // 4
    | FallOntoTheCagedIsland // 5
    | BlastAwayTheWall // 6
    
    // JRB
    
    // CCM
    | SlipSlidinAway // 1
    | LilPenguinLost // 2
    | BigPenguinRace // 3
    | WallKicksWillWork // 6
    
    // SSL
    | InTheTalonsOfTheBigBird // 1
    | ShiningAtopThePyramid // 2
    
    // LLL
    | BoilTheBigBully // 1
    | BullyTheBullies // 2
    | EightCoinPuzzleWith15Pieces // 3
    | RedHotLogRolling // 4
    | HotFootItIntoTheVolcano // 5
    | ElevatorTourInTheVolcano // 6
    
    // HMC
    | AMazeingEmergencyExit // 5
    | WatchForRollingRocks // 6
    
    // DDD
    | BoardBowsersSub
    
    member this.CourseConnection: StandardCourse * StarNumber =
        match this with
        | BigBobOmbOnTheSummit -> BobOmbBattlefield, One
        | BehindChainChompsGate -> BobOmbBattlefield, Six
        
    member this.Name =
        match this with
        | BehindChainChompsGate -> "Behind Chain Chomp's Gate"
        | BigBobOmbOnTheSummit -> "Big Bob-omb on the Summit"

type ToadStar =
    | HMCToad

type Star =
    | ToadStar of ToadStar
    | Standard of StandardCourseStar
    | HundredCoin of StandardCourse
    | StandardAndHundred of StandardCourseStar * StandardCourse 
    | SecretStar of SecretStage
    | BowserReds of BowserStage

type Cap = Wing | Metal | Vanish
    
type Obtainable =
    | Cap of Cap
    | BowserKey of stage: BowserStage


type CastleMovement =
    | FromStartToFrontDoor
    | FromFrontDoorToBobDoor
    | FromBobDoorToBobPainting
    | MIPsClipStuff
    | BLJ50Stairway
    | BLJ70Stairway
    
type Cutscene =
    | Opening
    | StarGet
    | SingleDeath

type TextSegment =
    | LakituBridge 
    
    member this.TextPanelCount =
        match this with
        | LakituBridge -> raise (NotImplementedException("idk, like 3?"))

[<Measure>] type Second

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
