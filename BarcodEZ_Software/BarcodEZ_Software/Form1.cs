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

            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelMenù.Visible = true;
        }

        private void cmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCamera.Text == "Gallery")
            {
                panelLive.Visible = false;
                panelGallery.Show();
            }
        }

        private void btGallery_Click(object sender, EventArgs e)
        {
            panelLive.Visible = false;
            panelGallery.Visible = true;
            panelMenù.Visible = false;
        }

        private void btReturnGallery_Click(object sender, EventArgs e)
        {
            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelMenù.Visible = true;
        }

        private void btReturnLive_Click(object sender, EventArgs e)
        {
            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelMenù.Visible = true;
        }

        private void btLive_Click(object sender, EventArgs e)
        {
            panelLive.Visible = true;
            panelGallery.Visible = false;
            panelMenù.Visible = false;
        }
    }
}
