// Basic list manipulation
let oneToFive = [1;2;3;4;5]
let zeroToFive = 0 :: oneToFive
let zeroToSeven = zeroToFive @ [6;7]


let rec sumList xs =
    match xs with
    | [] -> 0
    | head :: tail -> head + sumList tail

sumList [1;2;3;4]

// Or use reduce
[1;2;3;4] |> List.reduce (+)


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


// Partial application
let hello = printfn "Hello, %s"
let names = ["Alice";"Bob";"Charlie"]
names |> List.iter hello


// Pairwise combiner
type OrderLine = {Qty:int; Total:float}

let orderLines = [
    {Qty=1; Total=20.00}
    {Qty=3; Total=45.05}
    {Qty=10; Total=99.90}
]

let addPair line1 line2 =
    let newQty = line1.Qty + line2.Qty
    let newTotal = line1.Total + line2.Total
    {Qty=newQty; Total=newTotal}

orderLines |> List.reduce addPair
