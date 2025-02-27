using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTratatmientos.Model
{
    class Paciente
    {
        private string cedula;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string sexo;

        public Paciente(string cedula, string nombre, string apellido, DateTime fechaNacimiento, string sexo)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        
    }
}
