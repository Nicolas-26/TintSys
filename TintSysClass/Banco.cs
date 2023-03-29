using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace TintSysClass
{
    /// <summary>
    /// Classe Banco serve para Ligar e Desligar o Banco de dados
    /// </summary>
    internal static class Banco
    {
        private static string strConn;

        public static MySqlCommand Abrir()
        {
            strConn = @"server=127.0.0.1;database=ti93sysdb;port=3306;user id=root;password=usbw";
            MySqlCommand cmd = new MySqlCommand();
            try //tentar abrir
            {
                MySqlConnection cn = new MySqlConnection(strConn);
                if (cn.State!=ConnectionState.Open)
                {
                    cn.Open();
                }
                cmd.Connection = cn;
            }
            catch(Exception)
            {
                throw; 
            }
            return cmd;
        }

        public static void Fechar(MySqlCommand cmd)
        {
            if(cmd.Connection.State==ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
    }
}
