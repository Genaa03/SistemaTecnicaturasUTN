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
    public partial class FormModificacionProfesor : Form
    {
        private static FormModificacionProfesor instancia;
        private Profesor profesor;
        private GestorAPI gestor;
        public FormModificacionProfesor()
        {
            InitializeComponent();
            profesor = new Profesor();
            gestor = new GestorAPI();
        }

        public static FormModificacionProfesor ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormModificacionProfesor();
            }
            return instancia;
        }
        private async void FormModificacionProfesor_Load(object sender, EventArgs e)
        {
            await CargarBarriosAsync();
            await CargarEstadosCivilAsync();
            await CargarTiposDNIAsync();
            await CargarProfesoresAsync();
            limpiar();
            habilitar(false);
        }

        private async Task CargarProfesoresAsync()
        {
            string url = "http://localhost:5041/profesores";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Profesor>>(result);
            cboProfesores.DataSource = lst;
            cboProfesores.DisplayMember = "nombreCompleto";
            cboProfesores.ValueMember = "id_profesor";
            cboProfesores.SelectedIndex = -1;
        }
        private async Task CargarBarriosAsync()
        {
            string url = "http://localhost:5041/barrios";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrio.DataSource = lst;
            cboBarrio.DisplayMember = "barrio";
            cboBarrio.ValueMember = "id";
            cboBarrio.SelectedIndex = -1;

        }

        private async Task CargarTiposDNIAsync()
        {
            string url = "http://localhost:5041/tiposDNI";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoDNI>>(result);
            cboTipoDni.DataSource = lst;
            cboTipoDni.DisplayMember = "tipo_dni";
            cboTipoDni.ValueMember = "id";
            cboTipoDni.SelectedIndex = -1;

        }
        private async Task CargarEstadosCivilAsync()
        {
            string url = "http://localhost:5041/estadosCivil";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<EstadoCivil>>(result);
            cboEstadoCivil.DataSource = lst;
            cboEstadoCivil.DisplayMember = "estado_civil";
            cboEstadoCivil.ValueMember = "id";
            cboEstadoCivil.SelectedIndex = -1;

        }

        private void limpiar()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtTitulo.Text = "";
            lblNroProfesor.Text = "Profesor N°: ";
            dtpFechaNacimiento.Value = DateTime.Today;
            cboBarrio.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
            cboTipoDni.SelectedIndex = -1;
        }

        private void habilitar(bool h)
        {
            txtApellido.Enabled = h;
            txtNombre.Enabled = h;
            txtDni.Enabled = h;
            txtDireccion.Enabled = h;
            txtTitulo.Enabled = h;
            dtpFechaNacimiento.Enabled = h;
            cboBarrio.Enabled = h;
            cboEstadoCivil.Enabled = h;
            cboTipoDni.Enabled = h;
            cboProfesores.Enabled = !h;
            btnAceptar.Enabled = h;
            btnLimpiar.Enabled = h;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cancelar la modificacion?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                VentanaPrincipal.ObtenerInstancia().Show();
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            limpiar();
            cboProfesores.SelectedIndex = -1;
            habilitar(false);
        }

        private void cboProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProfesores.SelectedIndex != -1)
            {

                Profesor prof2 = (Profesor)cboProfesores.SelectedItem;
                lblNroProfesor.Text = "Profesor N°: " + prof2.id_profesor;
                profesor.id_profesor = prof2.id_profesor;
                profesor.nombreCompleto = prof2.nombreCompleto;
                txtApellido.Text = prof2.apellido;
                txtNombre.Text = prof2.nombre;
                txtDni.Text = prof2.nro_dni;
                txtDireccion.Text = prof2.direccion;
                txtTitulo.Text = prof2.titulo_universitario;
                dtpFechaNacimiento.Value = prof2.fecha_nac;
                cboBarrio.SelectedValue = prof2.barrio;
                cboEstadoCivil.SelectedValue = prof2.estado_civil;
                cboTipoDni.SelectedValue = prof2.tipo_dni;
                habilitar(true);
            }
        }

        private async Task<bool> ModificarProfesor()
        {
            //Datos del Profesor
            if (validar())
            {
                profesor.nombre = txtNombre.Text;
                profesor.apellido = txtApellido.Text;
                profesor.tipo_dni = (int)cboTipoDni.SelectedValue;
                profesor.nro_dni = txtDni.Text;
                profesor.fecha_nac = dtpFechaNacimiento.Value;
                profesor.estado_civil = (int)cboEstadoCivil.SelectedValue;
                profesor.barrio = (int)cboEstadoCivil.SelectedValue;
                profesor.direccion = txtDireccion.Text;
                profesor.titulo_universitario = txtTitulo.Text;

                string bodyContent = JsonConvert.SerializeObject(profesor);

                string url = "http://localhost:5041/modificacionProfesor";
                var result = await ClientSingleton.GetInstance().PutAsync(url, bodyContent);

                if (result.Equals("true"))
                {
                    MessageBox.Show("Profesor modificado.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    return true;
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo modificar el profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            await ModificarProfesor();
            cboProfesores.SelectedIndex = -1;
            await CargarProfesoresAsync();
            limpiar();
            habilitar(false);
        }

    }
}
