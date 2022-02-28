module Euler1 
    let multiple3 x = x % 3 = 0
    
    let multiple5 x = x % 5 = 0

    let multiple3or5 x =
        multiple3 x || multiple5 x

    let naturalsWhichAreMultiples x = 
        [|1..x-1|]
        |> Array.filter(multiple3or5)

    let sumOfNaturals max =
        naturalsWhichAreMultiples max
        |> Array.sum

    let sumOfNaturals2 max =
        [1..max-1]
        |> Seq.filter (fun x -> (x % 3 = 0) || (x % 5 = 0) )
        |> Seq.sum
