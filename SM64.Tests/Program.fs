open Expecto

open SM64.Tests.Courses
open SM64.Tests.Stars

let allTests =
  Expecto.Tests.testList "all" [
      courseTests
      starTests
  ]


[<EntryPoint>]
let main args =
  runTestsWithCLIArgs [] args allTests
  
// documentation here: https://github.com/haf/expecto#installing