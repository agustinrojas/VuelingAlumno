using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Common.Logic.Model;
using log4net;
using Vueling.Business.Logic;

namespace Vueling.Presentation.WinSite
{
    public partial class AlumnoForm : Form
    {
        private ILog log = LogManager.GetLogger("AlumnoForm");
        private Alumno alumno;
        private IAlumnoBL alumnoBL;
        public AlumnoForm()
        {
            InitializeComponent();
            alumno = new Alumno();
            log4net.Config.XmlConfigurator.Configure();
            log.Info("Aplicacion iniciada");
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            log.Debug("Formato txt seleccionado");
            GenerarAlumno();
            alumnoBL = new AlumnoBLTxt();
            //int TipoFichero = 1;
            alumnoBL.add(alumno);
            if (alumno != null)
            {
                MessageBox.Show("Usuario introducido correctamente.");
                LimpiarCampos();
            }
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            log.Debug("Formato JSON seleccionado");
            GenerarAlumno();
            alumnoBL = new AlumnoBLJson();
            //int TipoFichero = 2;
            alumnoBL.add(alumno);
            if (alumno != null)
            {
                MessageBox.Show("Usuario introducido correctamente.");
                LimpiarCampos();
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            log.Debug("Formato XML seleccionado");
            GenerarAlumno();
            alumnoBL = new AlumnoBLXml();
            //int TipoFichero = 3;
            alumnoBL.add(alumno);
            if (alumno != null)
            {
                MessageBox.Show("Usuario introducido correctamente.");
                LimpiarCampos();
            }
        }

        private void GenerarAlumno()
        {
            //alumno.GUID = new Guid();
            alumno.ID = txtId.Text;
            alumno.NOMBRE = txtName.Text;
            alumno.APELLIDOS = txtApellidos.Text;
            alumno.DNI = txtDNI.Text;
            alumno.NACIMIENTO = dpNacimiento.Value;
            log.Debug($"Datos insertados {alumno.ID},{alumno.NOMBRE},{alumno.APELLIDOS},{alumno.DNI}");
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            dpNacimiento.Value = DateTime.Today;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
