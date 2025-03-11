using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GestionTratatmientos.Model
{
    class GestorTratamiento
    {
        public static Conexion enlaceBD;
        public static SqlConnection BD;

        public static bool AsignarTratamiento(Tratatmiento nuevoTratamiento)
        {
            enlaceBD = new Conexion();
            BD = enlaceBD.AbrirConexion();            
            string query = "INSERT INTO [TblTratamiento] " +
                "([cedulaPaciente],[fechaAsignado],[fechaInicio],[fechaFinalizacion],[observaciones]) " +
                "VALUES " +
                "(@cedulaPaciente,@fechaAsignado,@fechaInicio,@fechaFinalizacion,@observaciones)";
            SqlCommand command = new SqlCommand(query, BD);
            
            command.Parameters.AddWithValue("@cedulaPaciente", nuevoTratamiento.CedulaPaciente);
            command.Parameters.AddWithValue("@fechaAsignado", nuevoTratamiento.FechaAsignado);
            command.Parameters.AddWithValue("@fechaInicio", nuevoTratamiento.FechaInicio);
            command.Parameters.AddWithValue("@fechaFinalizacion", nuevoTratamiento.FechaFinalizacion);
            command.Parameters.AddWithValue("@observaciones", nuevoTratamiento.Observaciones);
            MessageBox.Show(query);
            BD.Open();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            catch 
            {
                return false;
            }

            return true;
                
                    
        }

        public static SqlDataReader ListarTratamientos(string cedulaPaciente)
        {
            string query = "Select * from [TblTratamiento] " +
               "where cedulaPaciente = @cedulaPaciente";
            SqlDataReader registros = null;
            SqlCommand command = new SqlCommand(query, BD);
         
            command.Parameters.AddWithValue("@cedulaPaciente", cedulaPaciente);
            BD.Open();
            registros = command.ExecuteReader();
      

            return registros;
        }
    }
}
