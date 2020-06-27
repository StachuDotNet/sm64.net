module SM64.Stars

open SM64.Course

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
    
    
type StandardCourseStarInfo =
    { Name: string
      CourseConnection: StandardCourse * StarNumber }

let getStandardCourseStarInfo standardCourseStar =
    match standardCourseStar with
    | BigBobOmbOnTheSummit ->
        { Name = "Big Bob-omb on the Summit"
          CourseConnection = BobOmbBattlefield, One }
    | BehindChainChompsGate ->
        { Name = "Behind Chain Chomp's Gate"
          CourseConnection = BobOmbBattlefield, Six }
    // lots more to do...
    
type ToadStar =
    | HMCToad

type Star =
    | ToadStar of ToadStar
    | Standard of StandardCourseStar
    | HundredCoin of StandardCourse
    | StandardAndHundred of StandardCourseStar * StandardCourse 
    | SecretStar of SecretStage
    | BowserReds of BowserStage
