using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAPI.Dominio;
using DataAPI.Servicios.Implementaciones;
using FrontUTN.Http;
using FrontUTN.Presentaciones;
using Newtonsoft.Json;

namespace FrontUTN.Presentaciones
{
    public partial class FormInscripcionProfesor : Form
    {
        private static FormInscripcionProfesor instancia;
        private Profesor profesor;
        private GestorAPI gestor;
        public FormInscripcionProfesor()
        {
            InitializeComponent();
            profesor = new Profesor();
            gestor = new GestorAPI();
        }

        public static FormInscripcionProfesor ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormInscripcionProfesor();
            }
            return instancia;
        }

        private async void FormInscripcionProfesor_Load(object sender, EventArgs e)
        {
            await CargarBarriosAsync();
            await CargarEstadosCivilAsync();
            await CargarTiposDNIAsync();
            ProximoProfesor();
        }

        private async Task CargarBarriosAsync()
        {
            string url = "http://localhost:5041/barrios";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrio.DataSource = lst;
            cboBarrio.DisplayMember = "barrio";
            cboBarrio.ValueMember = "Id";
            cboBarrio.SelectedIndex = -1;

        }

        private async Task CargarTiposDNIAsync()
        {
            string url = "http://localhost:5041/tiposDNI";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoDNI>>(result);
            cboTipoDni.DataSource = lst;
            cboTipoDni.DisplayMember = "tipo_dni";
            cboTipoDni.ValueMember = "Id";
            cboTipoDni.SelectedIndex = -1;

        }
        private async Task CargarEstadosCivilAsync()
        {
            string url = "http://localhost:5041/estadosCivil";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<EstadoCivil>>(result);
            cboEstadoCivil.DataSource = lst;
            cboEstadoCivil.DisplayMember = "estado_civil";
            cboEstadoCivil.ValueMember = "Id";
            cboEstadoCivil.SelectedIndex = -1;

        }

        private async void ProximoProfesor()
        {
            int num = await gestor.GetProximoProfesor();
            lblNroProfesor.Text = "Profesor N°: " + num.ToString();
        }

        private void limpiar()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtTitulo.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            cboBarrio.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
            cboTipoDni.SelectedIndex = -1;
            ProximoProfesor();
        }

        private bool validar()
        {
            if (String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text)
                || String.IsNullOrEmpty(txtDni.Text) || String.IsNullOrEmpty(txtTitulo.Text) || cboBarrio.SelectedIndex == -1 
                || cboEstadoCivil.SelectedIndex == -1 || cboTipoDni.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR. Algun campo se encuentra vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDni.Text.Length > 10)
            {
                MessageBox.Show("ERROR. El N° de DNI solo puede tener 10 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Int32.TryParse(txtDni.Text, out int a) == false)
            {
                MessageBox.Show("ERROR. Ingrese solo numeros en el N° de DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DateTime.Today.Year - dtpFechaNacimiento.Value.Year < 18)
            {
                MessageBox.Show("ERROR. El profesor debe ser mayor a 18 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async Task<bool> InscribirProfesor()
        {
            //Datos del Profesor
            if (validar())
            {
                profesor.id_profesor = Convert.ToInt32(gestor.GetProximoProfesor());
                profesor.nombre = txtNombre.Text;
                profesor.nombreCompleto = txtApellido.Text + ", " + txtNombre.Text;
                profesor.apellido = txtApellido.Text;
                profesor.tipo_dni = (int)cboTipoDni.SelectedValue;
                profesor.nro_dni = txtDni.Text;
                profesor.fecha_nac = dtpFechaNacimiento.Value;
                profesor.estado_civil = (int)cboEstadoCivil.SelectedValue;
                profesor.barrio = (int)cboEstadoCivil.SelectedValue;
                profesor.direccion = txtDireccion.Text;
                profesor.titulo_universitario = txtTitulo.Text;

                string bodyContent = JsonConvert.SerializeObject(profesor);

                string url = "http://localhost:5041/inscripcionProfesor";
                var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

                if (result.Equals("true"))
                {
                    MessageBox.Show("Profesor inscripto.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    return true;
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo inscribir el profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cancelar la inscripcion?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                VentanaPrincipal.ObtenerInstancia().Show();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            await InscribirProfesor();
        }
    }
}
