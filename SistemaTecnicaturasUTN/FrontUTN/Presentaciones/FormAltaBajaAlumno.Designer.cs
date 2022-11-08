namespace FrontUTN.Presentaciones
{
    partial class FormAltaBajaAlumno
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
            this.btnBaja = new System.Windows.Forms.Button();
            this.dgvHabilitados = new System.Windows.Forms.DataGridView();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.dgvDadosBaja = new System.Windows.Forms.DataGridView();
            this.lblBajaT = new System.Windows.Forms.Label();
            this.lblAlta = new System.Windows.Forms.Label();
            this.lblBaja = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilitados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(111, 540);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(138, 28);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Dar Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvHabilitados
            // 
            this.dgvHabilitados.AllowUserToAddRows = false;
            this.dgvHabilitados.AllowUserToDeleteRows = false;
            this.dgvHabilitados.AllowUserToResizeColumns = false;
            this.dgvHabilitados.AllowUserToResizeRows = false;
            this.dgvHabilitados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabilitados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvHabilitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabilitados.Location = new System.Drawing.Point(63, 105);
            this.dgvHabilitados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHabilitados.MultiSelect = false;
            this.dgvHabilitados.Name = "dgvHabilitados";
            this.dgvHabilitados.ReadOnly = true;
            this.dgvHabilitados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHabilitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabilitados.Size = new System.Drawing.Size(234, 411);
            this.dgvHabilitados.TabIndex = 0;
            this.dgvHabilitados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHabilitados_CellMouseClick);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientes.Location = new System.Drawing.Point(84, 23);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(193, 25);
            this.lblClientes.TabIndex = 4;
            this.lblClientes.Text = "Lista de Alumnos";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(476, 540);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(138, 28);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "Dar Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // dgvDadosBaja
            // 
            this.dgvDadosBaja.AllowUserToAddRows = false;
            this.dgvDadosBaja.AllowUserToDeleteRows = false;
            this.dgvDadosBaja.AllowUserToResizeColumns = false;
            this.dgvDadosBaja.AllowUserToResizeRows = false;
            this.dgvDadosBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosBaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDadosBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosBaja.Location = new System.Drawing.Point(428, 105);
            this.dgvDadosBaja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDadosBaja.MultiSelect = false;
            this.dgvDadosBaja.Name = "dgvDadosBaja";
            this.dgvDadosBaja.ReadOnly = true;
            this.dgvDadosBaja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDadosBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosBaja.Size = new System.Drawing.Size(234, 411);
            this.dgvDadosBaja.TabIndex = 1;
            this.dgvDadosBaja.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDadosBaja_CellMouseClick);
            // 
            // lblBajaT
            // 
            this.lblBajaT.AutoSize = true;
            this.lblBajaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBajaT.Location = new System.Drawing.Point(435, 23);
            this.lblBajaT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBajaT.Name = "lblBajaT";
            this.lblBajaT.Size = new System.Drawing.Size(193, 25);
            this.lblBajaT.TabIndex = 7;
            this.lblBajaT.Text = "Lista de Alumnos";
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlta.Location = new System.Drawing.Point(491, 62);
            this.lblAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(92, 25);
            this.lblAlta.TabIndex = 10;
            this.lblAlta.Text = "de Baja";
            // 
            // lblBaja
            // 
            this.lblBaja.AutoSize = true;
            this.lblBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaja.Location = new System.Drawing.Point(130, 62);
            this.lblBaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaja.Name = "lblBaja";
            this.lblBaja.Size = new System.Drawing.Size(86, 25);
            this.lblBaja.TabIndex = 11;
            this.lblBaja.Text = "de Alta";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(280, 586);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(138, 28);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormAltaBajaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 628);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblBaja);
            this.Controls.Add(this.lblAlta);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvDadosBaja);
            this.Controls.Add(this.lblBajaT);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.dgvHabilitados);
            this.Controls.Add(this.lblClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAltaBajaAlumno";
            this.Text = "Alta/Baja Alumnos";
            this.Load += new System.EventHandler(this.FormBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilitados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosBaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.DataGridView dgvHabilitados;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridView dgvDadosBaja;
        private System.Windows.Forms.Label lblBajaT;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.Label lblBaja;
        private System.Windows.Forms.Button btnCerrar;
    }
}