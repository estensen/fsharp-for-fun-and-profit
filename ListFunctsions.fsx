// Basic list manipulation
let oneToFive = [1;2;3;4;5]
let zeroToFive = 0 :: oneToFive
let zeroToSeven = zeroToFive @ [6;7]


let rec sumList xs =
    match xs with
    | [] -> 0
    | head :: tail -> head + sumList tail

sumList [1;2;3;4]


// Types can often be infered
let rec prodList (xs : int list) =
    match xs with
    | [] -> 1
    | head :: tail -> head * prodList tail

prodList [1;2;3;4]


let square x = x * x

let sumOfSquares n =
    [1..n]
    |> List.map square
    |> List.sum

sumOfSquares 100
