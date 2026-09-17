using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Cadastro
{
    public static class Conexao
    {
        public static string ConnectionString = "User=SYSDBA;Password=masterkey;Database=C:\\Bancos\\usuarios.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";

        public static FbConnection AbrirConexao() {
            FbConnection conn = new FbConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
