module SM64.MySpeedrunning

open SM64.Routing
open SM64.Courses
open SM64.Stars
open SM64.Speedrunner
open SM64.Speedrunning

let standardIntro =
    [ ScreenMovement TurnOnSystemAndGetToMarioFace
      ScreenMovement FromMarioFaceToStarSelect
      CastleMovement FromStartToFrontDoor
      CastleMovement FromFrontDoorToBobDoor
      CastleMovement FromBobDoorToBobPainting ]

let mySixteenStarRoute: Segment list =
    [ yield! standardIntro
      
      // star #1: BoB
      Star (Standard BehindChainChompsGate) // note: don't *quite* like the interface here...
      
      // star #2-8: Whomp's
      Star (StandardAndHundred (RedCoinsOnTheFloatingIsle, WhompsFortress))
      Star (Standard ChipOffWhompsBlock)
      Star (Standard ToTheTopOfTheFortress)
      Star (Standard ShootIntoTheWildBlue)
      Star (Standard FallOntoTheCagedIsland)
      Star (Standard BlastAwayTheWall)
      
      // star #9, Bowser #1
      BowserSegment (GetToBowserWithReds BitDW)
      
      // star #10, 11: SSL
      Star (Standard InTheTalonsOfTheBigBird)
      Star (Standard ShiningAtopThePyramid)
      
      // star #12: LLL
      Star (Standard EightCoinPuzzleWith15Pieces)
      
      // star #13-15: HMC and toad
      Star (ToadStar HMCToad)
      Star (Standard AMazeingEmergencyExit)
      Star (Standard WatchForRollingRocks)
      
      CastleMovement (MIPsClipStuff)
      
      // star #16: DDD (unlock bowser 2 pipe
      Star (Standard BoardBowsersSub)
      
      // bowser 2
      BowserSegment (JustGetToBowser BitFS)
      
      // todo: get from bowser 2 to blj #1
      
      // blj#1
      CastleMovement (BLJ50Stairway)
      
      // todo: get from blj #1 to blj #2
      
      // blj #2
      CastleMovement (BLJ70Stairway)
      
      // bowser 3, get to bowser, then fight him
      BowserSegment (JustGetToBowser BitS)
      BowserSegment (FightBowser BitS) ]


let stachuSpeedrunner: Speedrunner =
    { Name = "Stachu Korick"
      Routes = [ SixteenStar, mySixteenStarRoute ] }