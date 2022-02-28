module Tests 
    open Xunit
    open Euler1
    
    [<Theory>]
    [<InlineData(9,true)>]
    [<InlineData(12,true)>]
    [<InlineData(30,true)>]
    [<InlineData(4,false)>]
    [<InlineData(1,false)>]
    [<InlineData(95,false)>]
    let ``Test that multiple of 3 returns correct result`` (input : int, expected : bool) =
        Assert.Equal(multiple3 input, expected)
    

    [<Fact>]
    let ``Test that multiple of 5 returns true for 5`` () =
        Assert.True(multiple5 5)

    [<Fact>]
    let ``Test that multiple of 5 returns true for 10`` () =
        Assert.True(multiple5 10)

    [<Fact>]
    let ``Test that multiple of 5 returns false for 21`` () =
        Assert.False(multiple5 21)

    [<Fact>]
    let ``Test that multiple3or5 returns true for 15`` () =
        Assert.True(multiple3or5 15)
        
    [<Theory>]
    [<InlineData(10,23)>]
    [<InlineData(1000, 233168)>]
    let ``Test that first implementation returns expected values`` (max : int, expected : int) =
        let result = sumOfNaturals max
        Assert.Equal(result, expected)
    
    [<Theory>]
    [<InlineData(10,23)>]
    [<InlineData(1000, 233168)>]
    let ``Test that second implementation returns expected values`` (max : int, expected : int) =
        let result = sumOfNaturals2 max
        Assert.Equal(result, expected)
