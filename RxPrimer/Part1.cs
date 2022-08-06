using System.Reactive;

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
    public void it_is_a_stream()
    {
        var count = 0;
        var sut = new Subject<int>();
        sut.Subscribe(_ => count++);
        
        Assert.Equal(__, count);
        sut.OnNext(3);
        sut.OnNext(5);
        Assert.Equal(__, count);
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
        Assert.Equal(___, foo);
        sut.Subscribe(i => Assert.Equal(___, i));
        Assert.Equal(___, foo);
    }

    [Fact]
    public void unsubscribe_disposes_it()
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
        sut.Subscribe();
        // ?
        Assert.Equal("disposed", test);
    }
    
    
    
    
    #region Ignore

    private object ____ = "Please fill in the blank.";
    private int __ = 100;
    private string ___ = "Please fill in the blank.";
    
    
    #endregion
}
