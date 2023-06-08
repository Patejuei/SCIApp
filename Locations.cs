using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIApp
{
    internal class Locations
    {
        private static string _Estructure = "N/A";
        private static string[] _B9 = {"Todo", "Cabina", "Contra-Cabina", "Cortina 1", "Cortina 2", "Cortina 3", "Cortina 4", "Techo" };
        public static string[] dependencias = {"Todo", "Sala de Estar", "Comedor", "Baños", "Cocina", "Bodega", "B-9" };

        public static string[] getLocB9()
        {
            return _B9;
        }
        public static string getLocGen()
        {
            return _Estructure;
        }
    }
}
