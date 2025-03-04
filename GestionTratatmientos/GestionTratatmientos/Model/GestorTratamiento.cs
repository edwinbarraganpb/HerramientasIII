using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GestionTratatmientos.Model
{
    class GestorTratamiento
    {
        private SqlConnection enlaceBD;

        public GestorTratamiento()
        {
            enlaceBD = Conexion.AbrirConexion();
        }
        public bool AsignarTratamiento(Tratatmiento nuevoTratamiento)
        {
            string query = "INSERT INTO [TblTratamiento] " +
                "([cedulaPaciente] ,[fechaAsignado],[fechaInicio],[fechaFinalizacion],[observaciones]) " +
                "VALUES " +
                "(@cedulaPaciente,@fechaAsignado,@fechaInicio,@fechaFinalizacion,@observaciones)";
            using (SqlCommand command = new SqlCommand(query, enlaceBD))
            {
                command.Parameters.AddWithValue("@cedulaPaciente", nuevoTratamiento.CedulaPaciente);
                command.Parameters.AddWithValue("@fechaAsignado", nuevoTratamiento.FechaAsignado);
                command.Parameters.AddWithValue("@fechaInicio", nuevoTratamiento.FechaInicio);
                command.Parameters.AddWithValue("@fechaFinalizacion", nuevoTratamiento.FechaFinalizacion);
                command.Parameters.AddWithValue("@observaciones", nuevoTratamiento.Observaciones);

                enlaceBD.Open();
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
        }

        public SqlDataReader ListarTratamientos(string cedulaPaciente)
        {
            string query = "Select * from [TblTratamiento] " +
               "where cedulaPaciente = @cedulaPaciente";
            SqlDataReader registros = null;
            using (SqlCommand command = new SqlCommand(query, enlaceBD))
            {
                command.Parameters.AddWithValue("@cedulaPaciente", cedulaPaciente);
                enlaceBD.Open();
                registros = command.ExecuteReader();
            }

            return registros;
        }
    }
}
