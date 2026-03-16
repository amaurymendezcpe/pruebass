namespace TestComp;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Contador cuenta = Contador();
        var valor = cuenta.Incrementar();
        Assert.Equal(valor,1);
    }
}
