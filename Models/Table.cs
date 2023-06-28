using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DocumentFormat.OpenXml.Spreadsheet;

namespace SCIApp.Models
{
    internal class Table : DataTable
    {
        public Table()
        {
            //Columnas
            Columns.Add("Codigo", typeof(string));
            Columns.Add("Detalle", typeof(string));
            Columns.Add("Marca", typeof(string));
            Columns.Add("Modelo", typeof(string));
            Columns.Add("Cantidad", typeof(int));
            Columns.Add("Ubicación", typeof(string));
            Columns.Add("Dependencia", typeof(string));
        }

        public void insertRows(params object[] items)
        {
            foreach (object[] item in items)
            {
                Rows.Add(item);
            }
        }


    }
}
