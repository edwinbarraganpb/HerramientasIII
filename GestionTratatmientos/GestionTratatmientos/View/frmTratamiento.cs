using GestionTratatmientos.Controller;

namespace GestionTratatmientos
{
    public partial class frmTratamiento : Form
    {
        public frmTratamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


















        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TratamientoController tratamiento = new TratamientoController(txtCedulaPaciente.Text,dtpFechaAsignacion.Value,dtpFechaInicio.Value,dtpFechaFinal.Value,txtObservaciones.Text);
            string Mensaje = (tratamiento.GuardarTratamiento()) ? "Guardado satisfactoriamente" : "Ocurrio un error, contacte al administrador";
            MessageBox.Show(Mensaje);

        }
    }
}
