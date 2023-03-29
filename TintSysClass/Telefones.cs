using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Telefones
    {
        //atributos
        private int id;
        private string numero;
        private string tipo;
        private Clientes clientes;

        //propriedades
        public int Id { get { return id; } set {  id = value; } }
        public string Numero { get { return numero; } set {  numero = value; } }
        public string Tipo { get {  return tipo; } set {  tipo = value; } }
        public Clientes Clientes { get { return clientes; } set { clientes = value; } } 

        //métodos construtores
        public Telefones() { }
        public Telefones(string numero, string tipo)
        {
            this.numero = Numero;
            this.tipo = Tipo;
        }
        public Telefones(int id, string numero, string tipo, Clientes clientes)
        {
            this.id = Id;
            this.numero = Numero;
            this.tipo = Tipo;
            this.clientes = Clientes;
        }

        //métodos de acesso

        /// <summary>
        /// Método para inserir o telefone do Cliente cujo está em outra tabela.
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones (numero, tipo, cliente_id)" +
                "values (@numero, @tipo, @cliente_id)";
            cmd.Parameters.AddWithValue("@numero", Numero);
            cmd.Parameters.AddWithValue("@tipo", Tipo);
            cmd.Parameters.AddWithValue("@cliente_id", Clientes.Id);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        /// <summary>
        /// Método para buscar por id o telefone do Cliente.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Telefones BuscarPorId(int id)
        {
            Telefones telefones = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from telefones where id = "+id;
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                telefones = new Telefones(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Clientes.ObterPorId(dr.GetInt32(3))
                    );
            }

            Banco.Fechar(cmd);
            return telefones;
        }
      
    }
}
