using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Enderecos
    {
        //atributos
        private int id;
        private string cep;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string uf;
        private string tipo;
        private Clientes clientes;

        //propriedades
        public int Id { get { return id; } set {  id = value; } }
        public string Cep { get {  return cep; } set {  cep = value; } }
        public string Logradouro { get {  return logradouro; } set {  logradouro = value; } }
        public string Numero { get {  return numero; } set {  numero = value; } }
        public string Complemento { get { return complemento; } set {  complemento = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Cidade { get { return cidade; } set {  cidade = value; } }
        public string Estado { get { return estado; } set {  estado = value; } }
        public string UF { get { return uf; } set { uf = value; } }
        public string Tipo { get { return tipo; } set {  tipo = value; } }
        public Clientes Clientes { get; set; }

        //métodos construtores
        public Enderecos() { }
        public Enderecos(string bairro)
        {
            Bairro= bairro;
        }
        public Enderecos(string logradouro, string cep)
        {
            Logradouro = logradouro;
            Cep= cep;
        }
        public Enderecos(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            UF = uf;
            Tipo = tipo;
        }
        public Enderecos(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo, Clientes clientes)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            UF = uf;
            Tipo = tipo;
            Clientes = clientes;
        }

        //métodos de acesso

        /// <summary>
        /// Método para inserir as informações do meu cliente.
        /// </summary>
        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos (cliente_id, cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo)" +
                "values ("+cliente_id+",'"+Cep+"','"+Logradouro+"','"+Numero+"','"+Complemento+"','"+Bairro+"','"+Cidade+"','"+Estado+"','"+UF+"','"+Tipo+"')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        public static List<Enderecos> ListarPorCliente(int cliente_id)
        {
            List<Enderecos> list = new List<Enderecos>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                list.Add(new Enderecos(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9)
                    ));
            }
            return list;
        }

        public Enderecos BuscarPorBairro()
        {
            Enderecos enderecos = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select from enderecos where bairro = @bairro";
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Bairro;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                enderecos = new Enderecos(
                    dr.GetString(5)
                    );
            }
            Banco.Fechar(cmd);
            return enderecos;
        }

        public Enderecos BuscarPorCepERua()
        {
            Enderecos enderecos = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select from enderecos set cep = @cep and logradouro = @logradouro";
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                enderecos = new Enderecos(
                    dr.GetString(1),
                    dr.GetString(2)
                    );
            }
            Banco.Fechar(cmd);
            return enderecos;
        }
    }
}
