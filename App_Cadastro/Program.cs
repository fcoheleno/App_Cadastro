namespace App_Cadastro
{
    internal static class Program
    {
        
        [STAThread]
       public static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new FormInicial());
        }
    }
}