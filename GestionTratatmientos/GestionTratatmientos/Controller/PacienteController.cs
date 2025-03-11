using System.Data.SqlClient;
using GestionTratatmientos.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTratatmientos.Controller
{
    class PacienteController
    {
        private GestorPaciente MiPaciente;

        public List<Paciente> LlenarListaComboBox()
        {

            SqlDataReader registros = GestorPaciente.Listarpacientes();
            List<Paciente> personas = new List<Paciente>();
            while (registros.Read())
            {
                Paciente nuevoPaciente = new Paciente(registros["cedula"].ToString(),$"{registros["nombre"].ToString()}{registros["apellido"].ToString()}");
                personas.Add(nuevoPaciente);
            }

            return personas;
        }
    }
}
