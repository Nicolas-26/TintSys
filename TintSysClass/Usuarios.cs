using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Usuarios
    {
        //atributos
        private int id;
        private string nome;
        private string email;
        private string senha;
        private Nivel nivel;
        private bool ativo;

        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Senha { get { return senha; } set { senha = value; } }
        public Nivel Nivel { get { return nivel; } set { nivel = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

        //métodos construtores
        public Usuarios() { }
        public Usuarios(string nome, string email, string senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        public Usuarios(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public Usuarios(string nome, string email, string senha, Nivel nivel, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        public Usuarios(int id, string nome, string email, string senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        //métodos de acesso

        /// <summary>
        /// Método para o usuário principal efetuar Login usando email e senha,
        /// e retornando id, nome, email, nivel após fazer Login. 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public static Usuarios EfetuarLogin(string email, string senha)
        {
            Usuarios usuarios = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, nome, email, nivel from usuarios" +
                "where email = @email and senha = md5(@senha) and ativo = 1";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios = new Usuarios();
                usuarios.Id = dr.GetInt32(0);
                usuarios.Nome = dr.GetString(1);
                usuarios.Email = dr.GetString(2);
                usuarios.Nivel = Nivel.ObterPorId(dr.GetInt32(3));
            }
            return usuarios;
        }

        /// <summary>
        /// Método para inserir meus elementos na tabela usuários no Banco de dados.
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert usuarios (nome, email, senha, nivel_id, ativo)" +
                "values (@nome, @email, @senha, @nivel, 1)";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            cmd.Parameters.Add("@nivel", MySqlDbType.Int32).Value = Nivel.Idd;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método para chamar por id o usuário especificado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Usuarios ObterPorId(int id)
        {
            Usuarios usuarios = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where id = "+ id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                usuarios = new Usuarios(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            Banco.Fechar(cmd);
            return usuarios;
        }

        /// <summary>
        /// Método que retorna todos meus elementos ao deixar a pesquisa do nome vazio, caso digite as primeiras
        /// letras do nome retornará apenas o nome Digitado.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static List<Usuarios> Listar(string nome = "")
        {
            List<Usuarios> lista = new List<Usuarios>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome!=string.Empty)
            {
                cmd.CommandText = "select * from usuarios where nome like '%" + nome + "%'";
            }
            else
            {
                cmd.CommandText = "select * from usuarios";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuarios(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        
        /// <summary>
        /// Método para atualizar os campo nome e senha do usuário por id.
        /// </summary>
        public void Atualizar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update usuarios set nome = @nome, email = @email, senha = md5(@senha)" +
                " where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método para Arquivar por id um elemento na tabela usuários do Banco de dados.
        /// </summary>
        /// <param name="_id"></param>
        public void Arquivar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update from usuarios set ativo = 0 where id = "+_id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método para Restaurar um usuário que estiver Arquivado.
        /// </summary>
        /// <param name="_id"></param>
        public void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update from usuarios set ativo = 1 where id = "+_id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método que serve para excluir por id um campo na tabela Usuários do Banco de dados.
        /// </summary>
        /// <param name="_id"></param>
        public void Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from usuarios where id = "+_id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
