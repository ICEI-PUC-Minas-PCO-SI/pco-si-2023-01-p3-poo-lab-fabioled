public class Questao5
{
    public delegate double Operacacoes(double a, double b);
    public delegate double RegistroOperacao(double resultado);
    public static event RegistroOperacao OcorrenciaDaOperacao;
    public static double Somar(double a, double b)
    {
        double resultado;
        resultado = a + b;
        OcorrenciaDaOperacao?.Invoke(resultado);
        return resultado;
    }

    public static double Subtrair(double a, double b)
    {
        double resultado;
        resultado = a - b;
        OcorrenciaDaOperacao?.Invoke(resultado);
        return resultado;
    }

    public static void Executar()
    {
        Console.WriteLine("Aninhamento de Delegates");

        //OcorrenciaDaOperacao += MostrarResultado;
        //OcorrenciaDaOperacao += EnviarResultado;

        Operacacoes operacacoes = Somar;
        operacacoes += Subtrair;
        operacacoes += (x, y) =>
        {
            double resultado;
            resultado = x / y;
            OcorrenciaDaOperacao?.Invoke(resultado);
            return resultado;
        };

        operacacoes(3, 5);
    }
    public static void MostrarResultado(double resultado)
    {
        Console.WriteLine($"O Resultado é: {resultado}");
    }

    public static void EnviarResultado(double resultado)
    {
        Console.WriteLine($"Enviando resultado : {resultado}");
    }
}