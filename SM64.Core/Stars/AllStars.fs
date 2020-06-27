namespace SM64.Stars

open SM64.Courses

// (no, not smash mouth https://www.youtube.com/watch?v=L_jWHffIx5E)

type Star =
    | ToadStar of ToadStar
    | Standard of StandardCourseStar
    | HundredCoin of StandardCourse
    | StandardAndHundred of StandardCourseStar * StandardCourse 
    | SecretStar of SecretStageStar
    | BowserReds of BowserStage
