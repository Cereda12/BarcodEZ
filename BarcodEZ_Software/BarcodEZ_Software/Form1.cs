using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Timers;

namespace BarcodEZ_Software
{
    public partial class Form : MaterialForm
    { 
        public Form()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green600, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);

            panelMenù.Visible = true;
            panelLive.Visible = false;
            panelGallery.Visible = false;
        }                

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void Form_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cmbLive.Items.Add(device.Name);
            }
            cmbLive.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Analizza i vari frame del video della webcam e prova a rilevare il codeice attraverso ZXing
        /// </summary>
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txLive.Invoke(new MethodInvoker(delegate ()
                {
                    txLive.Text = result.ToString();
                }));
            }
            pbLive.Image = bitmap;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void btnStartLive_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbLive.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void btLiveMenù_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = false;
            panelLive.Visible = true;
            panelGallery.Visible = false;
        }

        private void btGalleryMenù_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = false;
            panelLive.Visible = false;
            panelGallery.Visible = true;
        }

        private void btreturnLive_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = true;
            panelLive.Visible = false;
            panelGallery.Visible = false;
        }

        private void btreturnGallery_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = true;
            panelLive.Visible = false;
            panelGallery.Visible = false;
        }
    }
}
