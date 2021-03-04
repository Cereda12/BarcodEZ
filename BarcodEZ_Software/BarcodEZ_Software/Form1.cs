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

namespace BarcodEZ_Software
{
    public partial class BarcodEZ : MaterialForm
    {
        public BarcodEZ()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green800, Primary.Green800, Accent.LightBlue200, TextShade.WHITE);

            //pGallery.Visible = false;
        }

        private void panelStart_Paint(object sender, PaintEventArgs e)
        {
            if (cmbCamera.Text == "Gallery")
            {
                panelStart.Enabled = false;
                panelGallery.Show();
            }
        }
    }
}
