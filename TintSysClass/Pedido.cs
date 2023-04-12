using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Pedido
    {
        //propriedades
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Clientes Cliente { get; set; }
        public Usuarios Usuario { get; set; }
        public DateTime ArquivadoEm { get; set; }
        public string HashCode { get; set; }

        //Métodos contrutores
        public Pedido() { }
        public Pedido(int id, DateTime data, string status, double desconto, Clientes clientes, Usuarios usuarios, DateTime arquivado_em, string hashCode)
        {
            Id = id;    
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = clientes;
            Usuario = usuarios;
            ArquivadoEm = arquivado_em;
            HashCode = hashCode;
        }
        public Pedido(DateTime data, string status, double desconto, Clientes clientes, Usuarios usuarios, DateTime arquivadoem, string hashCode)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = clientes;
            Usuario = usuarios;
            ArquivadoEm = arquivadoem;
            HashCode = hashCode;
        }
        public Pedido(DateTime data, string status, double desconto, DateTime arquivadoem, string hashCode)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            ArquivadoEm = arquivadoem;
            HashCode = hashCode;
        }
        public Pedido(Clientes cliente, Usuarios usuario)
        {
            Cliente = cliente;
            Usuario = usuario;
        }

        //Métodos de acesso
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert pedidos (data, status, desconto, cliente_id, usuario_id, hashcode)" +
                " values (default, default, 0, @cliente, @usuario, @hashcode)";
            cmd.Parameters.Add("@cliente", MySqlDbType.Int32).Value = Cliente.Id;
            cmd.Parameters.Add("@usuario",MySqlDbType.Int32).Value = Usuario.Id;
            cmd.Parameters.Add("@hashcode", MySqlDbType.VarChar).Value = ObterHashCode(Cliente.Id, Usuario.Id);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);

        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedido where id = " + id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                pedido = new Pedido(
                    dr.GetInt32(0),
                    dr.GetDateTime(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    Clientes.ObterPorId(dr.GetInt32(4)),
                    Usuarios.ObterPorId(dr.GetInt32(5)),
                    dr.GetDateTime(6),
                    dr.GetString(7)
                    );
            }
            Banco.Fechar(cmd);
            return pedido;
        }
        public static List<Pedido> ObterPorCliente(int id)
        {
            List<Pedido> list = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedido where cliente_id = " + id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                list.Add(new Pedido(
                    dr.GetInt32(0),
                    dr.GetDateTime(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    Clientes.ObterPorId(dr.GetInt32(4)),
                    Usuarios.ObterPorId(dr.GetInt32(5)),
                    dr.GetDateTime(6),
                    dr.GetString(7)
                    ));
            }
            Banco.Fechar(cmd);
            return list;
        }
        public static List<Pedido> Listar(string hashcode = "")
        {
            List<Pedido> lista = null;
            var cmd = Banco.Abrir();
            if (hashcode.Length > 0)
                cmd.CommandText = "select * from pedido where hashcode like '%" + hashcode + "'";
            else
                cmd.CommandText = "select * from pedido";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lista.Add(new Pedido(
                    dr.GetInt32(0),
                    dr.GetDateTime(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    Clientes.ObterPorId(dr.GetInt32(4)),
                    Usuarios.ObterPorId(dr.GetInt32(5)),
                    dr.GetDateTime(6),
                    dr.GetString(7)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public void Atualizar()
        {

        }
        public void Arquivar()
        {

        }
        public void Restaurar()
        {

        }
        private string ObterHashCode()
        {
            return "";
        }
    }
}
