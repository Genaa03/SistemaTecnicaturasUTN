namespace FrontUTN.Presentaciones
{
    partial class FormEliminarAlumno
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
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.cboAlumnos = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNroAlumno = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(464, 33);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(100, 27);
            this.btnCambiar.TabIndex = 1;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlumnos.Location = new System.Drawing.Point(19, 38);
            this.lblAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(156, 17);
            this.lblAlumnos.TabIndex = 100;
            this.lblAlumnos.Text = "Seleccione un alumno:";
            // 
            // cboAlumnos
            // 
            this.cboAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumnos.FormattingEnabled = true;
            this.cboAlumnos.Location = new System.Drawing.Point(183, 35);
            this.cboAlumnos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAlumnos.Name = "cboAlumnos";
            this.cboAlumnos.Size = new System.Drawing.Size(247, 23);
            this.cboAlumnos.TabIndex = 0;
            this.cboAlumnos.SelectedIndexChanged += new System.EventHandler(this.cboAlumnos_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(56, 444);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(456, 23);
            this.txtDireccion.TabIndex = 12;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(233, 424);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(70, 17);
            this.lblDireccion.TabIndex = 98;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNroAlumno
            // 
            this.lblNroAlumno.AutoSize = true;
            this.lblNroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNroAlumno.Location = new System.Drawing.Point(36, 95);
            this.lblNroAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroAlumno.Name = "lblNroAlumno";
            this.lblNroAlumno.Size = new System.Drawing.Size(107, 24);
            this.lblNroAlumno.TabIndex = 97;
            this.lblNroAlumno.Text = "Alumno Nº:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(341, 504);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 27);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(56, 504);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 27);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarrio.Location = new System.Drawing.Point(115, 350);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(47, 17);
            this.lblBarrio.TabIndex = 96;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblSituacionHabitacional
            // 
            this.lblSituacionHabitacional.AutoSize = true;
            this.lblSituacionHabitacional.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSituacionHabitacional.Location = new System.Drawing.Point(348, 283);
            this.lblSituacionHabitacional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacionHabitacional.Name = "lblSituacionHabitacional";
            this.lblSituacionHabitacional.Size = new System.Drawing.Size(151, 17);
            this.lblSituacionHabitacional.TabIndex = 95;
            this.lblSituacionHabitacional.Text = "Situación Habitacional";
            // 
            // lblSituacionLaboral
            // 
            this.lblSituacionLaboral.AutoSize = true;
            this.lblSituacionLaboral.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSituacionLaboral.Location = new System.Drawing.Point(367, 350);
            this.lblSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacionLaboral.Name = "lblSituacionLaboral";
            this.lblSituacionLaboral.Size = new System.Drawing.Size(120, 17);
            this.lblSituacionLaboral.TabIndex = 94;
            this.lblSituacionLaboral.Text = "Situación Laboral";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoCivil.Location = new System.Drawing.Point(88, 283);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(85, 17);
            this.lblEstadoCivil.TabIndex = 93;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // cboSituacionHabitacional
            // 
            this.cboSituacionHabitacional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacionHabitacional.Enabled = false;
            this.cboSituacionHabitacional.FormattingEnabled = true;
            this.cboSituacionHabitacional.Location = new System.Drawing.Point(348, 312);
            this.cboSituacionHabitacional.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSituacionHabitacional.Name = "cboSituacionHabitacional";
            this.cboSituacionHabitacional.Size = new System.Drawing.Size(164, 23);
            this.cboSituacionHabitacional.TabIndex = 9;
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.Enabled = false;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(56, 381);
            this.cboBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(160, 23);
            this.cboBarrio.TabIndex = 10;
            // 
            // cboSituacionLaboral
            // 
            this.cboSituacionLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacionLaboral.Enabled = false;
            this.cboSituacionLaboral.FormattingEnabled = true;
            this.cboSituacionLaboral.Location = new System.Drawing.Point(348, 381);
            this.cboSituacionLaboral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSituacionLaboral.Name = "cboSituacionLaboral";
            this.cboSituacionLaboral.Size = new System.Drawing.Size(164, 23);
            this.cboSituacionLaboral.TabIndex = 11;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.Enabled = false;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(56, 312);
            this.cboEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(160, 23);
            this.cboEstadoCivil.TabIndex = 8;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(73, 208);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(126, 17);
            this.lblFechaNacimiento.TabIndex = 92;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(56, 240);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(160, 23);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // cboTecnicatura
            // 
            this.cboTecnicatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTecnicatura.Enabled = false;
            this.cboTecnicatura.FormattingEnabled = true;
            this.cboTecnicatura.Location = new System.Drawing.Point(348, 240);
            this.cboTecnicatura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTecnicatura.Name = "cboTecnicatura";
            this.cboTecnicatura.Size = new System.Drawing.Size(164, 23);
            this.cboTecnicatura.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(438, 172);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(126, 23);
            this.txtDni.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(393, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tecnicatura";
            // 
            // lblTipoDni
            // 
            this.lblTipoDni.AutoSize = true;
            this.lblTipoDni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDni.Location = new System.Drawing.Point(405, 139);
            this.lblTipoDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDni.Name = "lblTipoDni";
            this.lblTipoDni.Size = new System.Drawing.Size(94, 17);
            this.lblTipoDni.TabIndex = 83;
            this.lblTipoDni.Text = "Tipo y N° DNI";
            // 
            // cboTipoDni
            // 
            this.cboTipoDni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDni.Enabled = false;
            this.cboTipoDni.FormattingEnabled = true;
            this.cboTipoDni.Location = new System.Drawing.Point(360, 172);
            this.cboTipoDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTipoDni.Name = "cboTipoDni";
            this.cboTipoDni.Size = new System.Drawing.Size(70, 23);
            this.cboTipoDni.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(198, 172);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(137, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(36, 172);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(237, 139);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 79;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(74, 139);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 17);
            this.lblNombre.TabIndex = 76;
            this.lblNombre.Text = "Nombre";
            // 
            // FormEliminarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 547);
            this.ControlBox = false;
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.cboAlumnos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNroAlumno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
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
            this.Name = "FormEliminarAlumno";
            this.Text = "FormEliminarAlumno";
            this.Load += new System.EventHandler(this.FormEliminarAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCambiar;
        private Label lblAlumnos;
        private ComboBox cboAlumnos;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Label lblNroAlumno;
        private Button btnCancelar;
        private Button btnEliminar;
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
    }
}