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
    public partial class FormAltaExamen : Form
    {
        private static FormAltaExamen instancia;
        private Examen examen;
        private GestorAPI gestor;
        public FormAltaExamen()
        {
            InitializeComponent();
            examen = new Examen();
            gestor = new GestorAPI();
        }

        public static FormAltaExamen ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormAltaExamen();
            }
            return instancia;
        }

        private async void FormAltaExamen_Load(object sender, EventArgs e)
        {
            await CargarMateriasAsync();
            await CargarTiposExamenesAsync();
            await CargarAlumnosConAltaAsync();
            limpiar();
            CalcularPromedio();
            ProximoExamen();
        }

        private async Task CargarMateriasAsync()
        {
            string url = "http://localhost:5041/materias";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Materia>>(result);
            CboMateria.DataSource = lst;
            CboMateria.DisplayMember = "materia";
            CboMateria.ValueMember = "id";
            CboMateria.SelectedIndex = -1;

        }

        private async Task CargarTiposExamenesAsync()
        {
            string url = "http://localhost:5041/tipoExamenes";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoExamen>>(result);
            CboTipoExamen.DataSource = lst;
            CboTipoExamen.DisplayMember = "tipo_examen";
            CboTipoExamen.ValueMember = "id";
            CboTipoExamen.SelectedIndex = -1;

        }
        private async Task CargarAlumnosConAltaAsync()
        {
            string url = "http://localhost:5041/alumnosConAlta";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Alumno2>>(result);
            CboAlumno.DataSource = lst;
            CboAlumno.DisplayMember = "nombreCompleto";
            CboAlumno.ValueMember = "id_alumno";
            CboAlumno.SelectedIndex = -1;

        }

        private void ProximoExamen()
        {
            lblNroExamen.Text = "Examen N°: " + gestor.GetProximoExamen();
        }

        private void habilitar(bool v)
        {
            CboTipoExamen.Enabled = v;
            CboMateria.Enabled = v;
            dtpFecha.Enabled = v;
        }

        private void limpiar()
        {
            dtpFecha.Value = DateTime.Today;
            CboMateria.SelectedIndex = -1;
            CboAlumno.SelectedIndex = -1;
            CboTipoExamen.SelectedIndex = -1;
            nudNota.Value = 1;
            dgvAlumnos.Rows.Clear();
        }

        private bool validar()
        {
            if (CboMateria.SelectedIndex == -1 || CboTipoExamen.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR. Algun campo se encuentra vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DateTime.Today < dtpFecha.Value)
            {
                MessageBox.Show("ERROR. La fecha no puede ser un futuro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CalcularPromedio()
        {
            if(dgvAlumnos.Rows.Count > 0)
            {
                lblPromedio.Text = "Promedio: " + examen.CalcularPromedio();
            }
            else
            {
                lblPromedio.Text = "Promedio: 0";
            }
            
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cancelar el alta del examen?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                VentanaPrincipal.ObtenerInstancia().Show();
            }
        }

        private async Task GuardarExamenAsync()
        {
            examen.materia = (int)CboMateria.SelectedValue;
            examen.tipo_examen = (int)CboTipoExamen.SelectedValue;
            examen.fecha = Convert.ToDateTime(dtpFecha.Value);
            string bodyContent = JsonConvert.SerializeObject(examen);

            string url = "http://localhost:5041/crearExamen";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Examen registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el examen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if(dgvAlumnos.Rows.Count > 0) 
                {
                    await GuardarExamenAsync();
                    limpiar();
                    habilitar(true);
                    CalcularPromedio();
                    ProximoExamen();
                }
                else
                {
                    MessageBox.Show("ERROR. Tiene que agregar los alumnos con sus notas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                foreach (DataGridViewRow row in dgvAlumnos.Rows)
                {
                    if (row.Cells["ColAlumno"].Value.ToString().Equals(CboAlumno.Text))
                    {
                        MessageBox.Show("ALUMNO: " + CboAlumno.Text + " ya se encuentra cargado!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }
                }

                Alumno2 alu = (Alumno2)CboAlumno.SelectedItem;
                int nota = Convert.ToInt32(nudNota.Value);

                DetalleExamen detalle = new DetalleExamen(alu, nota);
                examen.AgregarExamen(detalle);
                dgvAlumnos.Rows.Add(new object[] { alu.id_alumno, alu.nombreCompleto, nudNota.Value, CboMateria.Text, CboTipoExamen.Text });

                habilitar(false);
                CalcularPromedio();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(true);
            CalcularPromedio();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumnos.CurrentCell.ColumnIndex == 5)
            {
                examen.QuitarExamen(dgvAlumnos.CurrentRow.Index);
                dgvAlumnos.Rows.Remove(dgvAlumnos.CurrentRow);
                CalcularPromedio();
            }
        }
    }
}

