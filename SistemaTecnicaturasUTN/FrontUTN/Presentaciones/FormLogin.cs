using DataAPI.Servicios.Implementaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontUTN.Presentaciones
{
    public partial class FormLogin : Form
    {
        private GestorAPI gestor;
        public FormLogin()
        {
            InitializeComponent();
            gestor = new GestorAPI();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (await comprobacion())
            {
                this.Hide();
                VentanaPrincipal.ObtenerInstancia().Show();
            }
        }

        private async Task<bool> comprobacion()
        {
            DataTable tabla = await gestor.Ingreso();
            
            foreach (DataRow dr in tabla.Rows)
            {
                if(txtUser.Text == dr["usuario"].ToString() && txtPass.Text == dr["contraseña"].ToString())
                {
                    return true;
                }
            }
            MessageBox.Show("Usuario/Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
