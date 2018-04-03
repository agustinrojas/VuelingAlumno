using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using System.Configuration;
using Newtonsoft.Json;
using System.Reflection;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoDAOJson : IAlumnoDAO
    {
        public Alumno add(Alumno alumno)
        {
            string guardarEnJson = "Mi alumno: \n";
            Type myType = alumno.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(alumno, null);
                guardarEnJson = guardarEnJson + prop.Name + ":" + propValue.ToString() + " ,";
            }

            //caso JSON, hemos agregado a referencias el System.Configuration, y el framework .NET JSON 4.0
            //crear el documento en JSON
            string json = JsonConvert.SerializeObject(alumno);

            //write string to file
            System.IO.File.WriteAllText("prueba_JSON.txt", json);
            return alumno;
        }
    }
}
