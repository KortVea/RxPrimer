namespace RxPrimer;

public class Part1
{
    [Fact]
    public void subject_is_both_observable_and_observer()
    {
        var sut = new Subject<int>();
        sut.Subscribe(i => Assert.Equal(__, i));
        sut.OnNext(10);
    }

    [Fact]
    public void simple_observable()
    {
        var sut = Observable.Return("wassup");
        sut.Subscribe(i => Assert.Equal(___, i));
    }

    [Fact]
    public void observable_creation()
    {
        var foo = "foo";
        var sut = 
            Observable
                .Create<string>(o =>
                {
                    o.OnNext("baz");
                    o.OnCompleted();
                    
                    return Disposable.Create(() =>
                    {
                        foo = "bar";
                    });
                });
        Assert.Equal(___, foo);
        sut.Subscribe(i => Assert.Equal(___, i));
        Assert.Equal(___, foo);
    }

    #region Ignore

    private object _ = "Please fill in the blank.";
    private int __ = 100;
    private string ___ = "Please fill in the blank.";
    

    #endregion
}