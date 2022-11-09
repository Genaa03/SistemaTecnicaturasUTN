namespace FrontUTN.Presentaciones
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaBajaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminacionProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.examenesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAlumnoToolStripMenuItem,
            this.altaBajaAlumnoToolStripMenuItem,
            this.modificacionAlumnoToolStripMenuItem,
            this.eliminarAlumnoToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Inscripcion Alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaBajaAlumnoToolStripMenuItem
            // 
            this.altaBajaAlumnoToolStripMenuItem.Name = "altaBajaAlumnoToolStripMenuItem";
            this.altaBajaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.altaBajaAlumnoToolStripMenuItem.Text = "Alta/Baja Alumno";
            this.altaBajaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaBajaAlumnoToolStripMenuItem_Click);
            // 
            // modificacionAlumnoToolStripMenuItem
            // 
            this.modificacionAlumnoToolStripMenuItem.Name = "modificacionAlumnoToolStripMenuItem";
            this.modificacionAlumnoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modificacionAlumnoToolStripMenuItem.Text = "Modificacion Alumno";
            this.modificacionAlumnoToolStripMenuItem.Click += new System.EventHandler(this.modificacionAlumnoToolStripMenuItem_Click);
            // 
            // eliminarAlumnoToolStripMenuItem
            // 
            this.eliminarAlumnoToolStripMenuItem.Name = "eliminarAlumnoToolStripMenuItem";
            this.eliminarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.eliminarAlumnoToolStripMenuItem.Text = "Eliminar Alumno";
            this.eliminarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.eliminarAlumnoToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProfesorToolStripMenuItem,
            this.modificacionProfesorToolStripMenuItem,
            this.eliminacionProfesorToolStripMenuItem});
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // altaProfesorToolStripMenuItem
            // 
            this.altaProfesorToolStripMenuItem.Name = "altaProfesorToolStripMenuItem";
            this.altaProfesorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.altaProfesorToolStripMenuItem.Text = "Inscripcion Profesor";
            this.altaProfesorToolStripMenuItem.Click += new System.EventHandler(this.altaProfesorToolStripMenuItem_Click);
            // 
            // modificacionProfesorToolStripMenuItem
            // 
            this.modificacionProfesorToolStripMenuItem.Name = "modificacionProfesorToolStripMenuItem";
            this.modificacionProfesorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.modificacionProfesorToolStripMenuItem.Text = "Modificacion Profesor";
            this.modificacionProfesorToolStripMenuItem.Click += new System.EventHandler(this.modificacionProfesorToolStripMenuItem_Click);
            // 
            // eliminacionProfesorToolStripMenuItem
            // 
            this.eliminacionProfesorToolStripMenuItem.Name = "eliminacionProfesorToolStripMenuItem";
            this.eliminacionProfesorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.eliminacionProfesorToolStripMenuItem.Text = "Eliminar Profesor";
            this.eliminacionProfesorToolStripMenuItem.Click += new System.EventHandler(this.eliminacionProfesorToolStripMenuItem_Click);
            // 
            // examenesToolStripMenuItem
            // 
            this.examenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaExamenToolStripMenuItem});
            this.examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            this.examenesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.examenesToolStripMenuItem.Text = "Examenes";
            // 
            // altaExamenToolStripMenuItem
            // 
            this.altaExamenToolStripMenuItem.Name = "altaExamenToolStripMenuItem";
            this.altaExamenToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.altaExamenToolStripMenuItem.Text = "Alta Examen";
            this.altaExamenToolStripMenuItem.Click += new System.EventHandler(this.altaExamenToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://www.efundaap.com/wp-content/uploads/2020/02/Logo-UTN-FRC.png";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(604, 110);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Bienvenido al sistema academico de las tecnicaturas de la UTN FRC";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 377);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "Sistema Academico UTN FRC";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private ToolStripMenuItem examenesToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem altaExamenToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem altaBajaAlumnoToolStripMenuItem;
        private ToolStripMenuItem modificacionAlumnoToolStripMenuItem;
        private ToolStripMenuItem eliminarAlumnoToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem altaProfesorToolStripMenuItem;
        private ToolStripMenuItem modificacionProfesorToolStripMenuItem;
        private ToolStripMenuItem eliminacionProfesorToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label lblTitulo;
    }
}