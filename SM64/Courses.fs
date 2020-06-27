module SM64.Course

open System

type StandardCourse =
    | BobOmbBattlefield
    | WhompsFortress
    | JollyRogerBay
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
    
type EntryRequirement =
    /// At least "n" stars are required to open the door normally
    | MinimumStarCount of int
    
    /// Entry to the star is in the basement
    | IsInBasement
    
    /// Entry to the star is upstairs
    | IsUpstairs
    
    /// Entry to the star is in the "tippy" top of the castle
    | IsInTippy
    
type StandardCourseInfo =
    { Name: string
      CourseNumber: int
      
      Abbreviation: string
      
      EntryRequirements: EntryRequirement list }
    
let getInfoForStandardCourse gameRelease standardCourse: StandardCourseInfo =
    match standardCourse with
    | BobOmbBattlefield ->
        { Name =
            match gameRelease with
            | US -> "Bob-omb Battlefield"
          CourseNumber = 1
          Abbreviation = "BoB"
          EntryRequirements = [] }
    | WhompsFortress ->
        { Name =
            match gameRelease with
            | US -> "Whomp's Fortress"
          CourseNumber = 2
          Abbreviation = "WF"
          EntryRequirements = [MinimumStarCount 1] }
    | JollyRogerBay ->
        { Name =
            match gameRelease with
            | US -> "Jolly Roger Bay"
          CourseNumber = 3
          Abbreviation = "JRB"
          EntryRequirements = [MinimumStarCount 3] }
    | CoolCoolMountain ->
        { Name =
            match gameRelease with
            | US -> "Cool, Cool Mountain"
          CourseNumber = 4
          Abbreviation = "CCM"
          EntryRequirements = [MinimumStarCount 3] }
    | BigBoosHaunt ->
        { Name =
            match gameRelease with
            | US -> "Big Boo's Haunt"
          CourseNumber = 5
          Abbreviation = "BBH"
          EntryRequirements = raise (NotImplementedException("I forget")) }
    | HazyMazyCave ->
        { Name =
            match gameRelease with
            | US -> "Hazy Mazy Cave"
          CourseNumber = 6
          Abbreviation = "HMC"
          EntryRequirements = [IsInBasement] }
    | LethalLavaLand ->
        { Name =
            match gameRelease with
            | US -> "Lethal Lava Land"
          CourseNumber = 7
          Abbreviation = "LLL"
          EntryRequirements = [IsInBasement] } 
    | ShiftingSandLand ->
        { Name =
            match gameRelease with
            | US -> "Shifting Sand Land"
          CourseNumber = 8
          Abbreviation = "SSL"
          EntryRequirements = [IsInBasement] } 
    | DireDireDocks ->
        { Name =
            match gameRelease with
            | US -> "Dire, Dire Docks"
          CourseNumber = 9
          Abbreviation = "DDD"
          EntryRequirements = [IsInBasement; MinimumStarCount 30] } 
    | SnowmanLand ->
        { Name =
            match gameRelease with
            | US -> "Snowman's Land"
          CourseNumber = 10
          Abbreviation = "SL"
          EntryRequirements = [IsUpstairs] } 
    | WetDryWorld ->
        { Name =
            match gameRelease with
            | US -> "Wet-Dry World"
          CourseNumber = 11 
          Abbreviation = "WDW"
          EntryRequirements = [IsUpstairs] } 
    | TallTallMountain ->
        { Name =
            match gameRelease with
            | US -> "Tall, Tall Mountain"
          CourseNumber = 12
          Abbreviation = "TTM"
          EntryRequirements = [IsUpstairs] } 
    | TinyHugeIsland ->
        { Name =
            match gameRelease with
            | US -> "Tiny-Huge Island"
          CourseNumber = 13
          Abbreviation = "THI"
          EntryRequirements = [IsUpstairs] } 
    | TickTockClock ->
        { Name =
            match gameRelease with
            | US -> "Tick Tock Clock"
          CourseNumber = 14
          Abbreviation = "TTC"
          EntryRequirements = [IsInTippy] } 
    | RainbowRide ->
        { Name =
            match gameRelease with
            | US -> "Rainbow Ride"
          CourseNumber = 15
          Abbreviation = "RR"
          EntryRequirements = [IsInTippy] }
        
let courseEntryRequirements (_course: StandardCourse) =
    raise (NotImplementedException("lazy"))

type SecretStage =
    | TowerOfTheWingCap
    | VanishCapUnderTheMoat
    | CavernOfTheMetalCave
    
type SecretStageInfo =
    { Name: string
      Abbreviation: string
      EntryRequirements: EntryRequirement list }
    
let getSecretStageInfo gameRelease secretStage =
    match secretStage with
    | TowerOfTheWingCap ->
        { Name =
            match gameRelease with
            | US -> "Tower of the Wing Cap"
          Abbreviation = "ToTWC"
          EntryRequirements = [] }
    | VanishCapUnderTheMoat ->
        { Name =
            match gameRelease with
            | US -> "Vanish Cap Under the Moat"
          Abbreviation = "CotMC"
          EntryRequirements = [] }
    | CavernOfTheMetalCave ->
        { Name =
            match gameRelease with
            | US -> "Cavern of the Metal Cap"
          Abbreviation = "VCutM"
          EntryRequirements = [] }

    
type BowserStage = BitDW | BitFS | BitS

type BowerStageInfo =
    { Name: string
      Abbreviation: string
      EntryRequirements: EntryRequirement list }

let getBowserStageInfo gameRelease bowserStage =
    match bowserStage with
    | BitDW ->
        { Name = 
            match gameRelease with
            | US -> "Bowser in the Dark World"
          Abbreviation = "BitDW"
          EntryRequirements = [] }
    | BitFS ->
        { Name = 
            match gameRelease with
            | US -> "Bowser in the Fire Sea"
          Abbreviation = "BitFS"
          EntryRequirements = [] }
    | BitS ->
        { Name = 
            match gameRelease with
            | US -> "Bowser in the Sky"
          Abbreviation = "BitS"
          EntryRequirements = [] }