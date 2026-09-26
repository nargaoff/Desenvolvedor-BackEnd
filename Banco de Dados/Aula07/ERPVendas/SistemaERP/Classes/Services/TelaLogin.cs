namespace SistemaERP.Classes.Services
{
    internal static class TelaLogin
    {
        //Campo
        static Login login;

        //Metodo
        public static void AbrirTela()
        {
            login = new Login();
            login.Show();
        }

    }
}
