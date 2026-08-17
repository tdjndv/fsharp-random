module Tree

type Tree<'T> = 
| Empty
| Node of 'T * Tree<'T> * Tree<'T>

let rec insert value tree =
    match tree with
    | Empty -> Node(value, Empty, Empty)
    | Node(current, left, right) ->
        if value < current then
            Node(current, insert value left, right)
        elif value > current then
            Node(current, left, insert value right)
        else
            tree

let rec contains value tree =
    match tree with
    | Empty -> false
    | Node(current, left, right) ->
        if current = value then
            true
        elif value < current then
            contains value left
        else
            contains value right

let buildFromList list =
    list
    |> List.fold (fun tree value -> insert value tree) Empty

let rec preorder tree =
    match tree with
    | Empty -> printf ""
    | Node(value, left, right) ->
        printfn "%A" value
        preorder left
        preorder right