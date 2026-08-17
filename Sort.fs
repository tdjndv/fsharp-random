module Sort

let rec quickSort li =
    match li with
    | [] -> []
    | head :: tail ->
        let lower = List.filter (fun x -> x <= head) tail
        let upper = List.filter (fun x -> x >= head) tail
        quickSort lower @ [head] @ quickSort upper