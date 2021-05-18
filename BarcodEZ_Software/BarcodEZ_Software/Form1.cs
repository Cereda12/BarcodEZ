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
        List<OggettoCronologia> eleCrono = new List<OggettoCronologia>();
        bool schermata = false;
        int oldindex = -1;

        public Form()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green600, Primary.Green600, Accent.LightBlue200, TextShade.WHITE);
            eleCrono = OggettoCronologia.Deserializza();
            
            panelMenù.Visible = true;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelScelta.Visible = false;
            panelCronologia.Visible = false;
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
            OggettoCronologia.Serializza(eleCrono);
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
            panelCronologia.Visible = false;
        }

        private void btreturnLive_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = true;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelCronologia.Visible = false;
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
            panelCronologia.Visible = false;
            txGallery.Clear();
        }

        private void btreturnScelta_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = true;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelScelta.Visible = false;
            panelCronologia.Visible = false;
        }

        private void btreturnCronologia_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = true;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelScelta.Visible = false;
            panelCronologia.Visible = false;
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
            if(pictureGallery.Image==null)
            {
                MessageBox.Show("Seleziona un'immagine");
                return;
            }
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
            if (string.IsNullOrEmpty(txLive.Text))
            {
                MessageBox.Show("Barcode non rilevato");
                return;
            }
            if (txLive.Text.Length != 8 && txLive.Text.Length != 12 && txLive.Text.Length != 13)
            {
                MessageBox.Show("Formato della stringa errato");
                return;
            }
            schermata = true;
            AmazonProduct prodottoAmazon = default(AmazonProduct);
            EbayProduct prodottoEbay = default(EbayProduct);
            string HtmlAmazon = string.Empty;
            string HtmlEbay = string.Empty;
            panelMenù.Visible = false;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelScelta.Visible = true;            
            string LinkAmazon = ClasseAPI.ReqAsin(txLive.Text);
            string LinkEbay = EbayScraping.ExtractFirstHref(txLive.Text);
            if (LinkAmazon != null && LinkEbay != null)
            {
                HtmlAmazon = AmazonScraping.GetRequest(LinkAmazon);
                HtmlEbay = EbayScraping.GetRequest(LinkEbay);
                prodottoAmazon = AmazonScraping.DataParse(HtmlAmazon);
                prodottoEbay = EbayScraping.DataParse(HtmlEbay);
                lbPrezzoAmazonScelta.Text = prodottoAmazon.price.ToString();
                lbPrezzoEbayScelta.Text = prodottoEbay.price.ToString();
                eleCrono.Add(new OggettoCronologia(txLive.Text, DateTime.Now));
                if (prodottoAmazon.fullprice != -1)
                {
                    lbPrezzoNoScontoAmazonScelta.Text = prodottoAmazon.fullprice.ToString();
                    lbPrezzoNoScontoAmazonScelta.Visible = true;
                }
                if (prodottoAmazon.fullprice == -1)
                {
                    lbPrezzoNoScontoAmazonScelta.Text = "0";
                    lbPrezzoNoScontoAmazonScelta.Visible = false;
                }
                if (prodottoEbay.fullprice != -1)
                {
                    lbPrezzoNoScontoEbayScelta.Text = prodottoEbay.fullprice.ToString();
                    lbPrezzoNoScontoEbayScelta.Visible = true;
                }
                if (prodottoEbay.fullprice == -1)
                {
                    lbPrezzoNoScontoEbayScelta.Text = "0";
                    lbPrezzoNoScontoEbayScelta.Visible = false;
                }
            }                
        }

        private void btnCercaGallery_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txGallery.Text))
            {
                MessageBox.Show("Barcode non rilevato");
                return;
            }
            if (txGallery.Text.Length != 8 && txGallery.Text.Length != 12 && txGallery.Text.Length != 13)
            {
                MessageBox.Show("Formato della stringa errato");
                return;
            }
            schermata = false;
            AmazonProduct prodottoAmazon = default(AmazonProduct);
            EbayProduct prodottoEbay = default(EbayProduct);
            string HtmlAmazon = string.Empty;
            string HtmlEbay = string.Empty;
            panelMenù.Visible = false;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelScelta.Visible = true;
            string LinkAmazon = ClasseAPI.ReqAsin(txGallery.Text);
            string LinkEbay = EbayScraping.ExtractFirstHref(txGallery.Text);
            if(LinkAmazon!=null && LinkEbay != null)
            {
                HtmlAmazon = AmazonScraping.GetRequest(LinkAmazon);
                HtmlEbay = EbayScraping.GetRequest(LinkEbay);
                prodottoAmazon = AmazonScraping.DataParse(HtmlAmazon);
                prodottoEbay = EbayScraping.DataParse(HtmlEbay);
                lbPrezzoAmazonScelta.Text = prodottoAmazon.price.ToString();
                lbPrezzoEbayScelta.Text = prodottoEbay.price.ToString();
                eleCrono.Add(new OggettoCronologia(txGallery.Text, DateTime.Now));
                if (prodottoAmazon.fullprice != -1)
                {
                    lbPrezzoNoScontoAmazonScelta.Text = prodottoAmazon.fullprice.ToString();
                    lbPrezzoNoScontoAmazonScelta.Visible = true;
                }
                if (prodottoAmazon.fullprice == -1)
                {
                    lbPrezzoNoScontoAmazonScelta.Text = "0";
                    lbPrezzoNoScontoAmazonScelta.Visible = false;
                }
                if (prodottoEbay.fullprice != -1)
                {
                    lbPrezzoNoScontoEbayScelta.Text = prodottoEbay.fullprice.ToString();
                    lbPrezzoNoScontoEbayScelta.Visible = true;
                }
                if (prodottoEbay.fullprice == -1)
                {
                    lbPrezzoNoScontoEbayScelta.Text = "0";
                    lbPrezzoNoScontoEbayScelta.Visible = false;
                }
            }            
            //txGallery.Clear();
            pictureGallery.Image = null;
        }

        private void btAmazonScelta_Click(object sender, EventArgs e)
        {
            string LinkAmazon = string.Empty;

            if (schermata)
            {
                LinkAmazon = ClasseAPI.ReqAsin(txLive.Text);
            }
            if(!schermata)
            {
                LinkAmazon = ClasseAPI.ReqAsin(txGallery.Text);
            }   
            
            if(string.IsNullOrEmpty(LinkAmazon))
            {
                MessageBox.Show("Link non trovato");
                return;
            }

            System.Diagnostics.Process.Start(LinkAmazon);            
        }

        private void btEbayScelta_Click(object sender, EventArgs e)
        {
            string LinkEbay = string.Empty;

            if (schermata)
            {
                LinkEbay = EbayScraping.ExtractFirstHref(txLive.Text);
            }
            if (!schermata)
            {
                LinkEbay = EbayScraping.ExtractFirstHref(txGallery.Text);
            }

            if (string.IsNullOrEmpty(LinkEbay))
            {
                MessageBox.Show("Link non trovato");
                return;
            }

            System.Diagnostics.Process.Start(LinkEbay);
        }

        private void lbCronologia_Click(object sender, EventArgs e)
        {
            panelMenù.Visible = false;
            panelLive.Visible = false;
            panelGallery.Visible = false;
            panelScelta.Visible = false;
            panelCronologia.Visible = true;

            if (eleCrono.Count == 0) 
            {
                MessageBox.Show("Nessun elemento presente in cronologia ");
                panelMenù.Visible = true;
                panelLive.Visible = false;
                panelGallery.Visible = false;
                panelScelta.Visible = false;
                panelCronologia.Visible = false;
                return;
            }

            GridCronologia.DataSource = eleCrono.ToList();
        }

        private void GridCronologia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OggettoCronologia item = eleCrono.Where(p => string.Compare(GridCronologia.SelectedRows[0].Cells[0].Value.ToString(), p.Ean) == 0).FirstOrDefault();
            eleCrono.Remove(item);
            GridCronologia.DataSource = eleCrono.ToList();
        }

        private void btCronologia_Click(object sender, EventArgs e)
        {
            if (eleCrono.Count == 0)
            {
                MessageBox.Show("Nessun elemento presente in cronologia ");
                panelMenù.Visible = true;
                panelLive.Visible = false;
                panelGallery.Visible = false;
                panelScelta.Visible = false;
                panelCronologia.Visible = false;
                return;
            }

            eleCrono.Clear();
            GridCronologia.DataSource = eleCrono.ToList();        
        }
    }
}
