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
    public partial class FormEliminarProfesor : Form
    {
        private static FormEliminarProfesor instancia;
        private Profesor prof;
        private GestorAPI gestor;
        public FormEliminarProfesor()
        {
            InitializeComponent();
            prof = new Profesor();
            gestor = new GestorAPI();
        }

        public static FormEliminarProfesor ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormEliminarProfesor();
            }
            return instancia;
        }

        private async void FormEliminarProfesor_Load(object sender, EventArgs e)
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
            cboProfesores.Enabled = !h;
            btnEliminar.Enabled = h;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal.ObtenerInstancia().Show();
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

                prof = (Profesor)cboProfesores.SelectedItem;
                txtApellido.Text = prof.apellido;
                txtNombre.Text = prof.nombre;
                txtDni.Text = prof.nro_dni;
                txtDireccion.Text = prof.direccion;
                txtTitulo.Text = prof.titulo_universitario;
                dtpFechaNacimiento.Value = prof.fecha_nac;
                cboBarrio.SelectedValue = prof.barrio;
                cboEstadoCivil.SelectedValue = prof.estado_civil;
                cboTipoDni.SelectedValue = prof.tipo_dni;
                habilitar(true);
            }
        }

        private async Task<bool> EliminarProfesor(int id, string nombre, string apellido)
        {
            string url = "http://localhost:5041/eliminacionProfesor?Id=" + id + "&Nombre=" + nombre + "&apellido=" + apellido;
            var result = await ClientSingleton.GetInstance().DeleteAsync(url);
            var lst = JsonConvert.DeserializeObject<bool>(result);

            if (result.Equals("true"))
            {
                MessageBox.Show("Profesor eliminado.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                return true;
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo eliminar el profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea eliminar a " + prof.nombreCompleto + "?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                await EliminarProfesor(prof.id_profesor, prof.nombre, prof.apellido);
                cboProfesores.SelectedIndex = -1;
                await CargarProfesoresAsync();
                limpiar();
                habilitar(false);
            }
        }
    }
}
