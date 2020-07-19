module SM64.Net.Views.StandardCourseStar

open Feliz.ViewEngine
open SM64.Core
open SM64.Courses
open SM64.Stars.StandardCourseStars

let view((courseAbbr: string), (starNumber: int)) =
    let standardCourse =
        // TODO: find course from abbreviation
        StandardCourse.BobOmbBattlefield
        
    let standardCourseStar =
        // TODO: find star from standardCourse and starNumber
        StandardCourseStar.BigBobOmbOnTheSummit
        
    let courseInfo = getInfoForStandardCourse SupportedGameRelease.NA standardCourse
    let courseName = courseInfo.Name
    let standardStarInfo = StandardCourseStar.getStandardCourseStarInfo standardCourseStar
    let starName = standardStarInfo.Name
    
    Html.div [
        Html.h1 (sprintf "%s - Star #%i: %s" courseName starNumber starName)
        Html.text ":shrug:"
    ]