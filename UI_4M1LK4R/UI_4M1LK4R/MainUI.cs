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
    public partial class MainUI : MaterialForm
    {
        public MainUI()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Orange900, Primary.Red500, Accent.Teal200, TextShade.WHITE);
            seedListView();
        }

        private void MainUI_SizeChanged(object sender, EventArgs e)
        {
            label1.Text ="Main Size Heigt: "+ this.Size.Height.ToString() + " Width: " + this.Size.Width.ToString();
            label2.Text = "Panel Size Heigt: " + PanelPrincipal.Size.Height.ToString() + " Width: " + PanelPrincipal.Size.Width.ToString();

            PanelPrincipal.Height = this.Height - 68;
            PanelPrincipal.Width = this.Width - 4;
        }
        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{"1", "User1", "Activo", "Administrador"},
                new []{"2", "User2", "Activo", "Administrador"},
                new []{"3", "User3", "Activo", "Estandar"},
                new []{"4", "User4", "Inactivo", "Estandar"},
                new []{"5", "User5", "Inactivo", "Administrador"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView1.Items.Add(item);
            }
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            FormsUI v = new FormsUI();
            v.ShowDialog();
        }
    }
}
