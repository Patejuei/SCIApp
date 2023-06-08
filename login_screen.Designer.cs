namespace SCIApp
{
    partial class login_screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inp_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inp_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario";
            // 
            // inp_user
            // 
            this.inp_user.Location = new System.Drawing.Point(11, 32);
            this.inp_user.MaxLength = 50;
            this.inp_user.Name = "inp_user";
            this.inp_user.Size = new System.Drawing.Size(231, 27);
            this.inp_user.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // inp_pass
            // 
            this.inp_pass.Location = new System.Drawing.Point(11, 88);
            this.inp_pass.MaxLength = 16;
            this.inp_pass.Name = "inp_pass";
            this.inp_pass.PasswordChar = '*';
            this.inp_pass.Size = new System.Drawing.Size(231, 27);
            this.inp_pass.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(11, 124);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(231, 29);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Ingresar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 169);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.inp_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inp_user);
            this.Controls.Add(this.label1);
            this.Name = "login_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inp_user;
        private Label label2;
        private TextBox inp_pass;
        private Button btn_login;
    }
}