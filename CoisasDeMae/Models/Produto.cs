using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoisasDeMae.Models
{
    public class Produto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProdutoID { get; set; }
        public string Categoria { get; set; }
        public int Preco { get; set; }
        public string Nome { get; set; }

        public ICollection<Pedido> Enrollments { get; set; }
    }
}

