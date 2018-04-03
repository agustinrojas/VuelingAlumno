using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic.Model;

namespace Vueling.Presentation.WinSite
{
    public partial class AlumnoForm : Form
    {
        private Alumno alumno;
        private AlumnoBL _alumnoBL;
        public AlumnoForm()
        {
            InitializeComponent();
            alumno = new Alumno();
            _alumnoBL = new AlumnoBL();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            GenerarAlumno();
            int TipoFichero = 1;
            Alumno al = _alumnoBL.Add(alumno, TipoFichero);
            if (al != null)
            {
                MessageBox.Show("Usuario introducido correctamente.");
                LimpiarCampos();
            }
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            GenerarAlumno();
            int TipoFichero = 2;
            Alumno al = _alumnoBL.Add(alumno, TipoFichero);
            if (al != null)
            {
                MessageBox.Show("Usuario introducido correctamente.");
                LimpiarCampos();
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            GenerarAlumno();
            int TipoFichero = 3;
            Alumno al = _alumnoBL.Add(alumno, TipoFichero);
            if (al != null)
            {
                MessageBox.Show("Usuario introducido correctamente.");
                LimpiarCampos();
            }
        }

        private void GenerarAlumno()
        {
            alumno.GUID = new Guid();
            alumno.ID = txtId.Text;
            alumno.NOMBRE = txtName.Text;
            alumno.APELLIDOS = txtApellidos.Text;
            alumno.DNI = txtDNI.Text;
            alumno.NACIMIENTO = dpNacimiento.Value;
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            dpNacimiento.Value = DateTime.Today;

        }
    }
}
