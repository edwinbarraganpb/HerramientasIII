using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionTratatmientos.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionTratatmientos.View
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
            // Configurar el ComboBox
            cmbPacientes.DisplayMember = "nombre";
            cmbPacientes.ValueMember = "cedula";
            PacienteController MisPacientes = new PacienteController();
            cmbPacientes.DataSource = MisPacientes.LlenarListaComboBox();


        }



        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(cmbPacientes.SelectedValue.ToString());
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TratamientoController tratamiento = new TratamientoController(cmbPacientes.SelectedValue.ToString());
            DataTable ListaTratamientos = new DataTable();
            ListaTratamientos.Load(tratamiento.ListrarTratamientos());
            dgvTratamientos.DataSource = ListaTratamientos;
            
        }
    }
}
