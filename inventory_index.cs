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
    public partial class inventory_index : Form
    {
        public inventory_index()
        {
            InitializeComponent();
        }

        private void btn_InsertItem_Index_Click(object sender, EventArgs e)
        {
            inventory_insert ins = new inventory_insert();
            ins.ShowDialog();
        }

    }
}
