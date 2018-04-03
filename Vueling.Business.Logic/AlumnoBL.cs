using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao;

namespace Vueling.Business.Logic
{
    public class AlumnoBL : IAlumnoBL
    {
        private IAlumnoDAO _alumnoDAO;
        public AlumnoBL()
        {
           
        }
        public Alumno Add(Alumno alumno, int TipoFichero)
        {
            switch (TipoFichero)
            {
                case 1:
                    _alumnoDAO = new AlumnoDAOTxt();
                    _alumnoDAO.add(alumno);
                    break;
                case 2:
                    _alumnoDAO = new AlumnoDAOJson();
                    _alumnoDAO.add(alumno);
                    break;
                case 3:
                    _alumnoDAO = new AlumnoDAOXml();
                    _alumnoDAO.add(alumno);
                    break;
            }


            return alumno;
        }
    }
}
