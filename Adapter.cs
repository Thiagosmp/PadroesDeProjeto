namespace Adapter
{
    internal class Adapter
    {
        static void Main(string[] args)
        {
            var Thiago = new PessoaFisica("1231414414-41"); // CPF
            var EmpresaX = new PessoaPJ("12345678901234"); // CNPJ

            var pessoaProcesso = new PessoaProcesso();
            pessoaProcesso.processo(Thiago);
            pessoaProcesso.processo(EmpresaX);
        }

        private class PessoaProcesso
        {
            public void processo(IPessoaAdapter adapter)
            {
                if (adapter.GetNumero() == null)
                {
                    Console.WriteLine("Registro não informado!");
                }
                else
                {
                    Console.WriteLine("Informação Registrada!");
                }
            }
        }
    }
}
