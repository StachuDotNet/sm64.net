module SM64.Courses

open System
open SM64.Core

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

let courseList = DiscriminatedUnionHelper.GetAllUnionCases<StandardCourse>()
    
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
            | NA -> "Bob-omb Battlefield"
          CourseNumber = 1
          Abbreviation = "BoB"
          EntryRequirements = [] }
    | WhompsFortress ->
        { Name =
            match gameRelease with
            | NA -> "Whomp's Fortress"
          CourseNumber = 2
          Abbreviation = "WF"
          EntryRequirements = [MinimumStarCount 1] }
    | JollyRogerBay ->
        { Name =
            match gameRelease with
            | NA -> "Jolly Roger Bay"
          CourseNumber = 3
          Abbreviation = "JRB"
          EntryRequirements = [MinimumStarCount 3] }
    | CoolCoolMountain ->
        { Name =
            match gameRelease with
            | NA -> "Cool, Cool Mountain"
          CourseNumber = 4
          Abbreviation = "CCM"
          EntryRequirements = [MinimumStarCount 3] }
    | BigBoosHaunt ->
        { Name =
            match gameRelease with
            | NA -> "Big Boo's Haunt"
          CourseNumber = 5
          Abbreviation = "BBH"
          EntryRequirements = raise (NotImplementedException("I forget")) }
    | HazyMazyCave ->
        { Name =
            match gameRelease with
            | NA -> "Hazy Mazy Cave"
          CourseNumber = 6
          Abbreviation = "HMC"
          EntryRequirements = [IsInBasement] }
    | LethalLavaLand ->
        { Name =
            match gameRelease with
            | NA -> "Lethal Lava Land"
          CourseNumber = 7
          Abbreviation = "LLL"
          EntryRequirements = [IsInBasement] } 
    | ShiftingSandLand ->
        { Name =
            match gameRelease with
            | NA -> "Shifting Sand Land"
          CourseNumber = 8
          Abbreviation = "SSL"
          EntryRequirements = [IsInBasement] } 
    | DireDireDocks ->
        { Name =
            match gameRelease with
            | NA -> "Dire, Dire Docks"
          CourseNumber = 9
          Abbreviation = "DDD"
          EntryRequirements = [IsInBasement; MinimumStarCount 30] } 
    | SnowmanLand ->
        { Name =
            match gameRelease with
            | NA -> "Snowman's Land"
          CourseNumber = 10
          Abbreviation = "SL"
          EntryRequirements = [IsUpstairs] } 
    | WetDryWorld ->
        { Name =
            match gameRelease with
            | NA -> "Wet-Dry World"
          CourseNumber = 11 
          Abbreviation = "WDW"
          EntryRequirements = [IsUpstairs] } 
    | TallTallMountain ->
        { Name =
            match gameRelease with
            | NA -> "Tall, Tall Mountain"
          CourseNumber = 12
          Abbreviation = "TTM"
          EntryRequirements = [IsUpstairs] } 
    | TinyHugeIsland ->
        { Name =
            match gameRelease with
            | NA -> "Tiny-Huge Island"
          CourseNumber = 13
          Abbreviation = "THI"
          EntryRequirements = [IsUpstairs] } 
    | TickTockClock ->
        { Name =
            match gameRelease with
            | NA -> "Tick Tock Clock"
          CourseNumber = 14
          Abbreviation = "TTC"
          EntryRequirements = [IsInTippy] } 
    | RainbowRide ->
        { Name =
            match gameRelease with
            | NA -> "Rainbow Ride"
          CourseNumber = 15
          Abbreviation = "RR"
          EntryRequirements = [IsInTippy] }
        
let courseEntryRequirements (_course: StandardCourse) =
    raise (NotImplementedException("lazy"))

/// There are a number of "secret stages"
/// - each of these have 1 star - or 2 in the case of the secret slide
/// - 3 of them have an associated "Cap" you can collect in them
type SecretStage =
    | PrincessSecretSlide
    | TowerOfTheWingCap
    | VanishCapUnderTheMoat
    | CavernOfTheMetalCave
    | SecretAquarium
    | Cloud
    
type SecretStageInfo =
    { Name: string
      Abbreviation: string
      EntryRequirements: EntryRequirement list }
    
let getSecretStageInfo (gameRelease: SupportedGameRelease) secretStage =
    match secretStage with
    | PrincessSecretSlide ->
        { Name =
            match gameRelease with
            | NA -> "Princess Secret Slide"
          Abbreviation = "PSS"
          EntryRequirements = [] }
    | TowerOfTheWingCap ->
        { Name =
            match gameRelease with
            | NA -> "Tower of the Wing Cap"
          Abbreviation = "ToTWC"
          EntryRequirements = [MinimumStarCount 10] }
    | VanishCapUnderTheMoat ->
        { Name =
            match gameRelease with
            | NA -> "Vanish Cap Under the Moat"
          Abbreviation = "CotMC"
          EntryRequirements = [IsInBasement] } // ok well not "in basement" exactly
    | CavernOfTheMetalCave ->
        { Name =
            match gameRelease with
            | NA -> "Cavern of the Metal Cap"
          Abbreviation = "VCutM"
          EntryRequirements = [IsInBasement] }
    | SecretAquarium ->
        { Name =
            match gameRelease with
            | NA -> "The Secret Aquarium"
          Abbreviation = "SA"
          EntryRequirements = [] }
    | Cloud ->
        { Name =
            match gameRelease with
            | NA -> "The Secret Aquarium"
          Abbreviation = "SA" //?
          EntryRequirements = [IsInBasement] }

    
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
            | NA -> "Bowser in the Dark World"
          Abbreviation = "BitDW"
          EntryRequirements = [] }
    | BitFS ->
        { Name = 
            match gameRelease with
            | NA -> "Bowser in the Fire Sea"
          Abbreviation = "BitFS"
          EntryRequirements = [] }
    | BitS ->
        { Name = 
            match gameRelease with
            | NA -> "Bowser in the Sky"
          Abbreviation = "BitS"
          EntryRequirements = [] }