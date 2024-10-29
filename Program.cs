using System.ComponentModel.Design;

namespace EcommercePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("BEM VINDO AO MEU ERP DE VENDAS DE CELULARES");
                Console.WriteLine("CADASTRO GERAL DO SISTEMA");
                Console.WriteLine("(1) - Cadastro de Categorias");
                Console.WriteLine("(2) - Cadastro de Fornecedor");
                Console.WriteLine("(3) - Cadastro de Produtos");
                Console.WriteLine("(4) - Listar Categorias");
                Console.WriteLine("(5) - Listar Fornecedor");
                Console.WriteLine("(6) - Listar Produto");
                Console.WriteLine("(0) - Sair");

                Console.WriteLine("Digite sua opção:");
                var opcao = Console.ReadLine();

                Console.WriteLine("Informe o Nome da nova Categoria ( Ex: Smartphones,Acessòrios, etc.):");

                switch (opcao)
                {
                  
                }
            }
            while ();
            
        }

        static void separador(string simbolo, int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine(simbolo);
            }
        }

        static void CadastrarCategoria(string[] args)
        {
            int contador = 0;
            var categoria = new Categoria();

            if (contador < 10)
            {
                Console.WriteLine("Digite o nome da nova categoria");
                categoria.Nome = Console.ReadLine();
                contador++
                Console.WriteLine("Informe o id da categoria");
                categoria.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Categoria cadastrada com sucesso");
                
            }
            else
            {
                Console.WriteLine("Limite de categorias atingido");

            }
            
        }
        static void CadastrarFornecedor()
        {
            var fornecedor = new Fornecedor();

            Console.WriteLine("Digite o nome do fornecedor:");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Digite o Id do fornecedor:");
            fornecedor.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Cnpj do fornecedor:");
            fornecedor.Cnpj = Console.ReadLine();
        }
    }
}
