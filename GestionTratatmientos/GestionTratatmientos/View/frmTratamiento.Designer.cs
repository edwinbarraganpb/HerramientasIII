namespace GestionTratatmientos
{
    partial class frmTratamiento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCedulaPaciente = new TextBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            txtObservaciones = new TextBox();
            label5 = new Label();
            dtpFechaFinal = new DateTimePicker();
            label4 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label3 = new Label();
            dtpFechaAsignacion = new DateTimePicker();
            label2 = new Label();
            btnAsignarTratamiento = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 39);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Cedula paciente";
            // 
            // txtCedulaPaciente
            // 
            txtCedulaPaciente.Location = new Point(184, 36);
            txtCedulaPaciente.Name = "txtCedulaPaciente";
            txtCedulaPaciente.Size = new Size(150, 23);
            txtCedulaPaciente.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpFechaFinal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpFechaInicio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpFechaAsignacion);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(71, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 298);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del tratamiento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(228, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(167, 173);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(199, 106);
            txtObservaciones.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 176);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 3;
            label5.Text = "Observaciones";
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.CustomFormat = "yyyy/MM/dd";
            dtpFechaFinal.Format = DateTimePickerFormat.Custom;
            dtpFechaFinal.Location = new Point(166, 123);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(200, 23);
            dtpFechaFinal.TabIndex = 6;
            dtpFechaFinal.Value = new DateTime(2025, 3, 4, 13, 35, 28, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 129);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 5;
            label4.Text = "Fecha final";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(166, 81);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 23);
            dtpFechaInicio.TabIndex = 4;
            dtpFechaInicio.Value = new DateTime(2025, 3, 4, 13, 35, 28, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 87);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 3;
            label3.Text = "Fecha inicio";
            // 
            // dtpFechaAsignacion
            // 
            dtpFechaAsignacion.CustomFormat = "yyyy/MM/dd";
            dtpFechaAsignacion.Format = DateTimePickerFormat.Custom;
            dtpFechaAsignacion.Location = new Point(166, 38);
            dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            dtpFechaAsignacion.Size = new Size(200, 23);
            dtpFechaAsignacion.TabIndex = 2;
            dtpFechaAsignacion.Value = new DateTime(2025, 3, 4, 13, 35, 28, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 44);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha asignación";
            // 
            // btnAsignarTratamiento
            // 
            btnAsignarTratamiento.Location = new Point(172, 445);
            btnAsignarTratamiento.Name = "btnAsignarTratamiento";
            btnAsignarTratamiento.Size = new Size(154, 23);
            btnAsignarTratamiento.TabIndex = 3;
            btnAsignarTratamiento.Text = "Asignar tratamiento";
            btnAsignarTratamiento.UseVisualStyleBackColor = true;
            btnAsignarTratamiento.Click += button1_Click_1;
            // 
            // frmTratamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 526);
            Controls.Add(btnAsignarTratamiento);
            Controls.Add(groupBox1);
            Controls.Add(txtCedulaPaciente);
            Controls.Add(label1);
            Name = "frmTratamiento";
            Text = "Asignar nuevo tratamiento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCedulaPaciente;
        private GroupBox groupBox1;
        private DateTimePicker dtpFechaAsignacion;
        private Label label2;
        private TextBox txtObservaciones;
        private Label label5;
        private DateTimePicker dtpFechaFinal;
        private Label label4;
        private DateTimePicker dtpFechaInicio;
        private Label label3;
        private Button btnAsignarTratamiento;
        private ComboBox comboBox1;
    }
}
