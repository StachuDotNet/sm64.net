namespace SM64.Stars

open SM64.Courses
open SM64.Stars.StandardCourseStars

type Star =
    | Standard of StandardCourseStar
    | HundredCoin of StandardCourse
    | BowserReds of BowserStage
    | SecretStar of SecretStageStar
    | ToadStar of ToadStar
