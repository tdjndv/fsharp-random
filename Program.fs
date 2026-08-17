open System

let random = Random()

let l : List<int> =
    [1..10]
    |> List.map(fun _ -> random.Next(1, 100))

printfn "%A" l

open Sort

let r = quickSort l

printfn "%A" r