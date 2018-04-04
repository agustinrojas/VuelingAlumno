using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using Vueling.Common.Logic.FileUtils;

namespace Vueling.DataAccess.Dao
{
    public class AlumnoDAOTxt : IAlumnoDAO
    {
        public string Path = FileUtils.Path("txt");
        public Alumno add(Alumno alumno)
        {

            if (File.Exists(Path))
            {
                using (FileStream str = new FileStream(Path, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(str))
                    {
                        sw.WriteLine(alumno.ToString());

                    }
                }
                return DeserializerTxt(alumno.GUID);
            }
            else
            {
                using (FileStream str = new FileStream(Path, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(str))
                    {
                        sw.WriteLine(alumno.ToString());

                    }
                }
                return DeserializerTxt(alumno.GUID);
            }
        }
        private Alumno DeserializerTxt(Guid guid)
        {
            Alumno alumnoDS;
            using (FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string[] props = new string[6];
                    string linea = "";
                    while ((linea = sr.ReadLine()) != null)
                    {
                        props = linea.Split(',');
                    }


                    alumnoDS = new Alumno(guid, (props[0]), props[1], props[2], props[3], Convert.ToInt32(props[4]));
                    return alumnoDS;
                }

            }
        }
    }
}
