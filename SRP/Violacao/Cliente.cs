using System;
using System.Data;
using System.Data.SqlClient; // Importe o namespace para usar as classes SqlCommand e SqlConnection

public class Cliente
{
    public int idCliente { get; set; }
    public string nome { get; set; }
    public string email { get; set; }
    public string CPF { get; set; }

    public string AddCliente()
    {
        // Validação de CPF
        if (CPF.Length != 11)
            return "CPF do Cliente inválido";

        if (!email.Contains("@"))
            return "E-mail informado não é válido";

        var cn = new SqlConnection(); // Crie uma instância de SqlConnection
        var cmd = new SqlCommand();

        cn.ConnectionString = "StringDeConexão"; // Defina a string de conexão correta

        cn.Open(); // Abra a conexão antes de usar

        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "INSERT INTO CLIENTE(NOME, EMAIL, CPF) VALUES (@nome, @email, @cpf)";
        
        cmd.Parameters.AddWithValue("nome", nome);
        cmd.Parameters.AddWithValue("email", email);
        cmd.Parameters.AddWithValue("cpf", CPF);

        cn.Open();
        cmd.ExecuteNonQuery();

        cn.Close(); // Feche a conexão após o uso

        return "Cliente Adicionado com Sucesso";
    }
}
