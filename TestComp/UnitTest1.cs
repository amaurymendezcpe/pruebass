namespace TestComp;

public class UnitTest1
{
    // ─────────────────────────────────────────────────────────────────
    // RETO 1: Clase Contador
    // Implementa una clase Contador con métodos Incrementar() y Decrementar()
    // que retornen el nuevo valor del contador (inicia en 0).
    // ─────────────────────────────────────────────────────────────────
    [Fact]
    public void Reto1_Contador_Incrementar()
    {
        Contador c = new Contador();
        Assert.Equal(1, c.Incrementar());
    }

    [Fact]
    public void Reto1_Contador_Decrementar()
    {
        Contador c = new Contador();
        Assert.Equal(-1, c.Decrementar());
    }

    // ─────────────────────────────────────────────────────────────────
    // RETO 2: Herencia - Figuras Geométricas
    // Crea una clase base Figura con un método virtual CalcularArea().
    // Derivar Circulo (radio) y Rectangulo (base, altura).
    // ─────────────────────────────────────────────────────────────────
    [Fact]
    public void Reto2_Circulo_CalcularArea()
    {
        Figura f = new Circulo(5);
        double area = f.CalcularArea();
        Assert.Equal(Math.Round(Math.PI * 25, 2), Math.Round(area, 2));
    }

    [Fact]
    public void Reto2_Rectangulo_CalcularArea()
    {
        Figura f = new Rectangulo(4, 6);
        Assert.Equal(24.0, f.CalcularArea());
    }

    // ─────────────────────────────────────────────────────────────────
    // RETO 3: Encapsulamiento - Cuenta Bancaria
    // Clase CuentaBancaria con saldo privado. Métodos: Depositar(monto),
    // Retirar(monto) retorna bool (false si no hay saldo), ObtenerSaldo().
    // ─────────────────────────────────────────────────────────────────
    [Fact]
    public void Reto3_CuentaBancaria_DepositarYRetirar()
    {
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Depositar(1000);
        bool resultado = cuenta.Retirar(400);
        Assert.True(resultado);
        Assert.Equal(600, cuenta.ObtenerSaldo());
    }

    [Fact]
    public void Reto3_CuentaBancaria_RetiroFallido()
    {
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Depositar(100);
        bool resultado = cuenta.Retirar(500);
        Assert.False(resultado);
        Assert.Equal(100, cuenta.ObtenerSaldo());
    }

    // ─────────────────────────────────────────────────────────────────
    // RETO 4: Polimorfismo - Sistema de Empleados
    // Clase base Empleado con propiedad Nombre y método virtual CalcularSalario().
    // Clases: EmpleadoFijo (salario fijo), EmpleadoPorHoras (horas * valorHora).
    // ─────────────────────────────────────────────────────────────────
    [Fact]
    public void Reto4_EmpleadoFijo_Salario()
    {
        Empleado e = new EmpleadoFijo("Ana", 3500000);
        Assert.Equal(3500000, e.CalcularSalario());
    }

    [Fact]
    public void Reto4_EmpleadoPorHoras_Salario()
    {
        Empleado e = new EmpleadoPorHoras("Luis", 160, 25000);
        Assert.Equal(4000000, e.CalcularSalario());
    }

    // ─────────────────────────────────────────────────────────────────
    // RETO 5: Interfaz - Animales
    // Define una interfaz ISonido con método HacerSonido() que retorna string.
    // Implementar en clases Perro ("Guau"), Gato ("Miau") y Vaca ("Muuu").
    // ─────────────────────────────────────────────────────────────────
    [Fact]
    public void Reto5_Perro_HacerSonido()
    {
        ISonido animal = new Perro();
        Assert.Equal("Guau", animal.HacerSonido());
    }

    [Fact]
    public void Reto5_Gato_HacerSonido()
    {
        ISonido animal = new Gato();
        Assert.Equal("Miau", animal.HacerSonido());
    }

    [Fact]
    public void Reto5_Vaca_HacerSonido()
    {
        ISonido animal = new Vaca();
        Assert.Equal("Muuu", animal.HacerSonido());
    }
}


