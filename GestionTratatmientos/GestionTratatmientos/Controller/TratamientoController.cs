using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionTratatmientos.Model;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace GestionTratatmientos.Controller
{
    class TratamientoController
    {
        private Tratatmiento gestionTratamiento;

        public TratamientoController(string cedulaPaciente, DateTime fechaAsignado, DateTime fechaInicio, DateTime fechaFinalizacion, string observaciones = "")
        {
            this.gestionTratamiento = new Tratatmiento( cedulaPaciente,  fechaAsignado,  fechaInicio,  fechaFinalizacion,  observaciones );
            
        }

        public Boolean GuardarTratamiento()
        {
            return (GestorTratamiento.AsignarTratamiento(gestionTratamiento)) ? true : false;
        }

        public SqlDataReader ListrarTratamientos()
        {
            return GestorTratamiento.ListarTratamientos(gestionTratamiento.CedulaPaciente);
        }
    }
}
