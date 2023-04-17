using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Endereco
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
        public Cliente Cliente { get; set; }

        //métodos construtores
        public Endereco() { }
        public Endereco(string bairro)
        {
            Bairro= bairro;
        }
        public Endereco(string logradouro, string cep)
        {
            Logradouro = logradouro;
            Cep= cep;
        }
        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
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
        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo, Cliente clientes)
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
            Cliente = clientes;
        }
        public Endereco(string cep, string logradouro, string bairro, string cidade, string estado, string uf, string tipo, Cliente clientes)
        {
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            UF = uf;
            Tipo = tipo;
            Cliente = clientes;
        }
        public Endereco(string cep, string logradouro, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            UF = uf;
            Tipo = tipo;
        }

        //métodos de acesso

        /// <summary>
        /// Método para inserir as informações do meu cliente.
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo, cliente_id)" +
                "values (@cep, @logradouro, default, default, @bairro, @cidade, @estado, @uf, @tipo, @cliente)";
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Bairro;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = Estado;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = UF;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = Cliente.Id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new Endereco();
            List<Endereco> list = new List<Endereco>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos where id = @id";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                endereco.Id = dr.GetInt32(0);
                endereco.Cep = dr.GetString(1);
                endereco.Logradouro = dr.GetString(2);
                endereco.Bairro = dr.GetString(5);
                endereco.Cidade = dr.GetString(6);
                endereco.Estado = dr.GetString(7);
                endereco.UF = dr.GetString(8);
                endereco.Tipo = dr.GetString(9);
                endereco.Cliente = Cliente.ObterPorId(Convert.ToInt32(dr.GetInt32(10)));
                list.Add(endereco);
            }
            Banco.Fechar(cmd);
            return endereco;
        }

        public static List<Endereco> Listar()
        {
            List<Endereco> list = new List<Endereco>();
            Endereco endereco = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                endereco = new Endereco();
                endereco.Id = dr.GetInt32(0);
                endereco.Cep = dr.GetString(1);
                endereco.Logradouro = dr.GetString(2);
                endereco.Bairro = dr.GetString(5);
                endereco.Cidade = dr.GetString(6);
                endereco.Estado = dr.GetString(7);
                endereco.UF = dr.GetString(8);
                endereco.Tipo = dr.GetString(9);
                endereco.Cliente = Cliente.ObterPorId(dr.GetInt32(10));
                list.Add(endereco);
            }
            Banco.Fechar(cmd);
            return list;
        }

        public static List<Endereco> ListarPorCliente(int cliente_id)
        {
            List<Endereco> list = new List<Endereco>();
            Endereco endereco = new Endereco();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                endereco.Id = dr.GetInt32(0);
                endereco.Cep = dr.GetString(1);
                endereco.Logradouro = dr.GetString(2);
                endereco.Bairro = dr.GetString(5);
                endereco.Cidade = dr.GetString(6);
                endereco.Estado = dr.GetString(7);
                endereco.UF = dr.GetString(8);
                endereco.Tipo = dr.GetString(9);
                endereco.Cliente = Cliente.ObterPorId(Convert.ToInt32(dr.GetInt32(10)));
                list.Add(endereco);
            }
            Banco.Fechar(cmd);
            return list;
        }

        public void Atualizar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update enderecos set cep = @cep, logradouro = @logradouro, bairro = @bairro, cidade = @cidade, estado = @estado, uf = @uf, tipo = @tipo where id = " + id;
            cmd.Parameters.AddWithValue("@cep", Cep);
            cmd.Parameters.AddWithValue("@logradouro", Logradouro);
            cmd.Parameters.AddWithValue("@bairro", Bairro);
            cmd.Parameters.AddWithValue("@cidade", Cidade);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@uf", UF);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);  
        }

       
        public Endereco BuscarPorBairro()
        {
            Endereco enderecos = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos where bairro = @bairro";
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Bairro;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                enderecos = new Endereco(
                    dr.GetString(5)
                    );
            }
            Banco.Fechar(cmd);
            return enderecos;
        }

        public Endereco BuscarPorCepERua()
        {
            Endereco enderecos = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos set cep = @cep and logradouro = @logradouro";
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                enderecos = new Endereco(
                    dr.GetString(1),
                    dr.GetString(2)
                    );
            }
            Banco.Fechar(cmd);
            return enderecos;
        }
    }
}
