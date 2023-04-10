using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class Pedido
    {
        //atributos
        private int id;

        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Clientes Clientes { get; set; }
        public Usuarios Usuarios { get; set; }
        public DateTime Arquivado_em { get; set; }
        public string HashCode { get; set; }

        //Métodos contrutores
        public Pedido() { }
        public Pedido(int id, DateTime data, string status, double desconto, Clientes clientes, Usuarios usuarios, DateTime arquivado_em, string hashCode)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Clientes = clientes;
            Usuarios = usuarios;
            Arquivado_em = arquivado_em;
            HashCode = hashCode;
        }
    }
}
