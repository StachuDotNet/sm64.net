module SM64.Tests.Courses

open Expecto

let courseTests = 
    testList "Courses" [
        test "There are fifteen courses" {
            let numberOfKnownCourses = SM64.Courses.courseList.Length
            Expect.equal numberOfKnownCourses 15 "Unexpected number of courses"
        }
    ]