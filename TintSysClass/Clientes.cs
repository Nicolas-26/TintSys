using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Clientes
    {
        //atributos
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime data;
        private bool ativo;

        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get {  return nome; } set {  nome = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime Data { get { return data; } set { data = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }
        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }

        //métodos construtores
        public Clientes() { }
        public Clientes(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }
        public Clientes(string nome, string cpf, string email, DateTime data, bool ativo, List<Telefone> telefones, List<Endereco> enderecos)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
            Telefones = telefones;
            Enderecos = enderecos;
        }
        public Clientes(string nome, string cpf, string email, DateTime data, List<Telefone> telefones, List<Endereco> enderecos)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Telefones = telefones;
            Enderecos = enderecos;
        }
        public Clientes(int id, string nome, string cpf, string email, DateTime data, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
        }

        public Clientes(int id, string nome, string cpf, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }   

        //métodos de acesso
       

        /// <summary>
        /// Método para inserir meus elementos na tabela Clientes no Banco de dados,
        /// o Nome, Cpf, Email, Data e Ativo.
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo)" +
                "values ('"+Nome+"','"+Cpf+"','"+Email+"',default, default)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            //foreach (var enderecos in Enderecos)
            //{
            //    enderecos.Inserir(id);
            //}
            //foreach(var telefones in Telefones)
            //{
            //    telefones.Inserir(id);
            //}
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método para listar clientes, caso o usuário escrever as primeiras letras do nome do cliente
        /// aparecerá o cliente especificado pelas letras, caso o usuário não digite as primeiras letras
        /// do cliente a consulta retorna todos os clientes.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<Clientes> Listar(string nome = "")
        {
            List<Clientes> list = null;
            var cmd = Banco.Abrir();
            cmd.CommandType= CommandType.Text;
            if(nome.Length > 0)
            {
                cmd.CommandText = "select * from clientes where nome like '%"+ nome +"%'";
            }
            else
            {
                cmd.CommandText = "select * from clientes order by nome asc";
            }
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                list.Add(new Clientes(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    ));
            }
            Banco.Fechar(cmd);
            return list;
        }

        /// <summary>
        /// Método para chamar por id o cliente especificado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Clientes ObterPorId(int id)
        {
            Clientes cliente = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from clientes where id = " + id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cliente = new Clientes(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    );
            }
            Banco.Fechar(cmd);
            return cliente;
        }

        /// <summary>
        /// Método para alterar os campo nome e ativo do usuário por id.
        /// </summary>
        public void Alterar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set id = @id, nome = @nome, cpf = @cpf, email = @email where id = " + id;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método para Arquivar por id um elemento na tabela clientes do Banco de dados.
        /// </summary>
        /// <param name="id"></param>
        public void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update from clientes set ativo = 0 where id = "+id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método para Restaurar um cliente que estiver Arquivado.
        /// </summary>
        /// <param name="id"></param>
        public void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update from clientes set ativo = 1 where id = "+id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método para excluir por id um elemento na tabela Clientes do Banco de dados.
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from clientes where id = " + id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
