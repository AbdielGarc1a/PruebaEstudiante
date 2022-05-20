using AppCore.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaProg
{
    public partial class Form1 : Form
    {
        public EstudianteServices estudianteService;
        public double promedio;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Carnet = txtCarnet.Text,
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text,
                Phone = txtTelefono.Text,
                Matematica = int.Parse(txtMatematica.Text),
                Contabilidad = int.Parse(txtContabilidad.Text),
                Programacion = int.Parse(txtProgramacion.Text),
                Estadistica = int.Parse(txtEstadistica.Text)
            };

          

            promedio = (estudiante.Matematica + estudiante.Contabilidad + estudiante.Estadistica + estudiante.Programacion) / 4;
            txtPromedio.Enabled = true;
            txtPromedio.Text = promedio.ToString();
        }
    }
}
