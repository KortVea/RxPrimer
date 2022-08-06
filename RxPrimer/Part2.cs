namespace RxPrimer;

public class Part2
{
    [Fact]
    public void range()
    {
        var count = 0;
        var sut = Observable.Range(1, 10);
        sut.Subscribe(_ => count ++);
        
        Assert.Equal(10, count);
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
}