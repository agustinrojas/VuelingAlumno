using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao;

namespace Vueling.Business.Logic
{
    public class AlumnoBLTxt : IAlumnoBL
    {
        private readonly IAlumnoDAO alumnoDAO = new AlumnoDAOTxt();
        public Alumno add(Alumno alumno)
        {
            alumno.REGISTRO = DateTime.Now;
            alumno.EDAD = AreAge(alumno.NACIMIENTO, alumno.REGISTRO);
            return alumnoDAO.add(alumno);
        }

        public int AreAge(DateTime dateBorn, DateTime dateRegis)
        {
            if (dateBorn.Month > dateRegis.Month)
            {
                return Convert.ToInt32((dateRegis.Year - dateBorn.Year) - 1);
            }
            else
            {
                if (dateBorn.Month == dateRegis.Month && dateBorn.Day > dateRegis.Day)
                {
                    return Convert.ToInt32((dateRegis.Year - dateBorn.Year) - 1);
                }
                return Convert.ToInt32(dateRegis.Year - dateBorn.Year);
            }
        }
    }
}
