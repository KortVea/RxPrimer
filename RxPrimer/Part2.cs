using System.Reactive.Threading.Tasks;

namespace RxPrimer;

public class Part2
{
    [Fact]
    public void simple_timer()
    {
        var result = string.Empty;
        var scheduler = new TestScheduler();
        
        var sut = Observable.Timer(TimeSpan.FromSeconds(1), scheduler);
        sut.Subscribe(i => result += Convert.ToInt32(i).ToString());
        
        Assert.Equal(string.Empty, result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);
        Assert.Equal("1", result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(10).Ticks);
        Assert.Equal("1", result);
    }

    [Fact]
    public void generate_is_more_versatile()
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
        
        Assert.Equal(string.Empty, result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);
        Assert.Equal("1", result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(10).Ticks);
        Assert.Equal("1", result);
    }

    [Fact]
    public void interval_is_another_timer()
    {
        var result = string.Empty;
        var scheduler = new TestScheduler();
        var sut = Observable.Interval(TimeSpan.FromSeconds(1), scheduler).Take(5);

        sut.Subscribe(i => result += Convert.ToInt32(i).ToString());
        
        Assert.Equal(string.Empty, result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(3).Ticks);
        Assert.Equal("123", result);
        scheduler.AdvanceBy(TimeSpan.FromSeconds(30).Ticks);
        Assert.Equal("12345", result);
    }

 
    
    
    
    #region Ignore

    private static object ____ = "Please fill in the blank.";
    private static int __ = 100;
    private static string ___ = "Please fill in the blank.";
    
    #endregion
}