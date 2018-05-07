using System.ComponentModel.DataAnnotations.Schema;

namespace Mapeamento1NEntityFramework
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
