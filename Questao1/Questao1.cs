class Questao1
{
    delegate int CalcularDelegate(int a, int b);
    public static void Executar(){
        Console.WriteLine("Atividade 1 -----------: ");

        // Cria uma instância do delegate CalcularDelegate
        CalcularDelegate calcular;

        // Atribui o método Soma ao delegate
        calcular = Calculadora.Soma;
        int resultadoSoma = calcular(5, 3);
        Console.WriteLine("Resultado da soma: " + resultadoSoma);

        // Atribui o método Subtracao ao delegate
        calcular = Calculadora.Subtracao;
        int resultadoSubtracao = calcular(10, 4);
        Console.WriteLine("Resultado da subtração: " + resultadoSubtracao);

        Console.ReadLine();



    }
    
}