namespace GestionTratatmientos.View
{
    partial class frmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbPacientes = new ComboBox();
            dgvTratamientos = new DataGridView();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 51);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Cedula paciente";
            // 
            // cmbPacientes
            // 
            cmbPacientes.FormattingEnabled = true;
            cmbPacientes.Location = new Point(199, 43);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new Size(480, 23);
            cmbPacientes.TabIndex = 1;
            // 
            // dgvTratamientos
            // 
            dgvTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTratamientos.Location = new Point(101, 142);
            dgvTratamientos.Name = "dgvTratamientos";
            dgvTratamientos.Size = new Size(588, 261);
            dgvTratamientos.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(346, 88);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(dgvTratamientos);
            Controls.Add(cmbPacientes);
            Controls.Add(label1);
            Name = "frmPaciente";
            Text = "Form2";
            Load += frmPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPacientes;
        private DataGridView dgvTratamientos;
        private Button btnBuscar;
    }
}