namespace SM64.Stars

open SM64.Courses

type Star =
    | ToadStar of ToadStar
    | Standard of StandardCourseStar
    | HundredCoin of StandardCourse
    | SecretStar of SecretStageStar
    | BowserReds of BowserStage
