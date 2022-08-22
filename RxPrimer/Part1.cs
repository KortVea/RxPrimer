namespace RxPrimer;

public class Part1
{
    [Fact]
    public void subject_is_both_observable_and_observer()
    {
        var sut = new Subject<int>();
        sut.Subscribe(i => Assert.Equal(10, i));
        sut.OnNext(10);
    }

    [Fact]
    public void behavior_subject_is_cache_1()
    {
        var sut = new BehaviorSubject<string>("initial");
        sut.Subscribe(i => Assert.Equal("initial", i));
    }

    [Fact]
    public void simple_observable()
    {
        var sut = Observable.Return("wassup");
        sut.Subscribe(i => Assert.Equal("wassup", i));
    }

    [Fact]
    public void it_is_a_stream()
    {
        var count = 0;
        var sut = new Subject<int>();
        sut.Subscribe(_ => count++);
        
        Assert.Equal(0, count);
        sut.OnNext(3);
        sut.OnNext(5);
        Assert.Equal(2, count);
    }

    [Fact]
    public void observable_creation()
    {
        var foo = "foo";
        var sut = 
            Observable
                .Create<string>(
                    o =>
                    {
                        o.OnNext("baz");
                        o.OnCompleted();
                        
                        return Disposable.Create(() =>
                        {
                            foo = "bar";
                        });
                    });
        Assert.Equal("foo", foo);
        sut.Subscribe(i => Assert.Equal("baz", i));
        Assert.Equal("bar", foo);
    }

    [Fact]
    public void unsubscribe_disposes()
    {
        var test = "";
        var sut =
            Observable
                .Create<string>(
                    o =>
                    {
                        o.OnNext("first");
                        return () =>
                        {
                            test = "disposed";
                        };
                    });
        var sub = sut.Subscribe();
        sub.Dispose();
        Assert.Equal("disposed", test);
    }
    
    
    
    
    #region Ignore

    private static object ____ = "Please fill in the blank.";
    private static int __ = 100;
    private static string ___ = "Please fill in the blank.";
    
    #endregion
}
