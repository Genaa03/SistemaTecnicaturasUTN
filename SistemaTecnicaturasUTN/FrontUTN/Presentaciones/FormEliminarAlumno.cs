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
    public partial class FormEliminarAlumno : Form
    {
        private static FormEliminarAlumno instancia;
        private Alumno2 alu3;
        private GestorAPI gestor;
        public FormEliminarAlumno()
        {
            InitializeComponent();
            alu3 = new Alumno2();
            gestor = new GestorAPI();
        }

        public static FormEliminarAlumno ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormEliminarAlumno();
            }
            return instancia;
        }

        private async void FormEliminarAlumno_Load(object sender, EventArgs e)
        {
            await CargarAlumnosConAltaAsync();
            await CargarBarriosAsync();
            await CargarEstadosCivilAsync();
            await CargarSituacionHabAsync();
            await CargarSituacionLabAsync();
            await CargarTecnicaturasAsync();
            await CargarTiposDNIAsync();
            limpiar();
            habilitar(false);
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

        private async Task CargarTecnicaturasAsync()
        {
            string url = "http://localhost:5041/tecnicaturas";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Tecnicatura>>(result);
            cboTecnicatura.DataSource = lst;
            cboTecnicatura.DisplayMember = "tecnicatura";
            cboTecnicatura.ValueMember = "id";
            cboTecnicatura.SelectedIndex = -1;

        }

        private async Task CargarSituacionHabAsync()
        {
            string url = "http://localhost:5041/situacionHab";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<SituacionHab>>(result);
            cboSituacionHabitacional.DataSource = lst;
            cboSituacionHabitacional.DisplayMember = "situacion_hab";
            cboSituacionHabitacional.ValueMember = "id";
            cboSituacionHabitacional.SelectedIndex = -1;

        }

        private async Task CargarSituacionLabAsync()
        {
            string url = "http://localhost:5041/situacionLab";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<SituacionLab>>(result);
            cboSituacionLaboral.DataSource = lst;
            cboSituacionLaboral.DisplayMember = "situacion_lab";
            cboSituacionLaboral.ValueMember = "id";
            cboSituacionLaboral.SelectedIndex = -1;

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

        private async Task CargarAlumnosConAltaAsync()
        {
            string url = "http://localhost:5041/alumnosConAlta";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Alumno2>>(result);
            cboAlumnos.DataSource = lst;
            cboAlumnos.DisplayMember = "nombreCompleto";
            cboAlumnos.ValueMember = "id_alumno";
            cboAlumnos.SelectedIndex = -1;

        }

        private void limpiar()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            cboBarrio.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
            cboSituacionHabitacional.SelectedIndex = -1;
            cboSituacionLaboral.SelectedIndex = -1;
            cboTecnicatura.SelectedIndex = -1;
            cboTipoDni.SelectedIndex = -1;
        }

        private void habilitar(bool h)
        {
            cboAlumnos.Enabled = !h;
            btnEliminar.Enabled = h;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                this.Close();
                VentanaPrincipal.ObtenerInstancia().Show();
        }

        private void cboAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAlumnos.SelectedIndex != -1)
            {

                alu3 = (Alumno2)cboAlumnos.SelectedItem;
                txtApellido.Text = alu3.apellido;
                txtNombre.Text = alu3.nombre;
                txtDni.Text = alu3.nro_dni;
                txtDireccion.Text = alu3.direccion;
                dtpFechaNacimiento.Value = alu3.fecha_nac;
                cboBarrio.SelectedValue = alu3.barrio;
                cboEstadoCivil.SelectedValue = alu3.estado_civil;
                cboSituacionHabitacional.SelectedValue = alu3.situacion_habitacional;
                cboSituacionLaboral.SelectedValue = alu3.situacion_laboral;
                cboTecnicatura.SelectedValue = alu3.tecnicatura;
                cboTipoDni.SelectedValue = alu3.tipo_dni;
                habilitar(true);
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            limpiar();
            cboAlumnos.SelectedIndex = -1;
            habilitar(false);
        }

        private async Task<bool> EliminarAlumno(int id, string nombre, string apellido)
        {
            string url = "http://localhost:5041/eliminacionAlumno?id=" + id+ "&nombre=" + nombre+ "&apellido=" + apellido;
            var result = await ClientSingleton.GetInstance().DeleteAsync(url);
            var lst = JsonConvert.DeserializeObject<bool>(result);

            if (result.Equals("true"))
            {
                MessageBox.Show("Alumno eliminado.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                return true;
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo eliminar el alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea eliminar a "+ alu3.nombreCompleto +"?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                await EliminarAlumno(alu3.id_alumno, alu3.nombre, alu3.apellido);
                cboAlumnos.SelectedIndex = -1;
                await CargarAlumnosConAltaAsync();
                limpiar();
                habilitar(false);
            }
        }
    }
}
