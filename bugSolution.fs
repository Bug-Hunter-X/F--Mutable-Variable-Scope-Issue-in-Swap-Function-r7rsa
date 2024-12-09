let mutable x = 10
let mutable y = 20
let mutable z = 30

let swap x y =
    let temp = x
    x <- y
    y <- temp
    (x, y)

let (x, y) = swap x y
printf "%d %d %d" x y z