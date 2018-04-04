using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Vueling.Common.Logic.FileUtils;
using Vueling.Common.Logic.Model;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoDAOXml : IAlumnoDAO
    {
        public string Path = FileUtils.Path("xml");
        public List<Alumno> alumnos = new List<Alumno>();
        public Alumno add(Alumno alumno)
        {
            if (File.Exists(Path))
            {
                XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
                using (StreamReader r = new StreamReader(Path))
                {
                    String xml = r.ReadToEnd();
                    StringReader stringReader = new StringReader(xml);
                    alumnos = (List<Alumno>)xSeriz.Deserialize(stringReader);
                    alumnos.Add(alumno);
                }
                using (FileStream fs1 = new FileStream(Path, FileMode.Open))
                {

                    xSeriz.Serialize(fs1, alumnos);
                }
                return DeserializerXml();
            }
            else
            {
                XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
                using (FileStream fs1 = new FileStream(Path, FileMode.Create))
                {
                    alumno.ToJson(alumno);
                    alumnos.Add(alumno);
                    xSeriz.Serialize(fs1, alumnos);
                }
            }
            return DeserializerXml();
        }
        private Alumno DeserializerXml()
        {
            Alumno alumnoDS;
            XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
            using (StreamReader r = new StreamReader(Path))
            {
                String xml = r.ReadToEnd();
                StringReader stringReader = new StringReader(xml);
                alumnos = (List<Alumno>)xSeriz.Deserialize(stringReader);
            }
            return alumnoDS = alumnos.Last();
        }
    }
}
