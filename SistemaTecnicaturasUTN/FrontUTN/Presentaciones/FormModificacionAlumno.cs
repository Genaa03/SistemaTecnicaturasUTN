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
    public partial class FormModificacionAlumno : Form
    {
        private static FormModificacionAlumno instancia;
        private Alumno alumno;
        private GestorAPI gestor;
        public FormModificacionAlumno()
        {
            InitializeComponent();
            alumno = new Alumno();
            gestor = new GestorAPI();
        }

        public static FormModificacionAlumno ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormModificacionAlumno();
            }
            return instancia;
        }

        private async void FormModificacionAlumno_Load(object sender, EventArgs e)
        {
            await CargarAlumnosConAltaAsync();
            await CargarBarriosAsync();
            await CargarEstadosCivilAsync();
            await CargarSituacionHabAsync();
            await CargarSituacionLabAsync();
            await CargarTecnicaturasAsync();
            await CargarTiposDNIAsync();
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
            cboAlumnos.ValueMember = "id";
            cboAlumnos.SelectedIndex = -1;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cancelar la modificacion?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                VentanaPrincipal.ObtenerInstancia().Show();
            }
        }

        private void cboAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboAlumnos.SelectedIndex != -1)
            {
                Alumno2 alu = (Alumno2)cboAlumnos.SelectedItem;
                txtApellido.Text = alu.apellido;
                txtNombre.Text = alu.nombre;
                txtDni.Text = alu.nro_dni;
                txtDireccion.Text = alu.direccion;
                dtpFechaNacimiento.Value = alu.fecha_nac;
                cboBarrio.SelectedValue = alu.barrio;
                cboEstadoCivil.SelectedValue = alu.estado_civil;
                cboSituacionHabitacional.SelectedValue = alu.situacion_habitacional;
                cboSituacionLaboral.SelectedValue = alu.situacion_laboral;
                cboTecnicatura.SelectedValue = alu.tecnicatura;
                cboTipoDni.SelectedValue = alu.tipo_dni;
            }
        }
    }
}
