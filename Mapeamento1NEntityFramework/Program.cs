using System;

namespace Mapeamento1NEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new LojaContext();

            var marca = new Marca
            {
                Nome = "Honda"
            };

            marca.Produtos.Add(new Produto
            {
                Nome = "Biz 125",
                Preco = 9000
            });

            ctx.Marcas.Add(marca);
            ctx.SaveChanges();
            Console.ReadLine();
        }
    }
}
