using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.FileUtils
{
    public static class FileUtils
    {
        public static string Path(string Format)
        {
            return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Registro." + Format);
        }
    }
}
