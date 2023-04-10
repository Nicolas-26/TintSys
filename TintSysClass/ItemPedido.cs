using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class ItemPedido
    {
        //atributos 
        private int id;

        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public Pedido Pedidos { get; set; }
        public Produto Produtos { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        //Métodos construtores
        public ItemPedido() { }
        public ItemPedido(int id, Pedido pedidos, Produto produtos, double preco, double quantidade, double desconto)
        {
            Id = id;
            Pedidos = pedidos;
            Produtos = produtos;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }
    }
}
