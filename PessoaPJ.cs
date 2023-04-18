namespace Adapter
{
    public class PessoaPJ : IPessoaAdapter
    {
        private string CNPJ;

        public PessoaPJ(string CNPJ)
        {
            this.CNPJ = CNPJ;
        }

        public string GetCNPJ()
        {
            return CNPJ;
        }
        public string GetNumero()
        {
            return GetCNPJ();
        }
    }

}
