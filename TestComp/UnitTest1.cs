namespace TestComp;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Contador cuenta = Contador();
        Assert.Equal(cuenta.valor,1);
    }
}
