namespace FrontUTN.Presentaciones
{
    partial class FormModificacionAlumno
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNroAlumno = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblSituacionHabitacional = new System.Windows.Forms.Label();
            this.lblSituacionLaboral = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cboSituacionHabitacional = new System.Windows.Forms.ComboBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.cboSituacionLaboral = new System.Windows.Forms.ComboBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cboTecnicatura = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipoDni = new System.Windows.Forms.Label();
            this.cboTipoDni = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboAlumnos = new System.Windows.Forms.ComboBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(50, 462);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(456, 23);
            this.txtDireccion.TabIndex = 60;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(227, 442);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(70, 17);
            this.lblDireccion.TabIndex = 70;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNroAlumno
            // 
            this.lblNroAlumno.AutoSize = true;
            this.lblNroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNroAlumno.Location = new System.Drawing.Point(30, 113);
            this.lblNroAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroAlumno.Name = "lblNroAlumno";
            this.lblNroAlumno.Size = new System.Drawing.Size(107, 24);
            this.lblNroAlumno.TabIndex = 69;
            this.lblNroAlumno.Text = "Alumno Nº:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(227, 522);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 27);
            this.btnLimpiar.TabIndex = 62;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(415, 522);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 27);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(39, 522);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 27);
            this.btnAceptar.TabIndex = 61;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarrio.Location = new System.Drawing.Point(109, 368);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(47, 17);
            this.lblBarrio.TabIndex = 68;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblSituacionHabitacional
            // 
            this.lblSituacionHabitacional.AutoSize = true;
            this.lblSituacionHabitacional.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSituacionHabitacional.Location = new System.Drawing.Point(342, 301);
            this.lblSituacionHabitacional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacionHabitacional.Name = "lblSituacionHabitacional";
            this.lblSituacionHabitacional.Size = new System.Drawing.Size(151, 17);
            this.lblSituacionHabitacional.TabIndex = 67;
            this.lblSituacionHabitacional.Text = "Situación Habitacional";
            // 
            // lblSituacionLaboral
            // 
            this.lblSituacionLaboral.AutoSize = true;
            this.lblSituacionLaboral.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSituacionLaboral.Location = new System.Drawing.Point(361, 368);
            this.lblSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacionLaboral.Name = "lblSituacionLaboral";
            this.lblSituacionLaboral.Size = new System.Drawing.Size(120, 17);
            this.lblSituacionLaboral.TabIndex = 66;
            this.lblSituacionLaboral.Text = "Situación Laboral";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoCivil.Location = new System.Drawing.Point(82, 301);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(85, 17);
            this.lblEstadoCivil.TabIndex = 65;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // cboSituacionHabitacional
            // 
            this.cboSituacionHabitacional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacionHabitacional.Enabled = false;
            this.cboSituacionHabitacional.FormattingEnabled = true;
            this.cboSituacionHabitacional.Location = new System.Drawing.Point(342, 330);
            this.cboSituacionHabitacional.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSituacionHabitacional.Name = "cboSituacionHabitacional";
            this.cboSituacionHabitacional.Size = new System.Drawing.Size(164, 23);
            this.cboSituacionHabitacional.TabIndex = 56;
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.Enabled = false;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(50, 399);
            this.cboBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(160, 23);
            this.cboBarrio.TabIndex = 57;
            // 
            // cboSituacionLaboral
            // 
            this.cboSituacionLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacionLaboral.Enabled = false;
            this.cboSituacionLaboral.FormattingEnabled = true;
            this.cboSituacionLaboral.Location = new System.Drawing.Point(342, 399);
            this.cboSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSituacionLaboral.Name = "cboSituacionLaboral";
            this.cboSituacionLaboral.Size = new System.Drawing.Size(164, 23);
            this.cboSituacionLaboral.TabIndex = 59;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.Enabled = false;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(50, 330);
            this.cboEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(160, 23);
            this.cboEstadoCivil.TabIndex = 54;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(67, 226);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(126, 17);
            this.lblFechaNacimiento.TabIndex = 64;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(50, 258);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(160, 23);
            this.dtpFechaNacimiento.TabIndex = 52;
            // 
            // cboTecnicatura
            // 
            this.cboTecnicatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTecnicatura.Enabled = false;
            this.cboTecnicatura.FormattingEnabled = true;
            this.cboTecnicatura.Location = new System.Drawing.Point(342, 258);
            this.cboTecnicatura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTecnicatura.Name = "cboTecnicatura";
            this.cboTecnicatura.Size = new System.Drawing.Size(164, 23);
            this.cboTecnicatura.TabIndex = 53;
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(432, 190);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(126, 23);
            this.txtDni.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(387, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tecnicatura";
            // 
            // lblTipoDni
            // 
            this.lblTipoDni.AutoSize = true;
            this.lblTipoDni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDni.Location = new System.Drawing.Point(399, 157);
            this.lblTipoDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDni.Name = "lblTipoDni";
            this.lblTipoDni.Size = new System.Drawing.Size(94, 17);
            this.lblTipoDni.TabIndex = 55;
            this.lblTipoDni.Text = "Tipo y N° DNI";
            // 
            // cboTipoDni
            // 
            this.cboTipoDni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDni.Enabled = false;
            this.cboTipoDni.FormattingEnabled = true;
            this.cboTipoDni.Location = new System.Drawing.Point(354, 190);
            this.cboTipoDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTipoDni.Name = "cboTipoDni";
            this.cboTipoDni.Size = new System.Drawing.Size(70, 23);
            this.cboTipoDni.TabIndex = 49;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(192, 190);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(137, 23);
            this.txtApellido.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(30, 190);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 23);
            this.txtNombre.TabIndex = 46;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(231, 157);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 51;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(68, 157);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 17);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "Nombre";
            // 
            // cboAlumnos
            // 
            this.cboAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumnos.FormattingEnabled = true;
            this.cboAlumnos.Location = new System.Drawing.Point(177, 53);
            this.cboAlumnos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAlumnos.Name = "cboAlumnos";
            this.cboAlumnos.Size = new System.Drawing.Size(247, 23);
            this.cboAlumnos.TabIndex = 71;
            this.cboAlumnos.SelectedIndexChanged += new System.EventHandler(this.cboAlumnos_SelectedIndexChanged);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlumnos.Location = new System.Drawing.Point(13, 56);
            this.lblAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(156, 17);
            this.lblAlumnos.TabIndex = 72;
            this.lblAlumnos.Text = "Seleccione un alumno:";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(458, 51);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(100, 27);
            this.btnCambiar.TabIndex = 73;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // FormModificacionAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.cboAlumnos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNroAlumno);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblSituacionHabitacional);
            this.Controls.Add(this.lblSituacionLaboral);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.cboSituacionHabitacional);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.cboSituacionLaboral);
            this.Controls.Add(this.cboEstadoCivil);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cboTecnicatura);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTipoDni);
            this.Controls.Add(this.cboTipoDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormModificacionAlumno";
            this.Text = "Modificacion de Alumno";
            this.Load += new System.EventHandler(this.FormModificacionAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDireccion;
        private Label lblDireccion;
        private Label lblNroAlumno;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblBarrio;
        private Label lblSituacionHabitacional;
        private Label lblSituacionLaboral;
        private Label lblEstadoCivil;
        private ComboBox cboSituacionHabitacional;
        private ComboBox cboBarrio;
        private ComboBox cboSituacionLaboral;
        private ComboBox cboEstadoCivil;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cboTecnicatura;
        private TextBox txtDni;
        private Label label2;
        private Label lblTipoDni;
        private ComboBox cboTipoDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblApellido;
        private Label lblNombre;
        private ComboBox cboAlumnos;
        private Label lblAlumnos;
        private Button btnCambiar;
    }
}