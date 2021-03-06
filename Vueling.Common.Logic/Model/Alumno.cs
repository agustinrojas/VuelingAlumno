﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.Model

{
    public class Alumno : VuelingObject
    {
        public string ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string DNI { get; set; }
        public int EDAD { get; set; }
        public DateTime NACIMIENTO { get; set; }
        public DateTime REGISTRO { get; set; }
        public string FechaAlta { get; set; }

        public Alumno()
        {
            this.GUID = Guid.NewGuid();
        }

        public Alumno(Guid pGUID, string pId, string pNombre, string pApellidos, string pDNI, int pEDAD)
            {
                this.GUID = pGUID;
                this.ID = pId;
                this.NOMBRE = pNombre;
                this.APELLIDOS = pApellidos;
                this.DNI = pDNI;
                this.EDAD = pEDAD;
            }

        public override string ToString()
        {
            return String.Format($"{ID},{DNI},{NOMBRE},{APELLIDOS},{NACIMIENTO},fecha de registro :{REGISTRO};");
        }
        public override string ToJson(Alumno alumno)
        {
            this.FechaAlta = REGISTRO.ToString();
            return JsonConvert.SerializeObject(alumno);

        }
        public override bool Equals(object obj)
            {
                var alumno = obj as Alumno;
                return alumno != null &&
                       GUID == alumno.GUID &&
                       ID == alumno.ID &&
                       NOMBRE == alumno.NOMBRE &&
                       APELLIDOS == alumno.APELLIDOS &&
                       DNI == alumno.DNI &&
                       NACIMIENTO == alumno.NACIMIENTO &&
                       REGISTRO == alumno.REGISTRO;
            }

            public override int GetHashCode()
            {
                var hashCode = -1910929195;
                hashCode = hashCode * -1521134295 + ID.GetHashCode();
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NOMBRE);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(APELLIDOS);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DNI);
                hashCode = hashCode * -1521134295 + GUID.GetHashCode();
                return hashCode;
            }
    } 
}
