using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePOO
{
    internal class Produto
    {
       public int Id { get; set; }
       public string nome { get; set; }
       public string Descricao { get; set; }
       public double Preco { get; set;}
       public DateTime Validade { get; set; }
       public Categoria Categoria { get; set; }
       public Fornecedor Fornecedor { get; set; }

    }
}
