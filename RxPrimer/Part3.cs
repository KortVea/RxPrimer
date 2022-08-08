namespace RxPrimer;

public class Part3
{
    [Fact]
    public void filter()
    {
        bool IsEven(int i) => i % 2 == 0;
        var count = 0;

        var sut =
            Observable
                .Create<int>(o =>
                {
                    o.OnNext(1);
                    o.OnNext(1);
                    o.OnNext(2);
                    o.OnNext(2);
                    o.OnNext(3);
                    o.OnNext(3);
                    return Disposable.Empty;
                })
                .Skip(1)
                .SkipLast(2)
                .Where(IsEven)
                .DistinctUntilChanged();

        sut
            .Do(i => count += 1)
            .Subscribe(i => Assert.Equal(__, i));

        Assert.Equal(__, count);
        Assert.Equal(10, count);
    }

    [Fact]
    public void count_with_aggregate()
    {
        var source = Observable.Range(0, 10);
        var sut = source
            .Aggregate(0, (acc, next) => acc + 1);
        var count = 0;
        sut
            .Do(_ => count += 1)
            .Subscribe(i => Assert.Equal(__, i),
            () => Assert.Equal(__, count));
    }

    [Fact]
    public void max_with_scan()
    {
        var source = Observable.Range(0, 5);
        var sut = source
            .Scan(0, (acc, next) => next > acc ? next : acc);
        var count = 0;
        var result = string.Empty;
        sut
            .Do(_ => count += 1)
            .Select(i => result += i)
            .Subscribe(i => { },
                () => Assert.Equal(__, count));
        // Scan isn't blocking, why are you seeing what you see?
        Assert.Equal(___, result);
    }
    
    

    #region Ignore

    private static object ____ = "Please fill in the blank.";
    private static int __ = 100;
    private static string ___ = "Please fill in the blank.";

    #endregion
}