﻿namespace SCIApp
{
    partial class inventory_modify
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_itemCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ItemDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_itemBrand = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_itemModel = new System.Windows.Forms.Label();
            this.cb_locE = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_depE = new System.Windows.Forms.ComboBox();
            this.btn_saveMod = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_qtyE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // lbl_itemCode
            // 
            this.lbl_itemCode.AutoSize = true;
            this.lbl_itemCode.Location = new System.Drawing.Point(105, 9);
            this.lbl_itemCode.Name = "lbl_itemCode";
            this.lbl_itemCode.Size = new System.Drawing.Size(78, 20);
            this.lbl_itemCode.TabIndex = 1;
            this.lbl_itemCode.Text = "<Codigo>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // lbl_ItemDesc
            // 
            this.lbl_ItemDesc.AutoSize = true;
            this.lbl_ItemDesc.Location = new System.Drawing.Point(105, 29);
            this.lbl_ItemDesc.Name = "lbl_ItemDesc";
            this.lbl_ItemDesc.Size = new System.Drawing.Size(107, 20);
            this.lbl_ItemDesc.TabIndex = 1;
            this.lbl_ItemDesc.Text = "<Descripción>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // lbl_itemBrand
            // 
            this.lbl_itemBrand.AutoSize = true;
            this.lbl_itemBrand.Location = new System.Drawing.Point(105, 49);
            this.lbl_itemBrand.Name = "lbl_itemBrand";
            this.lbl_itemBrand.Size = new System.Drawing.Size(70, 20);
            this.lbl_itemBrand.TabIndex = 1;
            this.lbl_itemBrand.Text = "<Marca>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Modelo";
            // 
            // lbl_itemModel
            // 
            this.lbl_itemModel.AutoSize = true;
            this.lbl_itemModel.Location = new System.Drawing.Point(105, 69);
            this.lbl_itemModel.Name = "lbl_itemModel";
            this.lbl_itemModel.Size = new System.Drawing.Size(81, 20);
            this.lbl_itemModel.TabIndex = 1;
            this.lbl_itemModel.Text = "<Modelo>";
            // 
            // cb_locE
            // 
            this.cb_locE.FormattingEnabled = true;
            this.cb_locE.Location = new System.Drawing.Point(12, 142);
            this.cb_locE.Name = "cb_locE";
            this.cb_locE.Size = new System.Drawing.Size(486, 28);
            this.cb_locE.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ubicacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dependencia";
            // 
            // cb_depE
            // 
            this.cb_depE.FormattingEnabled = true;
            this.cb_depE.Location = new System.Drawing.Point(12, 196);
            this.cb_depE.Name = "cb_depE";
            this.cb_depE.Size = new System.Drawing.Size(486, 28);
            this.cb_depE.TabIndex = 7;
            this.cb_depE.SelectedIndexChanged += new System.EventHandler(this.cb_depE_SelectedIndexChanged);
            // 
            // btn_saveMod
            // 
            this.btn_saveMod.Location = new System.Drawing.Point(12, 283);
            this.btn_saveMod.Name = "btn_saveMod";
            this.btn_saveMod.Size = new System.Drawing.Size(376, 29);
            this.btn_saveMod.TabIndex = 8;
            this.btn_saveMod.Text = "Guardar Cambios";
            this.btn_saveMod.UseVisualStyleBackColor = true;
            this.btn_saveMod.Click += new System.EventHandler(this.btn_saveMod_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(394, 283);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 29);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 318);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(486, 29);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad";
            // 
            // tb_qtyE
            // 
            this.tb_qtyE.Location = new System.Drawing.Point(12, 250);
            this.tb_qtyE.Name = "tb_qtyE";
            this.tb_qtyE.Size = new System.Drawing.Size(486, 27);
            this.tb_qtyE.TabIndex = 11;
            // 
            // inventory_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 360);
            this.Controls.Add(this.tb_qtyE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_saveMod);
            this.Controls.Add(this.cb_depE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_locE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_itemModel);
            this.Controls.Add(this.lbl_itemBrand);
            this.Controls.Add(this.lbl_ItemDesc);
            this.Controls.Add(this.lbl_itemCode);
            this.Controls.Add(this.label1);
            this.Name = "inventory_modify";
            this.Text = "Modificar Especie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inventory_modify_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_itemCode;
        private Label label3;
        private Label lbl_ItemDesc;
        private Label label2;
        private Label lbl_itemBrand;
        private Label label5;
        private Label lbl_itemModel;
        private ComboBox cb_locE;
        private Label label4;
        private Label label6;
        private ComboBox cb_depE;
        private Button btn_saveMod;
        private Button btn_delete;
        private Button btn_cancel;
        private Label label7;
        private TextBox tb_qtyE;
    }
}