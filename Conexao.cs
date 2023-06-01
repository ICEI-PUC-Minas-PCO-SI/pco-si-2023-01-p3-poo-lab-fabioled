using Npgsql;

class Conexao
{
    public void Conectar(string strConexao)
    {

        string connectionString = strConexao;
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            connection.Close();
        }

        Console.WriteLine("Conexão com o banco de dados H2 estabelecida com sucesso.");
        Console.ReadLine();


    }
}