class TesteSRP

{
    public static void Executar(){
        Console.WriteLine("Exemplos SRP ");

        Cliente cliente = new Cliente();

        cliente.nome = "Fábio";
        cliente.email = "fabiopucminas.br";
        cliente.CPF = "02345678901";

        cliente.AddCliente();
    }
    
}