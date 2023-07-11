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
        private Alumno2 alu2;
        private GestorAPI gestor;
        public FormModificacionAlumno()
        {
            InitializeComponent();
            alu2 = new Alumno2();
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
            limpiar();
            habilitar(false);
            lblNroAlumno.Text = "Alumno N°: ";
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

        private async Task CargarTecnicaturasAsync()
        {
            string url = "http://localhost:5041/tecnicaturas";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Tecnicatura>>(result);
            cboTecnicatura.DataSource = lst;
            cboTecnicatura.DisplayMember = "tecnicatura";
            cboTecnicatura.ValueMember = "Id";
            cboTecnicatura.SelectedIndex = -1;

        }

        private async Task CargarSituacionHabAsync()
        {
            string url = "http://localhost:5041/situacionHab";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<SituacionHab>>(result);
            cboSituacionHabitacional.DataSource = lst;
            cboSituacionHabitacional.DisplayMember = "situacion_hab";
            cboSituacionHabitacional.ValueMember = "Id";
            cboSituacionHabitacional.SelectedIndex = -1;

        }

        private async Task CargarSituacionLabAsync()
        {
            string url = "http://localhost:5041/situacionLab";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<SituacionLab>>(result);
            cboSituacionLaboral.DataSource = lst;
            cboSituacionLaboral.DisplayMember = "situacion_lab";
            cboSituacionLaboral.ValueMember = "Id";
            cboSituacionLaboral.SelectedIndex = -1;

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
            txtApellido.Enabled = h;
            txtNombre.Enabled = h;
            txtDni.Enabled = h;
            txtDireccion.Enabled = h;
            dtpFechaNacimiento.Enabled = h;
            cboBarrio.Enabled = h;
            cboEstadoCivil.Enabled = h;
            cboSituacionHabitacional.Enabled = h;
            cboSituacionLaboral.Enabled = h;
            cboTecnicatura.Enabled = h;
            cboTipoDni.Enabled = h;
            cboAlumnos.Enabled = !h;
            btnAceptar.Enabled = h;
            btnLimpiar.Enabled = h;
        }

        private bool validar()
        {
            if (String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text)
                || String.IsNullOrEmpty(txtDni.Text) || cboBarrio.SelectedIndex == -1 || cboEstadoCivil.SelectedIndex == -1
                || cboSituacionHabitacional.SelectedIndex == -1 || cboSituacionLaboral.SelectedIndex == -1 || cboTecnicatura.SelectedIndex == -1
                || cboTipoDni.SelectedIndex == -1)
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
            if (DateTime.Today.Year - dtpFechaNacimiento.Value.Year < 17)
            {
                MessageBox.Show("ERROR. El alumno debe ser mayor a 17 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async Task<bool> ModificarAlumno()
        {
            //Datos del Alumno
            if (validar())
            {
                alu2.nombre = txtNombre.Text;
                alu2.apellido = txtApellido.Text;
                alu2.tipo_dni = (int)cboTipoDni.SelectedValue;
                alu2.nro_dni = txtDni.Text;
                alu2.tecnicatura = (int)cboTecnicatura.SelectedValue;
                alu2.fecha_nac = dtpFechaNacimiento.Value;
                alu2.estado_civil = (int)cboEstadoCivil.SelectedValue;
                alu2.situacion_habitacional = (int)cboSituacionHabitacional.SelectedValue;
                alu2.situacion_laboral = (int)cboSituacionLaboral.SelectedValue;
                alu2.barrio = (int)cboEstadoCivil.SelectedValue;
                alu2.direccion = txtDireccion.Text;

                string bodyContent = JsonConvert.SerializeObject(alu2);

                string url = "http://localhost:5041/modificacionAlumno";
                var result = await ClientSingleton.GetInstance().PutAsync(url, bodyContent);

                if (result.Equals("true"))
                {
                    MessageBox.Show("Alumno modificado.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    return true;
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo modificar el alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            await ModificarAlumno();
            cboAlumnos.SelectedIndex = -1;
            await CargarAlumnosConAltaAsync();
            limpiar();
            habilitar(false);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            lblNroAlumno.Text = "Alumno N°: ";
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

                Alumno2 alu3 = (Alumno2)cboAlumnos.SelectedItem;
                alu2.id_alumno = alu3.id_alumno;
                lblNroAlumno.Text = "Alumno N°: " + alu3.id_alumno.ToString();
                alu2.nombreCompleto = alu3.nombreCompleto;
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
            lblNroAlumno.Text = "Alumno N°: ";
        }
    }
}
