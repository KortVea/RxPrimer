namespace RxPrimer;

public class Part4
{
    [Fact]
    public void range()
    {
        var count = 0;
        var sut = Observable.Range(1, 10);
        sut.Subscribe(_ => count ++);
        
        Assert.Equal(__, count);
    }
    
    [Fact]
    public void range_2()
    {
        var count = 0;
        var scheduler = new TestScheduler();
        var sut = Observable.Range(1, 10, scheduler);
        sut.Subscribe(_ => count ++);
        // what does scheduler do here? 
        Assert.Equal(10, count);
    }
    
    [Fact]
    public void Linq()
    {
        var numbers = Observable.Range(1, 100);
        var results = 
            from x in numbers
            where x % __ == 0
            select x.ToString();

        var strings = results.ToEnumerable().ToArray();
        Assert.Equal("11,22,33,44,55,66,77,88,99", string.Join(",", strings));
    }
    
    #region Ignore

    private static object ____ = "Please fill in the blank.";
    private static int __ = 100;
    private static string ___ = "Please fill in the blank.";
    
    #endregion
}