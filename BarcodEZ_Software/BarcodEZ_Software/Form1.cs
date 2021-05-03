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
using System.Runtime.CompilerServices;
using DemoConsoleScraping;

namespace BarcodEZ_Software
{
    public partial class Form : MaterialForm
    {
        int oldindex = -1;

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
            PanelScelta.Visible = false;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        
        /// <summary>
        /// Analizza i vari frame del video della webcam e prova a rilevare il codeice attraverso ZXing
        /// </summary>
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            ZXing.BarcodeReader reader = new ZXing.BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txLive.Invoke(new MethodInvoker(delegate ()
                {
                    txLive.Text = result?.ToString();
                }));
            }            
            pbLive.Image = bitmap;
        }

        private void btnStartLive_Click(object sender, EventArgs e)
        {
            int newindex = cmbLive.SelectedIndex;

            if (newindex != oldindex)
            {
                videoCaptureDevice?.Stop();
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbLive.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();

                oldindex = cmbLive.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Webcam già in uso");
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }        

        private void btLiveMenù_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = false;
            panelLive.Visible = true;
            panelGallery.Visible = false;
            
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            cmbLive.Items.Clear();

            foreach (FilterInfo device in filterInfoCollection)
            {
                cmbLive.Items.Add(device.Name);
            }

            try
            {
                cmbLive.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Nessuna webcam trovata");
                btreturnLive.PerformClick();
            }
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
            videoCaptureDevice?.Stop();
            txLive.Clear();
            pbLive.Image = null;
            oldindex = -1;
        }

        private void btreturnGallery_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = true;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            txGallery.Clear();
        }

        private void btreturnScelta_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = true;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            PanelScelta.Visible = false;
        }

        private void btGallery_Click(object sender, EventArgs e)
        {
            txGallery.Clear();
            this.OpenGallery= new OpenFileDialog
            {
                InitialDirectory = @"C: \",
                Title = "Sfoglia file di testo",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "*. BMP, *. JPG, *. GIF, *. PNG, *. TIFF, *. JPEG | *. BMP; *. JPG; *. GIF; *. PNG; *. TIFF; *. JPEG",

                FilterIndex = 2, 
                RestoreDirectory = true ,  
  
                ReadOnlyChecked = true ,  
                ShowReadOnly = true
            };

            if (OpenGallery.ShowDialog() == DialogResult.OK)
            {
                pictureGallery.Image = new Bitmap(OpenGallery.FileName);
            }
        }

        private void btnStartGallery_Click(object sender, EventArgs e)
        {
            string risultato=ClasseImmagine.Gallery(pictureGallery);
            if(string.Compare(risultato, String.Empty)==0)
            {
                MessageBox.Show("Inserire un'immagine valida");
                return;
            }
            txGallery.Text = risultato;

        }

        private void btnCercaLive_Click(object sender, EventArgs e)
        {
            AmazonProduct prodottoAmazon = default(AmazonProduct);
            EbayProduct prodottoEbay = default(EbayProduct);
            string HtmlAmazon = string.Empty;
            string HtmlEbay = string.Empty;
            panelMenù.Visible = false;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            PanelScelta.Visible = true;
            string LinkAmazon = ClasseAPI.ReqAsin(txLive.Text);
            string LinkEbay = EbayScraping.ExtractFirstHref(txLive.Text);
            HtmlAmazon = AmazonScraping.GetRequest(LinkAmazon);
            HtmlEbay = EbayScraping.GetRequest(LinkEbay);
            prodottoAmazon = AmazonScraping.DataParse(HtmlAmazon);
            prodottoEbay = EbayScraping.DataParse(HtmlEbay);
            lbAmazonScelta.Text = prodottoAmazon.price.ToString();
            lbEbayScelta.Text = prodottoEbay.price.ToString();
            if (prodottoAmazon.fullprice != -1)
            {
                lbAmazonScontoScelta.Text = $"Il prodotto è scontato:\n {prodottoAmazon.fullprice.ToString()}";
            }
            if (prodottoAmazon.fullprice == -1)
            {
                lbAmazonScontoScelta.Text = $"Il prodotto non è scontato";
            }
            if (prodottoEbay.fullprice != -1)
            {
                lbEbayScontoScelta.Text = $"Il prodotto è scontato:\n {prodottoEbay.fullprice.ToString()}";
            }
            if (prodottoEbay.fullprice == -1)
            {
                lbEbayScontoScelta.Text = $"Il prodotto non è scontato";
            }
        }

        private void btnCercaGallery_Click(object sender, EventArgs e)
        {
            AmazonProduct prodottoAmazon = default(AmazonProduct);
            EbayProduct prodottoEbay = default(EbayProduct);
            string HtmlAmazon = string.Empty;
            string HtmlEbay = string.Empty;
            panelMenù.Visible = false;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            PanelScelta.Visible = true;
            string LinkAmazon = ClasseAPI.ReqAsin(txLive.Text);
            string LinkEbay = EbayScraping.ExtractFirstHref(txLive.Text);
            HtmlAmazon = AmazonScraping.GetRequest(LinkAmazon);
            HtmlEbay = EbayScraping.GetRequest(LinkEbay);
            prodottoAmazon = AmazonScraping.DataParse(HtmlAmazon);
            prodottoEbay = EbayScraping.DataParse(HtmlEbay);
            lbAmazonScelta.Text = prodottoAmazon.price.ToString();
            lbEbayScelta.Text = prodottoEbay.price.ToString();
            if (prodottoAmazon.fullprice != -1)
            {
                lbAmazonScontoScelta.Text = $"Il prodotto è scontato:\n {prodottoAmazon.fullprice.ToString()}";
            }
            if (prodottoAmazon.fullprice == -1)
            {
                lbAmazonScontoScelta.Text = $"Il prodotto non è scontato";
            }
            if (prodottoEbay.fullprice != -1)
            {
                lbEbayScontoScelta.Text = $"Il prodotto è scontato:\n {prodottoEbay.fullprice.ToString()}";
            }
            if (prodottoEbay.fullprice == -1)
            {
                lbEbayScontoScelta.Text = $"Il prodotto non è scontato";
            }
        }

        private void btAmazonScelta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void btEbayScelta_Click(object sender, EventArgs e)
        {

        }
    }
}
