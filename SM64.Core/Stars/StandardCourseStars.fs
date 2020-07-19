namespace SM64.Stars.StandardCourseStars

open SM64
open SM64.Courses

/// This type represents each of the 6 "regular" stars within the 16 standard courses. 
type StandardCourseStar =
    // BoB - Standard Course #1
    | BigBobOmbOnTheSummit // 1
    | FootraceWithKoopaTheQuick // 2
    | ShootIntoTheWildSky // 3
    | FindThe8RedCoins // 4
    | MarioWingsToTheSky // 5
    | BehindChainChompsGate // 6
    
    // Whomp's - Standard Course #2
    | ChipOffWhompsBlock // 1
    | ToTheTopOfTheFortress // 2
    | ShootIntoTheWildBlue // 3
    | RedCoinsOnTheFloatingIsle // 4
    | FallOntoTheCagedIsland // 5
    | BlastAwayTheWall // 6
    
    // JRB - Standard Course #3
    | PlunderInTheSunkenShip // 1
    | CanTheEelComeOutAndPlay // 2
    | TreasureOfTheOceanCave // 3
    | RedCoinsOnTheShipAfloat // 4
    | BlastToTheStonePillar // 5
    | ThroughTheJetStream // 6
    
    // CCM - Standard Course #4
    | SlipSlidinAway // 1
    | LilPenguinLost // 2
    | BigPenguinRace // 3
    | FrostySlideFor8RedCoins // 4
    | SnowmanLostHisHead // 5
    | WallKicksWillWork // 6
    
    // BBH - Standard Course #5
    | GoOnAGhostHunt // 1
    | SeekThe8RedCoins // 2
    | EyeToEyeInTheSecretRoom // 3
    | RideBigBoosMerryGoRound // 4
    | BigBoosBalcony // 5
    | SecretOfTheHauntedBooks // 6
    
    // HMC - Standard Course #6
    | SwimmingBeastInTheCavern // 1
    | ElevateFor8RedCoins // 2
    | MetalHeadMarioCanMove // 3
    | NavigatingTheToxicMaze // 4
    | AMazeingEmergencyExit // 5
    | WatchForRollingRocks // 6
    
    // LLL - Standard Course #7
    | BoilTheBigBully // 1
    | BullyTheBullies // 2
    | EightCoinPuzzleWith15Pieces // 3
    | RedHotLogRolling // 4
    | HotFootItIntoTheVolcano // 5
    | ElevatorTourInTheVolcano // 6
    
    // SSL - Standard Course #8
    | InTheTalonsOfTheBigBird // 1
    | ShiningAtopThePyramid // 2
    | InsideTheAncientPyramid // 3
    | StandTallOnTheFourPillars // 4
    | FreeFlyingFor8RedCoins // 5
    | PyramidPuzzle // 6
    
    // DDD - Standard Course #9
    | BoardBowsersSub // 1
    | ChestsInTheCurrent // 2
    | PoleJumpingForRedCoins // 3
    | ThroughTheJetStreams // 4
    | TheMantaRaysReward // 5
    | CollectTheCaps // 6
    
    // SL/SML - Standard Course #10
    | SnowmansBigHead // 1
    | ChillWithTheBully // 2
    | InTheDeepFreeze // 3 
    | WhirlFromTheFreezingPond // 4
    | ShellShreddinForRedCoins // 5
    | IntoTheIgloo // 6
    
    // WDW - Standard Course #11
    | ShockingArrowLifts // 1
    | TopOfTheTown // 2
    | SecretsInTheShallowsAndSky // 3
    | ExpressElevatorHurryUp // 4
    | GoToTownForRedCoins // 5
    | QuickRaceThroughDowntown // 6
    
    // TTM - Standard Course #12
    | ScaleTheMountain // 1
    | MysteryOfTheMonkeyCage // 2
    | ScaryShroomsRedCoins // 3
    | MysteriousMountainside // 4
    | BreathtakingViewFromTheBridge // 5
    | BlastToTheLonelyMushroom // 6
    
    // THI - Standard Course #13
    | PluckThePiranhaFlower // 1
    | TheTipTopOfTheHugeIsland // 2
    | RematchWithKoopaTheQuick // 3
    | FiveIttyBittySecrets // 4
    | WigglersRedCoins // 5
    | MakeWigglerSquirm // 6
    
    // TTC - Standard Course #14
    | RollIntoTheCage // 1
    | ThePitAndThePendulums // 2
    | GetAHand // 3
    | StompOnTheThwomp // 4
    | TimedJumpsOnMovingBars // 5
    | StopTimeForRedCoins // 6
    
    // RR - Standard Course #15
    | CruiserCrossingTheRainbow // 1
    | TheBigHouseInTheSky // 2
    | CoinsAmassedInAMaze // 3
    | SwinginInTheBreeze // 4
    | TrickyTriangles // 5
    | SomewhereOverTheRainbow // 6

type StarNumber =
  One | Two | Three | Four | Five | Six
  member this.ToInt =
    match this with
    | One -> 1
    | Two -> 2
    | Three -> 3
    | Four -> 4
    | Five -> 5
    | Six -> 6

type StandardCourseStarInfo =
    { Name: string
      CourseConnection: StandardCourse * StarNumber
      //IsRedCoinStar: bool
      }

module StandardCourseStar =
    let standardStarList = DiscriminatedUnionHelper.GetAllUnionCases<StandardCourseStar>()
    
    let getStandardCourseStarInfo standardCourseStar =
        match standardCourseStar with
        | BigBobOmbOnTheSummit ->
            { Name = "Big Bob-omb on the Summit"
              CourseConnection = BobOmbBattlefield, One }
        | FootraceWithKoopaTheQuick ->
          { Name = "Footrace with Koopa the Quick"
            CourseConnection = BobOmbBattlefield, Two }
        | ShootIntoTheWildSky ->
          { Name = "Shoot into the Wild Sky"
            CourseConnection = BobOmbBattlefield, Three }
        | FindThe8RedCoins ->
          { Name = "Find the 8 Red Coins"
            CourseConnection = BobOmbBattlefield, Four }
        | MarioWingsToTheSky ->
          { Name = "Mario Wings to the Sky"
            CourseConnection = BobOmbBattlefield, Five }
        | BehindChainChompsGate ->
          { Name = "Behind Chain Chomp's Gate"
            CourseConnection = BobOmbBattlefield, Six }
        
        // Whomp's - Standard Course #2
        | ChipOffWhompsBlock ->
          { Name = "Chip Off Whomp's Block"
            CourseConnection = WhompsFortress, One }
        | ToTheTopOfTheFortress ->
          { Name = "To the Top of the Fortress"
            CourseConnection = WhompsFortress, Two }
        | ShootIntoTheWildBlue ->
          { Name = "Shoot Into the Wild Blue"
            CourseConnection = WhompsFortress, Three }
        | RedCoinsOnTheFloatingIsle ->
          { Name = "Red Coins on the Floating Isle"
            CourseConnection = WhompsFortress, Four }
        | FallOntoTheCagedIsland ->
          { Name = "Fall Onto the Caged Island"
            CourseConnection = WhompsFortress, Five }
        | BlastAwayTheWall ->
          { Name = "Blast Away the Wall"
            CourseConnection = WhompsFortress, Six }
        
        // JRB - Standard Course #3
        | PlunderInTheSunkenShip ->
          { Name = "Plunder in the Sunken Ship"
            CourseConnection = JollyRogerBay, One }
        | CanTheEelComeOutAndPlay ->
          { Name = "Can the Eel Come Out and Play?"
            CourseConnection = JollyRogerBay, Two }
        | TreasureOfTheOceanCave ->
          { Name = "Treasure of the Ocean Cave"
            CourseConnection = JollyRogerBay, Three }
        | RedCoinsOnTheShipAfloat ->
          { Name = "Red Coins on the Ship Afloat"
            CourseConnection = JollyRogerBay, Four }
        | BlastToTheStonePillar ->
          { Name = "Blast to the Stone Pillzr"
            CourseConnection = JollyRogerBay, Five }
        | ThroughTheJetStream ->
          { Name = "Through the Jet Stream"
            CourseConnection = JollyRogerBay, Six }
        
        // CCM - Standard Course #4
        | SlipSlidinAway ->
          { Name = "Slip Slidin' Away"
            CourseConnection = CoolCoolMountain, One }
        | LilPenguinLost ->
          { Name = "Lil' Penguin Lost"
            CourseConnection = CoolCoolMountain, Two }
        | BigPenguinRace ->
          { Name = "Big Penguin Race"
            CourseConnection = CoolCoolMountain, Three }
        | FrostySlideFor8RedCoins ->
          { Name = "Frosty Slide for 8 Red Coins"
            CourseConnection = CoolCoolMountain, Four }
        | SnowmanLostHisHead ->
          { Name = "Snowman Lost His Head"
            CourseConnection = CoolCoolMountain, Five }
        | WallKicksWillWork ->
          { Name = "WallKicksWillWork"
            CourseConnection = CoolCoolMountain, Six }
        
        // BBH - Standard Course #5
        | GoOnAGhostHunt ->
          { Name = "Go on a Ghost Hunt"
            CourseConnection = BigBoosHaunt, One }
        | SeekThe8RedCoins ->
          { Name = "Seek the 8 Red Coins"
            CourseConnection = BigBoosHaunt, Two }
        | EyeToEyeInTheSecretRoom ->
          { Name = "Eye to Eye in the Secret Room"
            CourseConnection = BigBoosHaunt, Three }
        | RideBigBoosMerryGoRound ->
          { Name = "Ride Big Boo's Merry-Go-Round"
            CourseConnection = BigBoosHaunt, Four }
        | BigBoosBalcony ->
          { Name = "Big Boo's Balcony"
            CourseConnection = BigBoosHaunt, Five }
        | SecretOfTheHauntedBooks ->
          { Name = "Secret of the Haunted Books"
            CourseConnection = BigBoosHaunt, Six }
        
        // HMC - Standard Course #6
        | SwimmingBeastInTheCavern ->
          { Name = "Swimming Beast in the Cavern"
            CourseConnection = HazyMazyCave, One }
        | ElevateFor8RedCoins ->
          { Name = "Elevate for 8 Red Coins"
            CourseConnection = HazyMazyCave, Two }
        | MetalHeadMarioCanMove ->
          { Name = "Metal Head Mario Can Move"
            CourseConnection = HazyMazyCave, Three }
        | NavigatingTheToxicMaze ->
          { Name = "Navigating the Toxic Maze"
            CourseConnection = HazyMazyCave, Four }
        | AMazeingEmergencyExit ->
          { Name = "A-Maze-ing Emergency Exit"
            CourseConnection = HazyMazyCave, Five }
        | WatchForRollingRocks ->
          { Name = "Watch for Rolling Rocks"
            CourseConnection = HazyMazyCave, Six }
        
        // LLL - Standard Course #7
        | BoilTheBigBully ->
          { Name = "Boil the Big Bully"
            CourseConnection = LethalLavaLand, One }
        | BullyTheBullies ->
          { Name = "Bully the Bullies"
            CourseConnection = LethalLavaLand, Two }
        | EightCoinPuzzleWith15Pieces ->
          { Name = "Eight Coin Puzzle with 15 Pieces"
            CourseConnection = LethalLavaLand, Three }
        | RedHotLogRolling ->
          { Name = "Red-Hot Log Rolling"
            CourseConnection = LethalLavaLand, Four }
        | HotFootItIntoTheVolcano ->
          { Name = "Hot-Foot-It Into the Volcano"
            CourseConnection = LethalLavaLand, Five }
        | ElevatorTourInTheVolcano ->
          { Name = "Elevator Tour in the Volcano"
            CourseConnection = LethalLavaLand, Six }
        
        // SSL - Standard Course #8
        | InTheTalonsOfTheBigBird ->
          { Name = "In the Talons of the Big Bird"
            CourseConnection = ShiftingSandLand, One }
        | ShiningAtopThePyramid ->
          { Name = "Shining Atop the Pyramid"
            CourseConnection = ShiftingSandLand, Two }
        | InsideTheAncientPyramid ->
          { Name = "Inside the Ancient Pyramid"
            CourseConnection = ShiftingSandLand, Three }
        | StandTallOnTheFourPillars ->
          { Name = "Stand Tall on the Four Pillars"
            CourseConnection = ShiftingSandLand, Four }
        | FreeFlyingFor8RedCoins ->
          { Name = "Free Flying for 8 Red Coins"
            CourseConnection = ShiftingSandLand, Five }
        | PyramidPuzzle ->
          { Name = "Pyramid Puzzle"
            CourseConnection = ShiftingSandLand, Six }
        
        // DDD - Standard Course #9
        | BoardBowsersSub ->
          { Name = "Board Bowser's Sub"
            CourseConnection = DireDireDocks, One }
        | ChestsInTheCurrent ->
          { Name = "Chests in the Current"
            CourseConnection = DireDireDocks, Two }
        | PoleJumpingForRedCoins ->
          { Name = "Pole-Jumping for Red Coins"
            CourseConnection = DireDireDocks, Three }
        | ThroughTheJetStreams ->
          { Name = "Through the Jet Streams"
            CourseConnection = DireDireDocks, Four }
        | TheMantaRaysReward ->
          { Name = "The Manta Ray's Reward"
            CourseConnection = DireDireDocks, Five }
        | CollectTheCaps ->
          { Name = "Collect the Caps"
            CourseConnection = DireDireDocks, Six }
        
        // SL/SML - Standard Course #10
        | SnowmansBigHead ->
          { Name = "Snowman's Big Head"
            CourseConnection = SnowmanLand, One }
        | ChillWithTheBully ->
          { Name = "Chill With the Bully"
            CourseConnection = SnowmanLand, Two }
        | InTheDeepFreeze ->
          { Name = "In the Deep Freeze"
            CourseConnection = SnowmanLand, Three } 
        | WhirlFromTheFreezingPond ->
          { Name = "Whirl from the Freezing Pond"
            CourseConnection = SnowmanLand, Four }
        | ShellShreddinForRedCoins ->
          { Name = "Shell Shreddin' for Red Coins"
            CourseConnection = SnowmanLand, Five }
        | IntoTheIgloo ->
          { Name = "Into the Igloo"
            CourseConnection = SnowmanLand, Six }
        
        // WDW - Standard Course #11
        | ShockingArrowLifts ->
          { Name = "Shocking Arrow Lifts"
            CourseConnection = WetDryWorld, One }
        | TopOfTheTown ->
          { Name = "Top of the Town"
            CourseConnection = WetDryWorld, Two }
        | SecretsInTheShallowsAndSky ->
          { Name = "Secrets in the Shallows and Sky"
            CourseConnection = WetDryWorld, Three }
        | ExpressElevatorHurryUp ->
          { Name = "Express Elevator - Hurry Up!!"
            CourseConnection = WetDryWorld, Four }
        | GoToTownForRedCoins ->
          { Name = "Go to Town for Red Coins"
            CourseConnection = WetDryWorld, Five }
        | QuickRaceThroughDowntown ->
          { Name = "Quick Race through Downtown"
            CourseConnection = WetDryWorld, Six }
        
        // TTM - Standard Course #12
        | ScaleTheMountain ->
          { Name = "Scale the Mountain"
            CourseConnection = TallTallMountain, One }
        | MysteryOfTheMonkeyCage ->
          { Name = "Mystery of the Monkey Cage"
            CourseConnection = TallTallMountain, Two }
        | ScaryShroomsRedCoins ->
          { Name = "Scary 'Shrooms, Red Coins"
            CourseConnection = TallTallMountain, Three }
        | MysteriousMountainside ->
          { Name = "Mysterious Mountainside"
            CourseConnection = TallTallMountain, Four }
        | BreathtakingViewFromTheBridge ->
          { Name = "Breathtaking View from the Bridge"
            CourseConnection = TallTallMountain, Five }
        | BlastToTheLonelyMushroom ->
          { Name = "Blast to the Lonely Mushroom"
            CourseConnection = TallTallMountain, Six }
        
        // THI - Standard Course #13
        | PluckThePiranhaFlower ->
          { Name = "Pluck the Piranha Flower"
            CourseConnection = TinyHugeIsland, One }
        | TheTipTopOfTheHugeIsland ->
          { Name = "The Tip Top of the Huge island"
            CourseConnection = TinyHugeIsland, Two }
        | RematchWithKoopaTheQuick ->
          { Name = "Rematch with Koopa the Quick"
            CourseConnection = TinyHugeIsland, Three }
        | FiveIttyBittySecrets ->
          { Name = "Five Itty Bitty Secrets"
            CourseConnection = TinyHugeIsland, Four }
        | WigglersRedCoins ->
          { Name = "Wiggler's Red Coins"
            CourseConnection = TinyHugeIsland, Five }
        | MakeWigglerSquirm ->
          { Name = "Make Wiggler Squirm"
            CourseConnection = TinyHugeIsland, Six }
        
        // TTC - Standard Course #14
        | RollIntoTheCage ->
          { Name = "Roll Into the Cage"
            CourseConnection = TickTockClock, One }
        | ThePitAndThePendulums ->
          { Name = "The Pit and the Pendulums"
            CourseConnection = TickTockClock, Two }
        | GetAHand ->
          { Name = "Get a Hand"
            CourseConnection = TickTockClock, Three }
        | StompOnTheThwomp ->
          { Name = "Stomp on The Thwomp"
            CourseConnection = TickTockClock, Four }
        | TimedJumpsOnMovingBars ->
          { Name = "Timed Jumps on Moving Bars"
            CourseConnection = TickTockClock, Five }
        | StopTimeForRedCoins ->
          { Name = "Stop Time for Red Coins"
            CourseConnection = TickTockClock, Six }
        
        // RR - Standard Course #15
        | CruiserCrossingTheRainbow ->
          { Name = "Cruiser Crossing the Rainbow"
            CourseConnection = RainbowRide, One }
        | TheBigHouseInTheSky ->
          { Name = "The Big House in the Sky"
            CourseConnection = RainbowRide, Two }
        | CoinsAmassedInAMaze ->
          { Name = "Coins Amassed in a Maze"
            CourseConnection = RainbowRide, Three }
        | SwinginInTheBreeze ->
          { Name = "Swingin' in the Breeze"
            CourseConnection = RainbowRide, Four }
        | TrickyTriangles ->
          { Name = "Tricky Triangles"
            CourseConnection = RainbowRide, Five }
        | SomewhereOverTheRainbow ->
          { Name = "Somewhere Over the Rainbow"
            CourseConnection = RainbowRide, Six }
        
    let getStandardStarsWithInfo =
        standardStarList
        |> List.map(fun star ->
            let starInfo = getStandardCourseStarInfo star
            star, starInfo
        )
    
    let getCourseFromStandardStar (standardCourseStar: StandardCourseStar): StandardCourse =
        let info =  getStandardCourseStarInfo standardCourseStar
        let course, _placement = info.CourseConnection
        course