using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTratatmientos.Model
{
    class Tratatmiento
    {
        private int idTratamiento;
        private string cedulaPaciente;
        private DateTime fechaAsignado;
        private DateTime fechaInicio;
        private DateTime fechaFinalizacion;
        private string observaciones;

        public Tratatmiento(int idTratamiento, string cedulaPaciente, DateTime fechaAsignado, DateTime fechaInicio, DateTime fechaFinalizacion, string observaciones="")
        {
            this.IdTratamiento = idTratamiento;
            this.CedulaPaciente = cedulaPaciente;
            this.FechaAsignado = fechaAsignado;
            this.FechaInicio = fechaInicio;
            this.FechaFinalizacion = fechaFinalizacion;
            this.Observaciones = observaciones;
        }

        public int IdTratamiento { get => idTratamiento; set => idTratamiento = value; }
        public string CedulaPaciente { get => cedulaPaciente; set => cedulaPaciente = value; }
        public DateTime FechaAsignado { get => fechaAsignado; set => fechaAsignado = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinalizacion { get => fechaFinalizacion; set => fechaFinalizacion = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
