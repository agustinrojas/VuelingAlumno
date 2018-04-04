using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using System.Configuration;
using Newtonsoft.Json;
using System.Reflection;
using System.IO;
using Vueling.Common.Logic.FileUtils;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoDAOJson : IAlumnoDAO
    {
        private string path = FileUtils.Path("json");
        private List<Alumno> alumnos = new List<Alumno>();
        public Alumno alumnoDS { get; set; }
        public string Path { get => path; set => path = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }

        public Alumno add(Alumno alumno)
        {
            if (File.Exists(Path))
            {
                using (Stream st = new FileStream(Path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader rd = new StreamReader(st))
                    {
                        string lista = rd.ReadToEnd();
                        Alumnos = JsonConvert.DeserializeObject<List<Alumno>>(lista);
                    }
                }
                using (Stream st = new FileStream(Path, FileMode.Create, FileAccess.Write))
                {

                    using (StreamWriter wrt = new StreamWriter(st))
                    {
                        alumno.ToJson(alumno);
                        Alumnos.Add(alumno);
                        string registro = JsonConvert.SerializeObject(Alumnos);
                        wrt.WriteLine(registro);

                    }
                }
                return DeserializerJson();
            }
            else
            {
                using (Stream st = new FileStream(Path, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter wrt = new StreamWriter(st))
                    {

                        wrt.WriteLine("[" + alumno.ToJson(alumno) + "]");

                    }
                }

                return DeserializerJson();
            }
        }
        private Alumno DeserializerJson()
        {
            using (Stream st = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader rd = new StreamReader(st))
                {
                    string lista = rd.ReadToEnd();
                    Alumnos = JsonConvert.DeserializeObject<List<Alumno>>(lista);
                }
            }
            alumnoDS = Alumnos.Last();
            return alumnoDS;
        }
    }
}
