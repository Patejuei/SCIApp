using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DocumentFormat.OpenXml.Spreadsheet;

namespace SCIApp
{
    internal class Table : DataTable
    {
        public Table()
        {
            //Columnas
            this.Columns.Add("Codigo", typeof(string));
            this.Columns.Add("Detalle", typeof(string));
            this.Columns.Add("Marca", typeof(string));
            this.Columns.Add("Modelo", typeof(string));
            this.Columns.Add("Cantidad", typeof(int));
            this.Columns.Add("Ubicación", typeof(string));
            this.Columns.Add("Dependencia", typeof(string));
        }

        public void insertRows(params object[] items)
        {
            foreach (object[] item in items)
            {
                this.Rows.Add(item);
            }
        }


    }
}
