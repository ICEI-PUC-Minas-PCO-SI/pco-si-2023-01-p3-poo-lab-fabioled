public class Questao3
{
    public delegate double Operacacoes(double a, double b);

    public static double Somar(double a, double b)
    {
        double resultado;
        resultado = a + b;
        Console.WriteLine($"Resultado de {a} + {b} é: {resultado}");
        return resultado;
    }

    public static double Subtrair(double a, double b)
    {
        double resultado;
        resultado = a - b;
        Console.WriteLine($"Resultado de {a} - {b} é: {resultado}");
        return resultado;
    }
    public static void Executar()
    {
        Console.WriteLine("Estruturas Homogeneas com Delegates");

        List<Operacacoes> listaOperacoes = new List<Operacacoes>();

        listaOperacoes.Add(new Operacacoes(Somar));
        listaOperacoes.Add(new Operacacoes(Subtrair));

        listaOperacoes.Add(delegate (double x, double y)
        {
            double resultado;
            resultado = x / y;
            Console.WriteLine($"Resultado de {x} / {y} é: {resultado}");
            return resultado;
        });

        foreach (var item in listaOperacoes)
        {
            item(10, 6);
            item(2, 2);
            Console.WriteLine();
        }

    }
}