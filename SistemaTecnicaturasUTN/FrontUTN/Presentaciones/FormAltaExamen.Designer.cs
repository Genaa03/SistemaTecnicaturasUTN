namespace FrontUTN.Presentaciones
{
    partial class FormAltaExamen
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
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblNota = new System.Windows.Forms.Label();
            this.LblAlumno = new System.Windows.Forms.Label();
            this.CboAlumno = new System.Windows.Forms.ComboBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMateri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CboTipoExamen = new System.Windows.Forms.ComboBox();
            this.LblTipoExamen = new System.Windows.Forms.Label();
            this.CboMateria = new System.Windows.Forms.ComboBox();
            this.LblMateria = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNroExamen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNota
            // 
            this.nudNota.Location = new System.Drawing.Point(309, 243);
            this.nudNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNota.Name = "nudNota";
            this.nudNota.ReadOnly = true;
            this.nudNota.Size = new System.Drawing.Size(74, 23);
            this.nudNota.TabIndex = 30;
            this.nudNota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(68, 530);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(127, 27);
            this.BtnCancelar.TabIndex = 29;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(424, 530);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(127, 27);
            this.BtnAceptar.TabIndex = 28;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNota.Location = new System.Drawing.Point(309, 222);
            this.LblNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(37, 17);
            this.LblNota.TabIndex = 27;
            this.LblNota.Text = "Nota";
            // 
            // LblAlumno
            // 
            this.LblAlumno.AutoSize = true;
            this.LblAlumno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAlumno.Location = new System.Drawing.Point(40, 222);
            this.LblAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAlumno.Name = "LblAlumno";
            this.LblAlumno.Size = new System.Drawing.Size(52, 17);
            this.LblAlumno.TabIndex = 26;
            this.LblAlumno.Text = "Alumno";
            // 
            // CboAlumno
            // 
            this.CboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAlumno.FormattingEnabled = true;
            this.CboAlumno.Location = new System.Drawing.Point(40, 243);
            this.CboAlumno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboAlumno.Name = "CboAlumno";
            this.CboAlumno.Size = new System.Drawing.Size(238, 23);
            this.CboAlumno.TabIndex = 25;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColAlumno,
            this.ColNota,
            this.ColMateri,
            this.ColTipoExamen,
            this.ColAcciones});
            this.dgvAlumnos.Location = new System.Drawing.Point(40, 292);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.Size = new System.Drawing.Size(545, 173);
            this.dgvAlumnos.TabIndex = 24;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColAlumno
            // 
            this.ColAlumno.HeaderText = "Alumno";
            this.ColAlumno.Name = "ColAlumno";
            this.ColAlumno.ReadOnly = true;
            // 
            // ColNota
            // 
            this.ColNota.HeaderText = "Nota";
            this.ColNota.Name = "ColNota";
            this.ColNota.ReadOnly = true;
            // 
            // ColMateri
            // 
            this.ColMateri.HeaderText = "Materia";
            this.ColMateri.Name = "ColMateri";
            this.ColMateri.ReadOnly = true;
            // 
            // ColTipoExamen
            // 
            this.ColTipoExamen.HeaderText = "Tipo Examen";
            this.ColTipoExamen.Name = "ColTipoExamen";
            this.ColTipoExamen.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Text = "Quitar";
            this.ColAcciones.UseColumnTextForButtonValue = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(414, 241);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(171, 27);
            this.BtnAgregar.TabIndex = 23;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CboTipoExamen
            // 
            this.CboTipoExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoExamen.FormattingEnabled = true;
            this.CboTipoExamen.Location = new System.Drawing.Point(138, 118);
            this.CboTipoExamen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboTipoExamen.Name = "CboTipoExamen";
            this.CboTipoExamen.Size = new System.Drawing.Size(223, 23);
            this.CboTipoExamen.TabIndex = 22;
            // 
            // LblTipoExamen
            // 
            this.LblTipoExamen.AutoSize = true;
            this.LblTipoExamen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTipoExamen.Location = new System.Drawing.Point(40, 121);
            this.LblTipoExamen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipoExamen.Name = "LblTipoExamen";
            this.LblTipoExamen.Size = new System.Drawing.Size(83, 17);
            this.LblTipoExamen.TabIndex = 21;
            this.LblTipoExamen.Text = "Tipo Examen";
            // 
            // CboMateria
            // 
            this.CboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMateria.FormattingEnabled = true;
            this.CboMateria.Location = new System.Drawing.Point(138, 75);
            this.CboMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboMateria.Name = "CboMateria";
            this.CboMateria.Size = new System.Drawing.Size(223, 23);
            this.CboMateria.TabIndex = 20;
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMateria.Location = new System.Drawing.Point(68, 78);
            this.LblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(53, 17);
            this.LblMateria.TabIndex = 19;
            this.LblMateria.Text = "Materia";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFecha.Location = new System.Drawing.Point(77, 164);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(41, 17);
            this.LblFecha.TabIndex = 18;
            this.LblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(138, 161);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(223, 23);
            this.dtpFecha.TabIndex = 17;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPromedio.Location = new System.Drawing.Point(447, 468);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(76, 17);
            this.lblPromedio.TabIndex = 31;
            this.lblPromedio.Text = "Promedio: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(246, 530);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 27);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNroExamen
            // 
            this.lblNroExamen.AutoSize = true;
            this.lblNroExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroExamen.Location = new System.Drawing.Point(68, 23);
            this.lblNroExamen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroExamen.Name = "lblNroExamen";
            this.lblNroExamen.Size = new System.Drawing.Size(102, 20);
            this.lblNroExamen.TabIndex = 33;
            this.lblNroExamen.Text = "Examen Nº:";
            // 
            // FormAltaExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 574);
            this.Controls.Add(this.lblNroExamen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.nudNota);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblNota);
            this.Controls.Add(this.LblAlumno);
            this.Controls.Add(this.CboAlumno);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CboTipoExamen);
            this.Controls.Add(this.LblTipoExamen);
            this.Controls.Add(this.CboMateria);
            this.Controls.Add(this.LblMateria);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Name = "FormAltaExamen";
            this.Text = "FormAltaExamen";
            this.Load += new System.EventHandler(this.FormAltaExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudNota;
        private Button BtnCancelar;
        private Button BtnAceptar;
        private Label LblNota;
        private Label LblAlumno;
        private ComboBox CboAlumno;
        private DataGridView dgvAlumnos;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColAlumno;
        private DataGridViewTextBoxColumn ColNota;
        private DataGridViewTextBoxColumn ColMateri;
        private DataGridViewTextBoxColumn ColTipoExamen;
        private DataGridViewButtonColumn ColAcciones;
        private Button BtnAgregar;
        private ComboBox CboTipoExamen;
        private Label LblTipoExamen;
        private ComboBox CboMateria;
        private Label LblMateria;
        private Label LblFecha;
        private DateTimePicker dtpFecha;
        private Label lblPromedio;
        private Button btnLimpiar;
        private Label lblNroExamen;
    }
}