using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTratatmientos.Model
{
    class GestorPaciente
    {
        public static Conexion enlaceBD;
        public static SqlConnection BD;

        public static SqlDataReader Listarpacientes()
        {
            enlaceBD = new Conexion();
            BD = enlaceBD.AbrirConexion();
            string query = "Select * from [TblPaciente]";
            SqlDataReader registros = null;
            SqlCommand command = new SqlCommand(query, BD);            
            BD.Open();
            registros = command.ExecuteReader();
            return registros;
        }
    }
}
