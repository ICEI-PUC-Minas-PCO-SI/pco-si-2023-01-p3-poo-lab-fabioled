
public class ProcessoSincrono
{
    public void RealizarOperacao(int valor, Delegates.Callback callback)
    {
        Console.WriteLine("Realizando operação assíncrona...");

        // Simulação de uma operação demorada
        System.Threading.Thread.Sleep(3000);
        int resultado = valor * 10;
        callback(resultado); // Chama a função de callback com o resultado
    }
}