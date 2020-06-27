module SM64.Tests.Stars

open Expecto

let starTests =
    testList "Stars" [

      test "There are 7 'standard' stars per course" {
          let numberOfKnownCourses = SM64.Courses.courseList.Length
          let numberOfKnownStandardStars = SM64.Stars.StandardCourseStar.standardStarList.Length
          
          let expectedNumberOfStandardCourses = numberOfKnownCourses * 7
          Expect.equal numberOfKnownStandardStars expectedNumberOfStandardCourses "Unexpected number of 'standard' stars"
      }

    ]
    //|> testLabel "Stars"