using CursosLibres.Controllers;
using CursosLibres.Data;
using CursosLibres.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursosLibres.Views
{
    public partial class FrmCursos : Form
    {
        private readonly CursosController controller;
        private readonly List<Sesion> sesionesTemp = new();
        public FrmCursos()
        {
            InitializeComponent();
            controller = new CursosController();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FrmCursos_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string fecha = dtpFechaHora.Value.ToString("dd/MM/yyyy");
            string Hora = dateTimePicker1.Text.Trim();
            string duracion = txtDuracion.Text.Trim();

            if (string.IsNullOrEmpty(fecha) || string.IsNullOrEmpty(Hora) || string.IsNullOrEmpty(duracion))
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            string sesionInfo = ($"{fecha} | {Hora} | {duracion}");
            lstSesiones.Items.Add(sesionInfo);
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                    string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(txtCupo.Text) ||
                    string.IsNullOrWhiteSpace(txtCosto.Text) ||
                    comboBox1.SelectedItem == null ||
                    mbModalidad.SelectedItem == null)
                {

                }

                string titulo = txtTitulo.Text.Trim();
                string categoria = textBox1.Text.Trim();
                int cupo = int.Parse(txtCupo.Text);
                decimal costo = decimal.Parse(txtCosto.Text);
                Docente docente = (Docente)comboBox1.SelectedItem;

                string modalidad = mbModalidad.SelectedItem.ToString();
                Curso nuevoCurso = null;


                if (modalidad == "Presencial")
                {
                    if (string.IsNullOrWhiteSpace(txtCampus.Text) || string.IsNullOrWhiteSpace(txtSalon.Text))
                    {
                        MessageBox.Show("Debe ingresar Campus y Salón para un curso Presencial.");
                        return;
                    }

                    controller.CrearPresencial(titulo, categoria, cupo, costo, docente, txtCampus.Text.Trim(), txtSalon.Text.Trim());
                    nuevoCurso = InMemoryDb.Cursos.Last();
                }
                else if (modalidad == "Virtual")
                {
                    if (string.IsNullOrWhiteSpace(txtPlataforma.Text) || string.IsNullOrWhiteSpace(txtEnlace.Text))
                    {
                        MessageBox.Show("Debe ingresar Plataforma y Enlace para un curso Virtual.");
                        return;
                    }

                    if (!Uri.IsWellFormedUriString(txtEnlace.Text, UriKind.Absolute))
                    {
                        MessageBox.Show("Debe ingresar un URL válido para el curso Virtual.");
                        return;
                    }

                    controller.CrearVirtual(titulo, categoria, cupo, costo, docente, txtPlataforma.Text.Trim(), txtEnlace.Text.Trim());
                    nuevoCurso = InMemoryDb.Cursos.Last();
                }
                else if (modalidad == "Híbrido")
                {
                    if (string.IsNullOrWhiteSpace(txtCampus.Text) || string.IsNullOrWhiteSpace(txtSalon.Text) ||
                        string.IsNullOrWhiteSpace(txtPlataforma.Text) || string.IsNullOrWhiteSpace(txtEnlace.Text))
                    {
                        MessageBox.Show("Debe ingresar Campus, Salón, Plataforma y Enlace para un curso Híbrido.");
                        return;
                    }

                    if (!Uri.IsWellFormedUriString(txtEnlace.Text, UriKind.Absolute))
                    {
                        MessageBox.Show("Debe ingresar un URL válido para el curso Híbrido.");
                        return;
                    }

                    controller.CrearHibrido(titulo, categoria, cupo, costo, docente, txtCampus.Text.Trim(), txtSalon.Text.Trim(), txtEnlace.Text.Trim());
                    nuevoCurso = InMemoryDb.Cursos.Last();
                }

                foreach (string item in lstSesiones.Items)
                {

                    string[] partes = item.Split('|');
                    DateTime inicio = DateTime.Parse($"{partes[0].Trim()} {partes[1].Trim()}");
                    TimeSpan duracion = TimeSpan.Parse(partes[2].Trim());

                    controller.AgregarSesion(nuevoCurso, inicio, duracion);
                }

                MessageBox.Show("Curso creado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
        private void dtpFechaHora_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtCupo_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCupo.Text, out int cupo) || cupo <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }
        }
        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCosto.Text, out decimal costo) || costo <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }
        }
        private void txtEnlace_TextChanged(object sender, EventArgs e)
        {
            if (!Uri.IsWellFormedUriString(txtEnlace.Text, UriKind.Absolute))
            {
                MessageBox.Show("Ingrese un URL válido.");
                return;
            }
        }

        private void mbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            {

            }
        }
    }
}




