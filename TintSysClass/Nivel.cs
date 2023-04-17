using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System.Data;

namespace TintSysClass
{
    /// <summary>
    /// Classe Nivel serve para aplicar um nivel para um usuario da tabela usuarios
    /// ex: 'id', 'nome' e 'sigla'
    /// </summary>
    public class Nivel
    {
        //atributos (private(-) == public(+) == protected(#))
        //private static int id;
        //private static string nome;
        //private static string sigla;

        //propriedades
        //public static int Id { get { return id; } set { id = value; } }
        //public static string Nome { get { return nome; } set { nome = value; } }
        //public static string Sigla { get { return sigla; } set { sigla = value; } }

        public static int Idd { get; set; }
        public static string Nome { get; set; }
        public static string Sigla { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Siglaa { get; set; }
        //métodos construtores
        public Nivel() { }
        public Nivel(string _nome, string _sigla)
        {
            Name = _nome;
            Siglaa = _sigla;
        }
        public Nivel(int _id, string _nome, string _sigla)
        {
            Id = _id;
            Name = _nome;
            Siglaa = _sigla;
        }

        //métodos de acesso(insert,excluir,alterar..)
        /// <summary>
        /// Método para inserir um nome e uma sigla na tabela Niveis do banco de dados   
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert niveis (nome, sigla) values (@nome, @sigla)";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Name;
            cmd.Parameters.Add("@sigla", MySqlDbType.VarChar).Value = Siglaa;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método para fazer uma pesquisa por Id e busca um nivel no banco.
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public static Nivel ObterPorId(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from niveis where id = @id";
            cmd.Parameters.AddWithValue("@id", _id);
            var dr = cmd.ExecuteReader();
            Nivel nivel = null;
            while (dr.Read())
            {
                nivel = new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    ); 
            }
            return nivel;
        }

        /// <summary>
        /// Método para Listar todos os elementos da tabela Niveis do Banco de dados
        /// </summary>
        /// <returns></returns>
        public static List<Nivel> Listar()
        {
            List<Nivel> lista = new List<Nivel>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lista.Add(new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }

        /// <summary>
        /// Método para atualizar/alterar, um campo na tabela Niveis do Banco de dados
        /// </summary>
        public void Atualizar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = @nome, sigla = @sigla where id = " + id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Name;
            cmd.Parameters.Add("@sigla", MySqlDbType.VarChar).Value = Siglaa;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// exclui um registro desde que o nivel não esteja associado a um usuário
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public static int Excluir(int _id)
        {
            int msg = 0;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from niveis where id = "+_id;
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    msg = 1;
                }
            }
            catch(Exception e)
            {
                if(e.Message.Contains("FOREIGN KEY"))
                msg = 2;
            }  
            Banco.Fechar(cmd);
            return msg;
        }
    }
}
