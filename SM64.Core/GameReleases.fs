namespace SM64.Core

open System

/// Which release of SM64 are we talking about?
type GameRelease = | JP | NA | EU | IQue

/// Releases of Super Mario 64 that this software "supports" (care about)
type SupportedGameRelease =
    | NA
    // TODO: support others (well, at least japan

type GameReleaseInfo =
    { Name: string
      Abbreviation: string
      ReleaseDate: DateTime }

module GameRelease =
    let getGameReleaseInfo (gameRelease: GameRelease) =
        match gameRelease with
        | GameRelease.NA ->
            { Name = "North America"
              Abbreviation = "NA"
              ReleaseDate = DateTime(1996, 09, 29) }
        | GameRelease.JP ->
            { Name = "Japan"
              Abbreviation = "JP"
              ReleaseDate = DateTime(1996, 06, 23) }
        | GameRelease.EU ->
            { Name = "Europe"
              Abbreviation = "EU"
              ReleaseDate = DateTime(1997, 03, 01) }
        | GameRelease.IQue ->
            { Name = "iQue (China-only)"
              Abbreviation = "iQue"
              ReleaseDate = DateTime(2003, 11, 21) }