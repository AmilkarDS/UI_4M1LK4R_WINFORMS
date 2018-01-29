using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace UI_4M1LK4R
{
    public partial class LoginUI : MaterialForm
    {
        public LoginUI()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        private void LoginUI_SizeChanged(object sender, EventArgs e)
        {
            panelPrincipal.Height = this.Height - 68;
            panelPrincipal.Width = this.Width - 4;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainUI v = new MainUI();
            this.Hide();
            v.Owner = this;
            v.ShowDialog();
            this.Close();

        }
    }
}
