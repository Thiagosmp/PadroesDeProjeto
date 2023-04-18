namespace Singleton
{
    public class Soma
    {
        private static Soma instancia;
        private static int numero = 2;

        private Soma() { }

        public static Soma GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Soma();
            }
            numero += numero;
            return instancia;
        }

        public void Verificar()
        {
            Console.WriteLine("Soma: " + numero);
        }
    }

}
