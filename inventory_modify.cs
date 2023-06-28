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
        public inventory_modify(string id)
        {
            InitializeComponent();
            Especie item = new Especie(id);
            lbl_itemCode.Text = item.code;
            lbl_ItemDesc.Text = item.detail;
            lbl_itemBrand.Text = item.brand;
            lbl_itemModel.Text = item.model;
        }

    }
}
