module SM64.MySpeedrunning

open SM64.Routing

let standardIntro =
    [ ScreenMovement TurnOnSystemAndGetToMarioFace
      ScreenMovement FromMarioFaceToStarSelect
      CastleMovement FromStartToFrontDoor
      CastleMovement FromFrontDoorToBobDoor
      CastleMovement FromBobDoorToBobPainting ]

