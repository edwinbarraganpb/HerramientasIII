using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionTratatmientos.Model
{
    class Conexion
    {
        private string connectionString = "server=SYN\\B13-204-22896;integrated security=true;database=dbTratamientosMedicos";

        public SqlConnection AbrirConexion() 
        
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    return con;

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error en la conexion");
                    return null;
                }
            }
        }

       

    }
}
