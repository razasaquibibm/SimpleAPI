using SimpleAPI;
namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController valuesController=new ValuesController();
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void GetReturnedCollectNumber()
    {
        var getValue= valuesController.Get(1);//act
        Assert.Equal("saquib",getValue);
    }
}