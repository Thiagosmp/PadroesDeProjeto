namespace Singleton
{
    public class Loop
    {

        public static void Main(String[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Soma soma = Soma.GetInstancia();
                soma.Verificar();
            }
        }
    }

}
