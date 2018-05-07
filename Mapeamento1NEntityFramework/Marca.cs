using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapeamento1NEntityFramework
{
    [Table("Marca")]
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

        public Marca()
        {
            Produtos = new List<Produto>();
        }
    }
}
