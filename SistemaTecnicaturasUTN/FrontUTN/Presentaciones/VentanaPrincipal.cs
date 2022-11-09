using FrontUTN.Http;
using FrontUTN.Presentaciones;

namespace FrontUTN.Presentaciones
{
    public partial class VentanaPrincipal : Form
    {
        private static VentanaPrincipal instancia;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public static VentanaPrincipal ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new VentanaPrincipal();
            }
            return instancia;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInscripcionAlumno.ObtenerInstancia().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los autores de este proyecto son:\n\n• Freccia, Genaro Farid\n• Bergoglio, Felipe" +
                "\n• Cepeda, German\n• Virga, Santos José\n• Cuello, Cristian Santiago", "AUTORES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void altaBajaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAltaBajaAlumno.ObtenerInstancia().ShowDialog();
        }

        private void modificacionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModificacionAlumno.ObtenerInstancia().ShowDialog();
        }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEliminarAlumno.ObtenerInstancia().ShowDialog();
        }

        private void altaExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAltaExamen.ObtenerInstancia().ShowDialog();
        }

        private void altaProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInscripcionProfesor.ObtenerInstancia().ShowDialog();
        }

        private void modificacionProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModificacionProfesor.ObtenerInstancia().ShowDialog();
        }

        private void eliminacionProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEliminarProfesor.ObtenerInstancia().ShowDialog();
        }
    }
}
