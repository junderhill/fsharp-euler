module Program
    open Euler1
    [<EntryPoint>]
    let main args = 
        let max = args[0] |> int
        let sum = sumOfNaturals2 max
        printf $"Sum of natural numbers which are multiples of 3 or 5 to %i{max} is %i{sum}"
        0