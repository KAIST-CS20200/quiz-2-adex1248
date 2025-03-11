module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec colrec n step = 
    if n = 1 then step
    elif n % 2 = 0 then colrec (n/2) (step + 1)
    else colrec (3 * n + 1) (step + 1)
  colrec n 0
