let rec quicksort xs =
    match xs with
    | [] -> []
    | first::rest ->
        let smaller =
            rest
            |> List.filter (fun e -> e < first)
            |> quicksort
        let larger =
            rest
            |> List.filter (fun e -> e >= first)
            |> quicksort
        List.concat [smaller ; [first] ; larger]

quicksort [1;5;23;18;9;1;3]


let rec quicksort2 = function
    | [] -> []
    | first::rest ->
        let smaller,larger = List.partition ((>=) first) rest
        List.concat [quicksort2 smaller ; [first] ; quicksort2 larger]

quicksort [1;5;23;18;9;1;3]
