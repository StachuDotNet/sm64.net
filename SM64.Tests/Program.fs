open Expecto

open SM64.Tests.Courses

let allTests =
  Expecto.Tests.testList "all" [
      courseTests
  ]


[<EntryPoint>]
let main args =
  runTestsWithCLIArgs [] args allTests
  
// documentation here: https://github.com/haf/expecto#installing