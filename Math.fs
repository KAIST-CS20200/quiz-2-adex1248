module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec colrec n step = 
    //printfn "%d" step
    if n = 1UL then step
    elif n % 2UL = 0UL then colrec (n/2UL) (step + 1UL)
    else colrec (3UL * n + 1UL) (step + 1UL)
  let nUL = uint64 n
  int (colrec nUL 0UL)
