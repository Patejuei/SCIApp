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
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbl_c1 = new System.Windows.Forms.ColumnHeader();
            this.tbl_c2 = new System.Windows.Forms.ColumnHeader();
            this.tbl_c3 = new System.Windows.Forms.ColumnHeader();
            this.tbl_c4 = new System.Windows.Forms.ColumnHeader();
            this.tbl_c5 = new System.Windows.Forms.ColumnHeader();
            this.tbl_c6 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_InsertItem_Index = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tbl_c1,
            this.tbl_c2,
            this.tbl_c3,
            this.tbl_c4,
            this.tbl_c5,
            this.tbl_c6});
            this.listView1.Location = new System.Drawing.Point(11, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(747, 363);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tbl_c1
            // 
            this.tbl_c1.Text = "Código";
            // 
            // tbl_c2
            // 
            this.tbl_c2.Text = "Descripción";
            // 
            // tbl_c3
            // 
            this.tbl_c3.Text = "Marca";
            // 
            // tbl_c4
            // 
            this.tbl_c4.Text = "Modelo";
            // 
            // tbl_c5
            // 
            this.tbl_c5.Text = "Dependencia";
            // 
            // tbl_c6
            // 
            this.tbl_c6.Text = "Ubicación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(565, 27);
            this.textBox1.TabIndex = 5;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(163, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modificar Especie";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generar Planilla";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_InsertItem_Index);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(597, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(162, 156);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // inventory_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "inventory_index";
            this.Text = "Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Button btn_InsertItem_Index;
        private Button button3;
        private Button button2;
        private ColumnHeader tbl_c1;
        private ColumnHeader tbl_c2;
        private ColumnHeader tbl_c3;
        private ColumnHeader tbl_c4;
        private ColumnHeader tbl_c5;
        private ColumnHeader tbl_c6;
        private GroupBox groupBox2;
    }
}