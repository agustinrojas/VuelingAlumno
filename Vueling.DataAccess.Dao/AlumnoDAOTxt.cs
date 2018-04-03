using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoDAOTxt : IAlumnoDAO
    {
        public Alumno add(Alumno alumno)
        {
            //recuperamos variable del app.config
            //string rutaFicheros = "C: \Users\agustin.rojas\Desktop\ "; 

            string guardarEnTxt = "Mi alumno: \n";
            Type myType = alumno.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(alumno, null);
                guardarEnTxt = guardarEnTxt + prop.Name + ":" + propValue.ToString() + " ,";
            }
            using (StreamWriter file = new StreamWriter("prueba_io.txt"))
            {
                //mostrar por pantalla
                file.WriteLine(guardarEnTxt.Remove(guardarEnTxt.Length - 1));
            }
            return alumno;
        }
    }
}
