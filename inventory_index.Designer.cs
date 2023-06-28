namespace SCIApp
{
    partial class inventory_index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_busqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_UbiSrc = new System.Windows.Forms.ComboBox();
            this.cb_DepSrc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_InsertItem_Index = new System.Windows.Forms.Button();
            this.btn_editItem = new System.Windows.Forms.Button();
            this.btn_genPlanilla = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_viewMoves = new System.Windows.Forms.Button();
            this.tbl_items = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_items)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_busqueda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_UbiSrc);
            this.groupBox1.Controls.Add(this.cb_DepSrc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // tb_busqueda
            // 
            this.tb_busqueda.Location = new System.Drawing.Point(6, 100);
            this.tb_busqueda.Name = "tb_busqueda";
            this.tb_busqueda.Size = new System.Drawing.Size(581, 27);
            this.tb_busqueda.TabIndex = 5;
            this.tb_busqueda.TextChanged += new System.EventHandler(this.tb_busqueda_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ubicación";
            // 
            // cb_UbiSrc
            // 
            this.cb_UbiSrc.FormattingEnabled = true;
            this.cb_UbiSrc.Location = new System.Drawing.Point(163, 45);
            this.cb_UbiSrc.Name = "cb_UbiSrc";
            this.cb_UbiSrc.Size = new System.Drawing.Size(151, 28);
            this.cb_UbiSrc.TabIndex = 2;
            this.cb_UbiSrc.SelectedIndexChanged += new System.EventHandler(this.cb_UbiSrc_SelectedIndexChanged);
            // 
            // cb_DepSrc
            // 
            this.cb_DepSrc.FormattingEnabled = true;
            this.cb_DepSrc.Location = new System.Drawing.Point(6, 45);
            this.cb_DepSrc.Name = "cb_DepSrc";
            this.cb_DepSrc.Size = new System.Drawing.Size(151, 28);
            this.cb_DepSrc.TabIndex = 1;
            this.cb_DepSrc.SelectedIndexChanged += new System.EventHandler(this.cb_DepSrc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dependencia";
            // 
            // btn_InsertItem_Index
            // 
            this.btn_InsertItem_Index.Location = new System.Drawing.Point(7, 28);
            this.btn_InsertItem_Index.Name = "btn_InsertItem_Index";
            this.btn_InsertItem_Index.Size = new System.Drawing.Size(147, 29);
            this.btn_InsertItem_Index.TabIndex = 3;
            this.btn_InsertItem_Index.Text = "Ingresar Especie";
            this.btn_InsertItem_Index.UseVisualStyleBackColor = true;
            this.btn_InsertItem_Index.Click += new System.EventHandler(this.btn_InsertItem_Index_Click);
            // 
            // btn_editItem
            // 
            this.btn_editItem.Enabled = false;
            this.btn_editItem.Location = new System.Drawing.Point(7, 63);
            this.btn_editItem.Name = "btn_editItem";
            this.btn_editItem.Size = new System.Drawing.Size(147, 29);
            this.btn_editItem.TabIndex = 3;
            this.btn_editItem.Text = "Modificar Especie";
            this.btn_editItem.UseVisualStyleBackColor = true;
            this.btn_editItem.Click += new System.EventHandler(this.btn_editItem_Click);
            // 
            // btn_genPlanilla
            // 
            this.btn_genPlanilla.Location = new System.Drawing.Point(6, 133);
            this.btn_genPlanilla.Name = "btn_genPlanilla";
            this.btn_genPlanilla.Size = new System.Drawing.Size(147, 29);
            this.btn_genPlanilla.TabIndex = 3;
            this.btn_genPlanilla.Text = "Generar Planilla";
            this.btn_genPlanilla.UseVisualStyleBackColor = true;
            this.btn_genPlanilla.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_InsertItem_Index);
            this.groupBox2.Controls.Add(this.btn_viewMoves);
            this.groupBox2.Controls.Add(this.btn_genPlanilla);
            this.groupBox2.Controls.Add(this.btn_editItem);
            this.groupBox2.Location = new System.Drawing.Point(610, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(162, 180);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btn_viewMoves
            // 
            this.btn_viewMoves.Enabled = false;
            this.btn_viewMoves.Location = new System.Drawing.Point(6, 98);
            this.btn_viewMoves.Name = "btn_viewMoves";
            this.btn_viewMoves.Size = new System.Drawing.Size(147, 29);
            this.btn_viewMoves.TabIndex = 3;
            this.btn_viewMoves.Text = "Ver Movimientos";
            this.btn_viewMoves.UseVisualStyleBackColor = true;
            this.btn_viewMoves.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbl_items
            // 
            this.tbl_items.AllowUserToAddRows = false;
            this.tbl_items.AllowUserToDeleteRows = false;
            this.tbl_items.AllowUserToOrderColumns = true;
            this.tbl_items.AllowUserToResizeColumns = false;
            this.tbl_items.AllowUserToResizeRows = false;
            this.tbl_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_items.Location = new System.Drawing.Point(11, 198);
            this.tbl_items.Name = "tbl_items";
            this.tbl_items.ReadOnly = true;
            this.tbl_items.RowHeadersVisible = false;
            this.tbl_items.RowHeadersWidth = 51;
            this.tbl_items.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbl_items.RowTemplate.Height = 29;
            this.tbl_items.RowTemplate.ReadOnly = true;
            this.tbl_items.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_items.ShowEditingIcon = false;
            this.tbl_items.Size = new System.Drawing.Size(761, 375);
            this.tbl_items.TabIndex = 5;
            this.tbl_items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_items_CellClick);
            // 
            // inventory_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 585);
            this.Controls.Add(this.tbl_items);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "inventory_index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cb_UbiSrc;
        private ComboBox cb_DepSrc;
        private Label label1;
        private TextBox tb_busqueda;
        private Label label3;
        private Button btn_InsertItem_Index;
        private Button btn_editItem;
        private Button btn_genPlanilla;
        private GroupBox groupBox2;
        private DataGridView tbl_items;
        private Button btn_viewMoves;
    }
}