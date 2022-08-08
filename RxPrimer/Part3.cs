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

        sut.Subscribe(i =>
        {
            Assert.Equal(__, i);
            count += 1;
        });
        
        Assert.Equal(__, count);
    }
    
    
    
    #region Ignore

    private static object ____ = "Please fill in the blank.";
    private static int __ = 100;
    private static string ___ = "Please fill in the blank.";
    
    #endregion
}