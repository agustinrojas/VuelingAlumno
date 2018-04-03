using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Vueling.Common.Logic.Model;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoDAOXml : IAlumnoDAO
    {
        public Alumno add(Alumno alumno)
        {
            string guardarEnXml = "Mi alumno: \n";
            Type myType = alumno.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(alumno, null);
                guardarEnXml = guardarEnXml + prop.Name + ":" + propValue.ToString() + " ,";
                XmlTextWriter writer;
                writer = new XmlTextWriter("prueba_XML.xml", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement(guardarEnXml);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            return alumno;
            
        }
    }
}
