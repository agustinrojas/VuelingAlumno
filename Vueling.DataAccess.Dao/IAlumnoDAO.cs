using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Model;

namespace Vueling.DataAccess.Dao
{
    interface IAlumnoDAO
    {
        //Metodo Add, tiene que devolver objeto alumno
        Alumno add(Alumno alumno);

    }
}
