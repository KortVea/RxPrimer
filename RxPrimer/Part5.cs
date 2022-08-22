namespace RxPrimer;

public class Part5
{
    [Fact]
    public void not_sharing()
    {
        var count = 0;
        var scheduler = new TestScheduler();
        var sut = 
                Observable
                    .Timer(TimeSpan.FromSeconds(5), scheduler)
                    .Do(_ => count++);
        
        sut.Subscribe();
        scheduler.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);
        sut.Subscribe();
        scheduler.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);
        
        Assert.Equal(0, count);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(3).Ticks);
        Assert.Equal(1, count);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);
        Assert.Equal(2, count);
    }
    


    #region Ignore

    private static object ____ = "Please fill in the blank.";
    private static int __ = 100;
    private static string ___ = "Please fill in the blank.";
    
    #endregion
}