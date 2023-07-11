using DataAPI.Dominio;
using DataAPI.Servicios.Implementaciones;
using FrontUTN.Http;
using Newtonsoft.Json;

namespace FrontUTN.Presentaciones
{
    public partial class FormAltaBajaAlumno : Form
    {
        private static FormAltaBajaAlumno instancia;
        private GestorAPI gestor;
        public FormAltaBajaAlumno()
        {
            InitializeComponent();
            gestor = new GestorAPI();
        }

        public static FormAltaBajaAlumno ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormAltaBajaAlumno();
            }
            return instancia;
        }

        private async void FormBaja_Load(object sender, EventArgs e)
        {
            await cargarAmbas(dgvDadosBaja,dgvHabilitados);
            btnBaja.Enabled = false;
            btnAlta.Enabled = false;
        }

        private async Task cargarAmbas(DataGridView dgvDadosBaja, DataGridView dgvHabilitados)
        {
            string url = "http://localhost:5041/alumnosAlta";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<AlumnoAltaBaja>>(result);

            dgvHabilitados.DataSource = lst;
            dgvHabilitados.ClearSelection();

            string url2 = "http://localhost:5041/alumnosBaja";
            var result2 = await ClientSingleton.GetInstance().GetAsync(url2);
            var lst2 = JsonConvert.DeserializeObject<List<AlumnoAltaBaja>>(result2);

            dgvDadosBaja.DataSource = lst2;
            dgvDadosBaja.ClearSelection();
        }

        private async void btnAlta_Click(object sender, EventArgs e)
        {
            
            if (dgvDadosBaja.SelectedRows.Count == 1)
            {
                await gestor.AlumnoDarAlta(dgvDadosBaja.CurrentRow.Cells[0].Value.ToString(), dgvDadosBaja.CurrentRow.Cells[1].Value.ToString());
                await cargarAmbas(dgvDadosBaja, dgvHabilitados);
                MessageBox.Show("Se ha dado de ALTA al alumno correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBaja.Enabled = false;
                btnAlta.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor selecciona solo UN alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvHabilitados.SelectedRows.Count == 1)
            {
                await gestor.AlumnoDarBaja(dgvHabilitados.CurrentRow.Cells[0].Value.ToString(), dgvHabilitados.CurrentRow.Cells[1].Value.ToString());
                await cargarAmbas(dgvDadosBaja, dgvHabilitados);
                MessageBox.Show("Se ha dado de BAJA al alumno correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBaja.Enabled = false;
                btnAlta.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor selecciona solo UN alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal.ObtenerInstancia().Show();
        }

      

        private void dgvHabilitados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnBaja.Enabled = true;
            btnAlta.Enabled = false;
            dgvDadosBaja.ClearSelection();
        }

        private void dgvDadosBaja_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnBaja.Enabled = false;
            btnAlta.Enabled = true;
            dgvHabilitados.ClearSelection();
        }
    }
}
