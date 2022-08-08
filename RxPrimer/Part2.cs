using System.Reactive.Threading.Tasks;

namespace RxPrimer;

public class Part2
{
    [Fact]
    public void timer()
    {
        var result = string.Empty;
        var scheduler = new TestScheduler();
        
        var sut = Observable.Timer(TimeSpan.FromSeconds(1), scheduler);
        sut.Subscribe(i => result += Convert.ToInt32(i).ToString());
        
        Assert.Equal(___, result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);
        Assert.Equal(___, result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(10).Ticks);
        Assert.Equal(___, result);
    }

    [Fact]
    public void generate()
    {
        var result = string.Empty;
        var scheduler = new TestScheduler();

        var sut =
            Observable
                .Generate(
                    0L,
                    i => i < 1,
                    i => i + 1,
                    i => i,
                    scheduler);
        sut.Subscribe(i => result += Convert.ToInt32(i).ToString());
        
        Assert.Equal(___, result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);
        Assert.Equal(___, result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(10).Ticks);
        Assert.Equal(___, result);
    }

    [Fact]
    public void interval()
    {
        var result = string.Empty;
        var scheduler = new TestScheduler();
        var sut = Observable.Interval(TimeSpan.FromSeconds(1), scheduler).Take(5);

        sut.Subscribe(i => result += Convert.ToInt32(i).ToString());
        
        Assert.Equal(___, result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(3).Ticks);
        Assert.Equal(___, result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(30).Ticks);
        Assert.Equal(___, result);
    }

 
    
    
    
    #region Ignore

    private static object ____ = "Please fill in the blank.";
    private static int __ = 100;
    private static string ___ = "Please fill in the blank.";
    
    #endregion
}