namespace TestComp;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Contador cuenta = new Contador();
        var valor = cuenta.Incrementar();
        Assert.Equal(valor,1);
    }
    [Fact]
    public void Test2()
    {
        Contador cuenta = new Contador();
        var valor = cuenta.Decrementar();
        Assert.Equal(valor,-1);
    }
}
