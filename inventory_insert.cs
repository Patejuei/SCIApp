using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCIApp
{
    public partial class inventory_insert : Form
    {
        Especie[] items = new Especie[1];
        string[] dependencias = { "Sala de Estar", "Comedor", "Baños", "Cocina", "Bodega", "B-9"};
        public inventory_insert()
        {
            InitializeComponent();
            cb_dependency.Items.AddRange(dependencias);

        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            int _lastItem = items.Length - 1;
            items[_lastItem] = new Especie(inp_itemCode.Text, inp_desc.Text, int.Parse(inp_qty.Text), cb_location.Text, cb_dependency.Text);
            if(inp_brand.Text != "")
            {
                items[_lastItem].brand = inp_brand.Text;
            }
            if(inp_model.Text != "")
            {
                items[_lastItem].model = inp_model.Text;
            }
            Array.Resize(ref items, items.Length + 1);
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
    }
}
