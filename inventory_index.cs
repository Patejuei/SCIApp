using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIApp.Models;
using SpreadsheetLight;

namespace SCIApp
{
    public partial class inventory_index : Form
    {
        string item_code = "";
        Connection connection;
        public inventory_index()
        {
            InitializeComponent();
            connection= new Connection();
            connection.getItems(tbl_items);
            cb_DepSrc.Items.Add("Todo");
            cb_DepSrc.Items.AddRange(Locations._dependencias);
        }

        private void btn_InsertItem_Index_Click(object sender, EventArgs e)
        {
            inventory_insert ins = new inventory_insert(tbl_items);
            ins.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abre la ventana para elegir la ruta de guardado.
            SaveFileDialog _pathFile = new SaveFileDialog();
            _pathFile.Title = "Guardar Planilla";
            _pathFile.Filter = "Planilla Excel (*.xls)|*.xls|Todos los Archivos (*.*)|*.*";
            _pathFile.FileName = "Inventario Fecha " + DateTime.Now.ToString();
            _pathFile.ShowDialog();

            //Genera la planilla para guardarla
            SLDocument Documento = new SLDocument();

            Table tabla= new Table();


        }

        private void tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            connection.getItemsBySearch(tbl_items, cb_DepSrc.Text, cb_UbiSrc.Text, tb_busqueda.Text);
        }

        private void cb_DepSrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_DepSrc.Text == "B-9")
            {
                cb_UbiSrc.Items.Clear();
                cb_UbiSrc.Items.Add("Todo");
                cb_UbiSrc.Items.AddRange(Locations.getLocB9());
            }
            else
            {
                cb_UbiSrc.Items.Clear();
                cb_UbiSrc.Items.Add("Todo");
                cb_UbiSrc.Items.Add(Locations.getLocGen().ToString());
            }
            connection.getItemsBySearch(tbl_items, cb_DepSrc.Text, cb_UbiSrc.Text,tb_busqueda.Text);
        }

        private void cb_UbiSrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.getItemsBySearch(tbl_items, cb_DepSrc.Text, cb_UbiSrc.Text, tb_busqueda.Text);
        }

        private void tbl_items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editItem.Enabled = true;
            btn_viewMoves.Enabled = true;
            if (tbl_items.Rows[e.RowIndex].Cells[0].Value != null)
            {
                item_code = tbl_items.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btn_editItem_Click(object sender, EventArgs e)
        {
            inventory_modify win = new inventory_modify(item_code, tbl_items);
            win.ShowDialog();
        }
    }
}
