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
        private AlumnoBL alumnoBL;
        public AlumnoForm()
        {
            InitializeComponent();
            alumno = new Alumno();
            alumnoBL = new AlumnoBL();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Name);

            
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {

        }

        private void btnXML_Click(object sender, EventArgs e)
        {

        }

        private void LoadAlumnoData()
        {
            alumno.ID = Convert.ToInt32(txtId.Text);
            alumno.Nombre = txtName.Text;
        }
    }
}
