public class Questao2
{
   
    public static void Executar(){
        Console.WriteLine("Exemplo 2 -----------: ");

        ProcessoSincrono processo = new ProcessoSincrono();
        CallbackHandler callbackHandler = new CallbackHandler();

        // Chama a operação assíncrona passando a função de callback
        processo.RealizarOperacao(5, callbackHandler.MostrarResultado);

        Console.WriteLine("Execução continua enquanto a operação é realizada...");
        
        Console.ReadLine();

    }
}