public class Questao4
{
    public delegate double Operacacoes(double a, double b);
    public static double Somar(double a, double b){
        double resultado;
        resultado = a + b;
        Console.WriteLine($"Resultado de {a} + {b} é: {resultado}");
        return resultado;
    }

    public static double Subtrair(double a, double b){
        double resultado;
        resultado = a - b;
        Console.WriteLine($"Resultado de {a} - {b} é: {resultado}");
        return resultado;
    }
    public static void Executar(){
        Console.WriteLine("Aninhamento de Delegates");

        Operacacoes operacacoes = Somar;
        operacacoes+=Subtrair;
        operacacoes+=(delegate (double x, double y)
        {
            double resultado;
            resultado = x / y;
            Console.WriteLine($"Resultado de {x} / {y} é: {resultado}");
            return resultado;
        });

        operacacoes(3,5);

    }
}