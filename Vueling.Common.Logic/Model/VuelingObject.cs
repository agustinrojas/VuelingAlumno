using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.Model
{
    public abstract class VuelingObject
    {
        public Guid GUID { get; set; }
        public virtual string ToString()
        {
            return "txt";
        }
        public virtual string ToJson(Alumno alumno)
        {
            return string.Format($"[{{Guid : {GUID}}}]");
        }
        public virtual string ToXml(Alumno alumno)
        {
            return "xml";
        }

    }
}
