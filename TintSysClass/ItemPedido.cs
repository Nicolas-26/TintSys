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
        public Produto Produto { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        //Métodos construtores
        public ItemPedido() { }
        public ItemPedido(int id, Produto produtos, double preco, double quantidade, double desconto)
        {
            Id = id;
            Produto = produtos;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(Produto produtos, double preco, double quantidade, double desconto)
        {
            Produto = produtos;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert itempedido (pedido_id, produto_id, preco, quantidade, desconto)" +
                " values (@pedido, @produto, @preco, @quantidade, @desconto)";
            cmd.Parameters.Add("@pedido", MySqlDbType.Int32).Value = Id;
            cmd.Parameters.Add("@produto", MySqlDbType.Int32).Value = Produto.Id;
            cmd.Parameters.Add("@preco",MySqlDbType.Double).Value = Produto.Preco;
            cmd.Parameters.Add("@quantidade",MySqlDbType.Double).Value = Quantidade;
            cmd.Parameters.Add("@desconto",MySqlDbType.Double).Value = Desconto;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        public static ItemPedido BuscarPorProdutoPedido(int pedido_id, int produto_id)
        {
            ItemPedido item = new ItemPedido();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido where pedido_id = @pedido, produto_id = @produto";
            cmd.Parameters.Add("@pedido", MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("produto",MySqlDbType.Int32).Value = produto_id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                item.Id = dr.GetInt32(0);
                item.Produto = Produto.ObterPorId(dr.GetInt32(2));
                item.Preco = dr.GetDouble(3);
                item.Quantidade = dr.GetDouble(4);
                item.Desconto = dr.GetDouble(5);
            }
            return item;
        }

        public static List<ItemPedido> ListarPorPedido(int pedido_id)
        {
            ItemPedido item = null;
            List<ItemPedido> itens = new List<ItemPedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido where pedido_id = @pedido";
            cmd.Parameters.Add("@pedido",MySqlDbType.Int32).Value = pedido_id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                item = new ItemPedido();
                item.Id = dr.GetInt32(0);
                item.Produto = Produto.ObterPorId(dr.GetInt32(2));
                item.Preco = dr.GetDouble(3);
                item.Quantidade = dr.GetDouble(4);
                item.Desconto = dr.GetDouble(5);
                itens.Add(item);
            }
            return itens;
        }

        public static List<ItemPedido> Listar()
        {
            ItemPedido item = null;
            List<ItemPedido> itens = new List<ItemPedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Id = dr.GetInt32(0);
                item.Produto = Produto.ObterPorId(dr.GetInt32(2));
                item.Preco = dr.GetDouble(3);
                item.Quantidade = dr.GetDouble(4);
                item.Desconto = dr.GetDouble(5);
                itens.Add(item);
            }
            return itens;
        }

        public void Alterar(int pedido_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update itempedido set quantidade = @quantidade, desconto = @desconto"+
                " where pedido_id = @pedido and produto_id = @produto";
            cmd.Parameters.Add("@pedido",MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("@produto", MySqlDbType.Int32).Value = Produto.Id;
            cmd.Parameters.Add("@quantidade", MySqlDbType.Double).Value = Quantidade;
            cmd.Parameters.Add("@desconto",MySqlDbType.Double).Value = Desconto;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        public void Excluir(int pedido_id, int produto_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete itempedido where pedido_id = @pedido and produto_id = @produto";
            cmd.Parameters.Add("pedido",MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("pedido", MySqlDbType.Int32).Value = pedido_id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

    }
}
