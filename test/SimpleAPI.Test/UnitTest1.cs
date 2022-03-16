using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new  WeatherForecastController();

    [Fact]
    public void GetReturnMyName(){
        var returnValue = controller.Get(1);
        Assert.Equal("Hemant", returnValue.Value);
    }


    [Fact]
    public void Test1()
    {

    }
}