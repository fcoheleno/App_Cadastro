using System;
using System.Collections.Generic;
using System.Text;

namespace App_Cadastro
{
    public static class UsuarioLogado
    {
        public static int Id { get; set; }
        public static string Nome { get; set; } 
        public static string Email { get; set; } 

        public static bool EstaLogado => Id > 0 ;
        public static void Logout()
        {
            Id = 0;
            Nome = null;
            Email = null;
        }
    }
}
