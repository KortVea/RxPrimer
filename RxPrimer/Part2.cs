namespace RxPrimer;

public class Part2
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
        // ?
        Assert.Equal(10, count);
    }
    
    
    
    #region Ignore

    private static object ____ = "Please fill in the blank.";
    private static int __ = 100;
    private static string ___ = "Please fill in the blank.";
    
    #endregion
}