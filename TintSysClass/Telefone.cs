using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Telefone
    {
        //atributos
        private int id;
        private string numero;
        private string tipo;

        //propriedades
        public int Id { get { return id; } set {  id = value; } }
        public string Numero { get { return numero; } set {  numero = value; } }
        public string Tipo { get {  return tipo; } set {  tipo = value; } }
        public Cliente Cliente { get; set; } 

        //métodos construtores
        public Telefone() { }
        public Telefone(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }
        public Telefone(int id, string numero, string tipo, Cliente cliente)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
            Cliente = cliente;
        }
        public Telefone(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }
        //métodos de acesso

        /// <summary>
        /// Método para inserir o telefone do Cliente cujo está em outra tabela.
        /// </summary>
        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones (numero, tipo, cliente_id)" +
                " values (@numero, @tipo, @cliente)";
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@cliente", MySqlDbType.Int32).Value = cliente_id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        public static Telefone ObterPorId(int id)
        {
            Telefone telefone = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from telefones where id = " + id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                telefone = new Telefone(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Cliente.ObterPorId(dr.GetInt32(3))
                    );
            }
            Banco.Fechar(cmd);
            return telefone;
        }

        /// <summary>
        /// Método para buscar por id o telefone do Cliente.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Telefone> ListarPorCliente(int cliente_id)
        {
            List<Telefone> telefones = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, numero, tipo from telefones where ciente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                telefones.Add(new Telefone(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    ));
            }
            Banco.Fechar(cmd);
            return telefones;
        }

        public static List<Telefone> Listar()
        {
            List<Telefone> teles = new List<Telefone>();
            Telefone tel = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from telefones";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                tel = new Telefone();
                tel.Id = dr.GetInt32(0);
                tel.Numero = dr.GetString(1);
                tel.Tipo = dr.GetString(2);
                tel.Cliente = Cliente.ObterPorId(dr.GetInt32(3));
                teles.Add(tel);
            }
            Banco.Fechar(cmd);
            return teles;
        }

        public void Atualizar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefones set numero = @numero, tipo = @tipo where id = " + id;
            cmd.Parameters.Add("@numero",MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@tipo",MySqlDbType.VarChar).Value = Tipo;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
      
    }
}
