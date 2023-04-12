using MySql.Data.MySqlClient;
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
        public Produto Produtos { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        //Métodos construtores
        public ItemPedido() { }
        public ItemPedido(int id, Produto produtos, double preco, double quantidade, double desconto)
        {
            Id = id;
            Produtos = produtos;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(Produto produtos, double preco, double quantidade, double desconto)
        {
            Produtos = produtos;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert itempedido (pedido_id, produto_id, preco, quantidade, desconto)" +
                " values (@pedido, @produto, @preco, @quantidade, @desconto)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@pedido", MySqlDbType.Int32).Value = Id;
            cmd.Parameters.Add("@produto", MySqlDbType.Int32).Value = Produtos.Id;
            cmd.Parameters.Add("@preco",MySqlDbType.Decimal).Value = Produtos.Preco;
            cmd.Parameters.Add("@quantidade",MySqlDbType.Decimal).Value = Quantidade;
            cmd.Parameters.Add("@desconto",MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
