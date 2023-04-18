namespace Adapter
{
    public class PessoaFisica : IPessoaAdapter
    {
        private string CPF;

        public PessoaFisica(string CPF)
        {
            this.CPF = CPF;
        }

        public string GetCpf()
        {
            return CPF;
        }

        public string GetNumero()
        {
            return GetCpf();
        }
    }
}
