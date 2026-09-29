using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Cadastro
{
    public static class Conexao
    {
        public static string ConnectionString = "DataSource=192.168.0.100; Port=3050; Database =C:\\FirebirdData\\sistema.fdb; User=SYSDBA; Password=masterkey; Charset=UTF8; Dialetc=3;";

        public static FbConnection AbrirConexao() {
            FbConnection conn = new FbConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
