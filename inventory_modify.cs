using SCIApp.Models;
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
    public partial class inventory_modify : Form
    {
        Connection con = new Connection();
        Especie item;
        DataGridView indexdg;
        public inventory_modify(string id, DataGridView indexdg)
        {
            InitializeComponent();
            this.indexdg = indexdg;
            item = new Especie(id);
            lbl_itemCode.Text = item.code;
            lbl_ItemDesc.Text = item.detail;
            lbl_itemBrand.Text = item.brand;
            lbl_itemModel.Text = item.model;
            if (item.dependency == "B-9")
            {
                cb_locE.Items.AddRange(Locations.getLocB9());
            }
            else
            {
                cb_locE.Items.Add(Locations.getLocGen());
            }
            cb_locE.Text = item.location;
            cb_depE.Items.AddRange(Locations._dependencias);
            cb_depE.Text = item.dependency;
            tb_qtyE.Text = item.quantity.ToString();
            this.indexdg = indexdg;
        }

        private void cb_depE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_depE.Text == "B-9")
            {
                cb_locE.Items.Clear();
                cb_locE.Items.AddRange(Locations.getLocB9());
            }
            else
            {
                cb_locE.Items.Clear();
                cb_locE.Items.Add(Locations.getLocGen());
            }
        }

        private void btn_saveMod_Click(object sender, EventArgs e)
        {
            item.location = cb_locE.Text;
            item.dependency= cb_depE.Text;
            item.set_quantity(tb_qtyE.Text);
            item.UpdateItem();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            item.DeleteItem();
            this.Close();
        }

        private void inventory_modify_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.getItems(indexdg);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
