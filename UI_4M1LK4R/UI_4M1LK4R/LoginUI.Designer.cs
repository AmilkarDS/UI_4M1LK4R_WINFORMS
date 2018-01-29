namespace UI_4M1LK4R
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.pictureBox3);
            this.panelPrincipal.Controls.Add(this.btnLogin);
            this.panelPrincipal.Controls.Add(this.pictureBox2);
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Controls.Add(this.txtPass);
            this.panelPrincipal.Controls.Add(this.txtNom);
            this.panelPrincipal.Location = new System.Drawing.Point(2, 66);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3, 200, 3, 4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(596, 432);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.Icon = global::UI_4M1LK4R.Properties.Resources.icons8_Login_96px_1;
            this.btnLogin.Location = new System.Drawing.Point(243, 359);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(114, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "INGRESAR";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Depth = 0;
            this.txtPass.Hint = "Contraseña";
            this.txtPass.Location = new System.Drawing.Point(200, 300);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(200, 23);
            this.txtPass.TabIndex = 2;
            this.txtPass.TabStop = false;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtNom
            // 
            this.txtNom.Depth = 0;
            this.txtNom.Hint = "Usuario";
            this.txtNom.Location = new System.Drawing.Point(200, 241);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.MaxLength = 32767;
            this.txtNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.Size = new System.Drawing.Size(200, 23);
            this.txtNom.TabIndex = 1;
            this.txtNom.TabStop = false;
            this.txtNom.UseSystemPasswordChar = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(240, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI_4M1LK4R.Properties.Resources.icons8_Key_96px_1;
            this.pictureBox2.Location = new System.Drawing.Point(171, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_4M1LK4R.Properties.Resources.icons8_Name_96px_1;
            this.pictureBox1.Location = new System.Drawing.Point(171, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(228, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "INGRESAR AL SISTEMA";
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "LoginUI";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginUI";
            this.SizeChanged += new System.EventHandler(this.LoginUI_SizeChanged);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}