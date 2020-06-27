[<AutoOpen>]
module SM64.Prelude

[<Measure>]
type Second

module DiscriminatedUnionHelper =

    open Microsoft.FSharp.Reflection

    let GetAllUnionCases<'T>() =
        FSharpType.GetUnionCases(typeof<'T>)
        |> Seq.map (fun x -> FSharpValue.MakeUnion(x, Array.zeroCreate(x.GetFields().Length)) :?> 'T)
        |> Seq.toList