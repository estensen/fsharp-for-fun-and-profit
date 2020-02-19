// Simple function
let add x y = x + y
add 1 2

let square x = x * x
let twoSquared = square 2
printfn "2 squared is %i" twoSquared

// Recursive function
let rec pow x y = 
    if y = 0
    then 1
    else x * pow x (y-1)
pow 10 3

let cube x =
    pow x 3
cube 2


// Every multi parameter function can be converted into
// a on parameter function
let add1 = (+) 1
add1 2

