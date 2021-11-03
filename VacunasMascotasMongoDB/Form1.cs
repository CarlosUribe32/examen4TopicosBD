using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VacunasMascotasMongoDB.Models;


namespace VacunasMascotasMongoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicializarComboBox();
            cargarListaMascotas();
        }

        private void cargarListaMascotas()
        {
            dataGridMascotas.DataSource = null;
            dataGridMascotas.DataSource = AccesoDatos.obtieneListaMascotas();
            dataGridMascotas.Columns[0].Visible = false;

            dataGridMascotas2.DataSource = null;
            dataGridMascotas2.DataSource = AccesoDatos.obtieneListaMascotas();
            dataGridMascotas2.Columns[0].Visible = false;
        }

        private void inicializarComboBox()
        {
            cbxEspecieM.DataSource = null;
            cbxEspecieM.DataSource = AccesoDatos.obtieneNombreEspecies();
            cbxEspecieM.SelectedIndex = 0;
            seleccionCorrectaRazascbx1(cbxEspecieM.Text);

            cbxEspecieM2.DataSource = null;
            cbxEspecieM2.DataSource = AccesoDatos.obtieneNombreEspecies();
            cbxEspecieM2.SelectedIndex = 0;
            seleccionCorrectaRazascbx2(cbxEspecieM2.Text);

            cbxVeterinaria.DataSource = null;
            cbxVeterinaria.DataSource = AccesoDatos.obtieneListaVeterinarias();
            cbxVeterinaria.SelectedIndex = 0;

            cbxVeterinaria2.DataSource = null;
            cbxVeterinaria2.DataSource = AccesoDatos.obtieneListaVeterinarias();
            cbxVeterinaria2.SelectedIndex = 0;

        }

        private void seleccionCorrectaRazascbx1(string especie)
        {
            cbxRazaM.DataSource = null;
            cbxRazaM.DataSource = AccesoDatos.obtieneNombreRazas(especie);
            cbxRazaM.SelectedIndex = 0;
        }
        private void seleccionCorrectaRazascbx2(string especie)
        {
            cbxRazaM2.DataSource = null;
            cbxRazaM2.DataSource = AccesoDatos.obtieneNombreRazas(especie);
            cbxRazaM2.SelectedIndex = 0;
        }

        private void cbxEspecieM_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionCorrectaRazascbx1(cbxEspecieM.Text);
        }

        private void cbxEspecieM2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionCorrectaRazascbx2(cbxEspecieM2.Text);
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreM.Text != "" && txtAñoM.Text != "" )
                {
                    Mascota mascota = new Mascota
                    {
                        Nombre = txtNombreM.Text,
                        Especie = cbxEspecieM.SelectedItem.ToString(),
                        Raza = cbxRazaM.SelectedItem.ToString(),
                        Año_nacimiento = int.Parse(txtAñoM.Text)

                    };
                    AccesoDatos.insertarMascota(mascota);
                    MessageBox.Show("Mascota agregada exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarListaMascotas();
                    clearCamposAgregarM();
                }
                    
            }
            catch (FormatException error)
            {
                MessageBox.Show("Los campos deben estar llenos y numéricos segun corresponda\n" +
                    error.Message,
                    "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
        }
        private void clearCamposAgregarM()
        {
            txtNombreM.Text = "";
            txtAñoM.Text = "";
        }

        private void dataGridMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreM2.Text = dataGridMascotas.SelectedCells[1].Value.ToString();
            txtAñoM2.Text = dataGridMascotas.SelectedCells[4].Value.ToString();
            cbxEspecieM2.Text = dataGridMascotas.SelectedCells[2].Value.ToString();
            cbxRazaM2.Text = dataGridMascotas.SelectedCells[3].Value.ToString();
        }

        private void btnEditarM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreM2.Text != "" && txtAñoM2.Text != "")
                {
                    Mascota mascota = new Mascota
                    {
                        Id = dataGridMascotas.SelectedCells[0].Value.ToString(),
                        Nombre = txtNombreM2.Text,
                        Especie = cbxEspecieM2.SelectedItem.ToString(),
                        Raza = cbxRazaM2.SelectedItem.ToString(),
                        Año_nacimiento = int.Parse(txtAñoM2.Text)

                    };

                    Mascota unaMascota = AccesoDatos.obtieneUnaMascota(mascota);

                    unaMascota.Nombre = mascota.Nombre;
                    unaMascota.Especie = mascota.Especie;
                    unaMascota.Raza = mascota.Raza;
                    unaMascota.Año_nacimiento = mascota.Año_nacimiento;

                    AccesoDatos.actualizarMascota(unaMascota);
                    MessageBox.Show("Mascota actualizada exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarListaMascotas();
                    clearCamposActualizarEliminarM();
                }
                    
            }
            catch (Exception error)
            {
                MessageBox.Show("Los campos deben estar llenos y numéricos segun corresponda\n" +
                    error.Message,
                    "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
        }
        private void clearCamposActualizarEliminarM()
        {
            txtNombreM2.Text = "";
            txtAñoM2.Text = "";
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            if (txtNombreM2.Text != "" && txtAñoM2.Text != "")
            {

                try
                {
                    Mascota mascota = new Mascota
                    {
                        Id = dataGridMascotas.SelectedCells[0].Value.ToString(),
                        Nombre = txtNombreM2.Text,
                        Especie = cbxEspecieM2.SelectedItem.ToString(),
                        Raza = cbxRazaM2.SelectedItem.ToString(),
                        Año_nacimiento = int.Parse(txtAñoM2.Text)

                    };
                    DialogResult resultadoAdvertencia = MessageBox.Show($"Está seguro que desea borrar la mascota?",
                     $"Borrar la mascota {mascota.Nombre}", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (resultadoAdvertencia == DialogResult.OK)
                    {
                        AccesoDatos.eliminarMascota(mascota);
                        MessageBox.Show("Mascota Eliminada exitosamente.",
                            "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListaMascotas();
                        clearCamposActualizarEliminarM();
                    }

                }
                catch (FormatException error)
                {
                    MessageBox.Show("Los campos deben estar llenos y numéricos segun corresponda\n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
        }

        private void dataGridMascotas2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mascota mascota = new Mascota
            {
                Id = dataGridMascotas2.SelectedCells[0].Value.ToString(),
                Nombre = dataGridMascotas2.SelectedCells[1].Value.ToString(),
                Especie = dataGridMascotas2.SelectedCells[2].Value.ToString(),
                Raza = dataGridMascotas2.SelectedCells[3].Value.ToString(),
                Año_nacimiento = int.Parse(dataGridMascotas2.SelectedCells[4].Value.ToString())

            };

            actualizarConsultasGrid(mascota);

            cbxVacuna.DataSource = null;
            cbxVacuna.DataSource = AccesoDatos.obtieneVacunas(mascota.Especie);
            cbxVacuna.SelectedIndex = 0;

            cbxVacuna2.DataSource = null;
            cbxVacuna2.DataSource = AccesoDatos.obtieneVacunas(mascota.Especie);
            cbxVacuna2.SelectedIndex = 0;
        }
        private void actualizarConsultasGrid(Mascota mascota) {
            dataGridConsultas.DataSource = null;
            dataGridConsultas.DataSource = AccesoDatos.obtieneDetalleConsultasMascotas(mascota);
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            if (cbxVacuna.Text != "")
            {
                try
                {
                    Mascota mascota = new Mascota
                    {
                        Id = dataGridMascotas2.SelectedCells[0].Value.ToString(),
                        Nombre = dataGridMascotas2.SelectedCells[1].Value.ToString(),
                        Especie = dataGridMascotas2.SelectedCells[2].Value.ToString(),
                        Raza = dataGridMascotas2.SelectedCells[3].Value.ToString(),
                        Año_nacimiento = int.Parse(dataGridMascotas2.SelectedCells[4].Value.ToString())

                    };
                    Citas cita = new Citas
                    {
                        Veterinaria = cbxVeterinaria.Text,
                        Vacuna = cbxVacuna.Text,
                        Fecha_vacunacion = dateTimePicker1.Value.ToString("yyyy-MM-dd")
                    };
                    Mascota unaMascota = AccesoDatos.obtieneUnaMascota(mascota);

                    if (unaMascota.Citas == null)
                    {
                        unaMascota.Citas = new List<Citas>();
                    }

                    unaMascota.Citas.Add(cita);
                    AccesoDatos.actualizarMascota(unaMascota);
                    MessageBox.Show("Cita agregada exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    actualizarConsultasGrid(mascota);
                }
                catch (FormatException error)
                {
                    MessageBox.Show("Seleccione una Mascota\n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
        }

        private void dataGridConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxVacuna2.Text = dataGridConsultas.SelectedCells[0].Value.ToString();
            cbxVeterinaria2.Text = dataGridConsultas.SelectedCells[1].Value.ToString();
            dateTimePicker2.Value = DateTime.ParseExact(dataGridConsultas.SelectedCells[2].Value.ToString(), "yyyy-MM-dd", null);
        }

        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            if (cbxVacuna.Text != "")
            {
                try
                {
                    Mascota mascota = new Mascota
                    {
                        Id = dataGridMascotas2.SelectedCells[0].Value.ToString(),
                        Nombre = dataGridMascotas2.SelectedCells[1].Value.ToString(),
                        Especie = dataGridMascotas2.SelectedCells[2].Value.ToString(),
                        Raza = dataGridMascotas2.SelectedCells[3].Value.ToString(),
                        Año_nacimiento = int.Parse(dataGridMascotas2.SelectedCells[4].Value.ToString())

                    };
                    Citas newCita = new Citas
                    {
                        Veterinaria = cbxVeterinaria2.Text,
                        Vacuna = cbxVacuna2.Text,
                        Fecha_vacunacion = dateTimePicker2.Value.ToString("yyyy-MM-dd")
                    };
                    Citas oldCita = new Citas
                    {
                        Veterinaria = dataGridConsultas.SelectedCells[1].Value.ToString(),
                        Vacuna = dataGridConsultas.SelectedCells[0].Value.ToString(),
                        Fecha_vacunacion = dataGridConsultas.SelectedCells[2].Value.ToString()
                    };
                    Mascota unaMascota = AccesoDatos.obtieneUnaMascota(mascota);

                    if (unaMascota.Citas == null)
                    {
                        unaMascota.Citas = new List<Citas>();
                    }

                    for (int i = 0; i < unaMascota.Citas.Count; i++) {
                        if (unaMascota.Citas[i].Vacuna.Equals(oldCita.Vacuna) && unaMascota.Citas[i].Veterinaria.Equals(oldCita.Veterinaria) && unaMascota.Citas[i].Fecha_vacunacion.Equals(oldCita.Fecha_vacunacion)) {
                            unaMascota.Citas[i] = newCita;
                            break;
                        }
                    }

                    AccesoDatos.actualizarMascota(unaMascota);
                    MessageBox.Show("Cita actualizada exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    actualizarConsultasGrid(mascota);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Seleccione una Mascota y Una cita\n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            if (cbxVacuna.Text != "")
            {
                try
                {
                    Mascota mascota = new Mascota
                    {
                        Id = dataGridMascotas2.SelectedCells[0].Value.ToString(),
                        Nombre = dataGridMascotas2.SelectedCells[1].Value.ToString(),
                        Especie = dataGridMascotas2.SelectedCells[2].Value.ToString(),
                        Raza = dataGridMascotas2.SelectedCells[3].Value.ToString(),
                        Año_nacimiento = int.Parse(dataGridMascotas2.SelectedCells[4].Value.ToString())

                    };
                    Citas oldCita = new Citas
                    {
                        Veterinaria = dataGridConsultas.SelectedCells[1].Value.ToString(),
                        Vacuna = dataGridConsultas.SelectedCells[0].Value.ToString(),
                        Fecha_vacunacion = dataGridConsultas.SelectedCells[2].Value.ToString()
                    };
                    Mascota unaMascota = AccesoDatos.obtieneUnaMascota(mascota);

                    if (unaMascota.Citas == null)
                    {
                        unaMascota.Citas = new List<Citas>();
                    }

                    for (int i = 0; i < unaMascota.Citas.Count; i++)
                    {
                        if (unaMascota.Citas[i].Vacuna.Equals(oldCita.Vacuna) && unaMascota.Citas[i].Veterinaria.Equals(oldCita.Veterinaria) && unaMascota.Citas[i].Fecha_vacunacion.Equals(oldCita.Fecha_vacunacion))
                        {
                            unaMascota.Citas.Remove(unaMascota.Citas[i]);
                            break;
                        }
                    }

                    AccesoDatos.actualizarMascota(unaMascota);
                    MessageBox.Show("Cita Eliminada exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    actualizarConsultasGrid(mascota);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Seleccione una Mascota y Una cita\n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
        }
    }
}
