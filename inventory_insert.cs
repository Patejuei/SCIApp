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

namespace SCIApp
{
    public partial class inventory_insert : Form
    {
        Connection con = new Connection();
        Especie[] items = new Especie[0];
        DataGridView indexdg;
        public inventory_insert(DataGridView dg)
        {
            InitializeComponent();
            cb_dependency.Items.AddRange(Locations._dependencias);
            indexdg= dg;

        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            Array.Resize(ref items, items.Length + 1);

            int _lastItem = items.Length - 1;
            items[_lastItem] = new Especie(inp_itemCode.Text, inp_desc.Text, inp_qty.Text, cb_location.Text, cb_dependency.Text);
            if(inp_brand.Text != "")
            {
                items[_lastItem].brand = inp_brand.Text;
            }
            if(inp_model.Text != "")
            {
                items[_lastItem].model = inp_model.Text;
            }

            tbl_ItemList.Rows.Add(items[_lastItem].getParams());

            clear_texboxes();
        }

        private void cb_dependency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_dependency.Text == "B-9")
            {
                cb_location.Items.Clear();
                cb_location.Items.AddRange(Locations.getLocB9());
            }
            else
            {
                cb_location.Items.Clear();
                cb_location.Items.Add(Locations.getLocGen().ToString());
            }
        }

        private void clear_texboxes()
        {
            inp_itemCode.Clear();
            inp_desc.Clear();
            inp_brand.Clear();
            inp_model.Clear();
            inp_qty.Clear();
        }

        private void btn_InsertAll_Click(object sender, EventArgs e)
        {
            foreach (Especie item in items)
            {
                item.InsertItem();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            con.getItems(indexdg);
            this.Close();
        }

        private void inventory_insert_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.getItems(indexdg);
        }
    }
}
