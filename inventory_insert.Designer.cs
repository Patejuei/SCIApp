namespace SCIApp
{
    partial class inventory_insert
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
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.inp_model = new System.Windows.Forms.TextBox();
            this.inp_brand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inp_desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_location = new System.Windows.Forms.ComboBox();
            this.cb_dependency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inp_qty = new System.Windows.Forms.TextBox();
            this.inp_itemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_InsertAll = new System.Windows.Forms.Button();
            this.tbl_ItemList = new System.Windows.Forms.DataGridView();
            this.iCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddItem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.inp_model);
            this.groupBox1.Controls.Add(this.inp_brand);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.inp_desc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_location);
            this.groupBox1.Controls.Add(this.cb_dependency);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inp_qty);
            this.groupBox1.Controls.Add(this.inp_itemCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Ingreso";
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(268, 150);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(189, 29);
            this.btn_AddItem.TabIndex = 1;
            this.btn_AddItem.Text = "Añadir";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Modelo";
            // 
            // inp_model
            // 
            this.inp_model.Location = new System.Drawing.Point(137, 152);
            this.inp_model.Name = "inp_model";
            this.inp_model.Size = new System.Drawing.Size(125, 27);
            this.inp_model.TabIndex = 7;
            // 
            // inp_brand
            // 
            this.inp_brand.Location = new System.Drawing.Point(6, 152);
            this.inp_brand.Name = "inp_brand";
            this.inp_brand.Size = new System.Drawing.Size(125, 27);
            this.inp_brand.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Marca";
            // 
            // inp_desc
            // 
            this.inp_desc.Location = new System.Drawing.Point(6, 99);
            this.inp_desc.Name = "inp_desc";
            this.inp_desc.Size = new System.Drawing.Size(451, 27);
            this.inp_desc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ubicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dependencia";
            // 
            // cb_location
            // 
            this.cb_location.FormattingEnabled = true;
            this.cb_location.Location = new System.Drawing.Point(337, 45);
            this.cb_location.Name = "cb_location";
            this.cb_location.Size = new System.Drawing.Size(120, 28);
            this.cb_location.TabIndex = 4;
            // 
            // cb_dependency
            // 
            this.cb_dependency.FormattingEnabled = true;
            this.cb_dependency.Location = new System.Drawing.Point(211, 45);
            this.cb_dependency.Name = "cb_dependency";
            this.cb_dependency.Size = new System.Drawing.Size(120, 28);
            this.cb_dependency.TabIndex = 3;
            this.cb_dependency.SelectedIndexChanged += new System.EventHandler(this.cb_dependency_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // inp_qty
            // 
            this.inp_qty.Location = new System.Drawing.Point(108, 46);
            this.inp_qty.Name = "inp_qty";
            this.inp_qty.Size = new System.Drawing.Size(97, 27);
            this.inp_qty.TabIndex = 2;
            // 
            // inp_itemCode
            // 
            this.inp_itemCode.Location = new System.Drawing.Point(6, 46);
            this.inp_itemCode.MaxLength = 5;
            this.inp_itemCode.Name = "inp_itemCode";
            this.inp_itemCode.Size = new System.Drawing.Size(96, 27);
            this.inp_itemCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_back);
            this.groupBox2.Controls.Add(this.btn_InsertAll);
            this.groupBox2.Location = new System.Drawing.Point(486, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(6, 61);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(170, 29);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Volver";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_InsertAll
            // 
            this.btn_InsertAll.Location = new System.Drawing.Point(6, 26);
            this.btn_InsertAll.Name = "btn_InsertAll";
            this.btn_InsertAll.Size = new System.Drawing.Size(170, 29);
            this.btn_InsertAll.TabIndex = 0;
            this.btn_InsertAll.Text = "Ingresar Items";
            this.btn_InsertAll.UseVisualStyleBackColor = true;
            this.btn_InsertAll.Click += new System.EventHandler(this.btn_InsertAll_Click);
            // 
            // tbl_ItemList
            // 
            this.tbl_ItemList.AllowUserToAddRows = false;
            this.tbl_ItemList.AllowUserToDeleteRows = false;
            this.tbl_ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_ItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iCode,
            this.iDesc,
            this.iBrand,
            this.iModel,
            this.iQty,
            this.iDep,
            this.iLoc});
            this.tbl_ItemList.Location = new System.Drawing.Point(12, 210);
            this.tbl_ItemList.Name = "tbl_ItemList";
            this.tbl_ItemList.ReadOnly = true;
            this.tbl_ItemList.RowHeadersWidth = 51;
            this.tbl_ItemList.RowTemplate.Height = 29;
            this.tbl_ItemList.Size = new System.Drawing.Size(928, 313);
            this.tbl_ItemList.TabIndex = 3;
            // 
            // iCode
            // 
            this.iCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iCode.HeaderText = "Codigo";
            this.iCode.MinimumWidth = 6;
            this.iCode.Name = "iCode";
            this.iCode.ReadOnly = true;
            this.iCode.Width = 87;
            // 
            // iDesc
            // 
            this.iDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDesc.HeaderText = "Detalle";
            this.iDesc.MinimumWidth = 6;
            this.iDesc.Name = "iDesc";
            this.iDesc.ReadOnly = true;
            this.iDesc.Width = 86;
            // 
            // iBrand
            // 
            this.iBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iBrand.HeaderText = "Marca";
            this.iBrand.MinimumWidth = 6;
            this.iBrand.Name = "iBrand";
            this.iBrand.ReadOnly = true;
            this.iBrand.Width = 79;
            // 
            // iModel
            // 
            this.iModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iModel.HeaderText = "Modelo";
            this.iModel.MinimumWidth = 6;
            this.iModel.Name = "iModel";
            this.iModel.ReadOnly = true;
            this.iModel.Width = 90;
            // 
            // iQty
            // 
            this.iQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iQty.HeaderText = "Cantidad";
            this.iQty.MinimumWidth = 6;
            this.iQty.Name = "iQty";
            this.iQty.ReadOnly = true;
            this.iQty.Width = 98;
            // 
            // iDep
            // 
            this.iDep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDep.HeaderText = "Dependencia";
            this.iDep.MinimumWidth = 6;
            this.iDep.Name = "iDep";
            this.iDep.ReadOnly = true;
            this.iDep.Width = 126;
            // 
            // iLoc
            // 
            this.iLoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iLoc.HeaderText = "Ubicacion";
            this.iLoc.MinimumWidth = 6;
            this.iLoc.Name = "iLoc";
            this.iLoc.ReadOnly = true;
            // 
            // inventory_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 535);
            this.Controls.Add(this.tbl_ItemList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "inventory_insert";
            this.Text = "Insertar Especie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inventory_insert_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_AddItem;
        private Label label7;
        private TextBox inp_model;
        private TextBox inp_brand;
        private Label label6;
        private TextBox inp_desc;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cb_location;
        private ComboBox cb_dependency;
        private Label label2;
        private TextBox inp_qty;
        private TextBox inp_itemCode;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn_InsertAll;
        private DataGridView tbl_ItemList;
        private DataGridViewTextBoxColumn iCode;
        private DataGridViewTextBoxColumn iDesc;
        private DataGridViewTextBoxColumn iBrand;
        private DataGridViewTextBoxColumn iModel;
        private DataGridViewTextBoxColumn iQty;
        private DataGridViewTextBoxColumn iDep;
        private DataGridViewTextBoxColumn iLoc;
        private Button btn_back;
    }
}