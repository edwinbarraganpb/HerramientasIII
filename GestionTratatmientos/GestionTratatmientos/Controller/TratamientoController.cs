using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionTratatmientos.Model;

namespace GestionTratatmientos.Controller
{
    class TratamientoController
    {
        private Tratatmiento gestionTratamiento;

        public TratamientoController(string cedulaPaciente, DateTime fechaAsignado, DateTime fechaInicio, DateTime fechaFinalizacion, string observaciones = "")
        {
            this.gestionTratamiento = new Tratatmiento( cedulaPaciente,  fechaAsignado,  fechaInicio,  fechaFinalizacion,  observaciones );
        }        
    }
}
