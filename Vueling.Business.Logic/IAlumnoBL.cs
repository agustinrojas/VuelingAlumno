﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;

namespace Vueling.Business.Logic
{
    public interface IAlumnoBL
    {
        //Metodo Add, tiene que devolver objeto alumno
        Alumno add(Alumno alumno);
        int AreAge(DateTime dateBorn, DateTime dateRegis);
    }
}
