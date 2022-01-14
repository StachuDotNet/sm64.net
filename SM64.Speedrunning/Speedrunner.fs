module SM64.Speedrunning.Speedrunner

open SM64.Speedrunning.Routes

type SpeedrunnerRoutes =
    { ZeroStarRoute: CategoryRoute option
      OneStarRoute: CategoryRoute option
      SixteenStarRoute: CategoryRoute option
      SeventyStarRoute: CategoryRoute option
      OneTwentyStarRoute: CategoryRoute option }

type SpeedrunnerSocialLinks =
    { YouTubeURL: string option
      TwitchUsername: string option
      TwitterUsername: string option }

type Speedrunner =
    { Name: string
      SocialLinks: SpeedrunnerSocialLinks
      Routes: SpeedrunnerRoutes }