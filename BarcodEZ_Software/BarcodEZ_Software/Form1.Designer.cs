
namespace BarcodEZ_Software
{
    partial class Form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLive = new System.Windows.Forms.Panel();
            this.btnCercaLive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btreturnLive = new System.Windows.Forms.Button();
            this.pbLive = new System.Windows.Forms.PictureBox();
            this.btnStartLive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbLive = new System.Windows.Forms.ComboBox();
            this.lbCameraLive = new System.Windows.Forms.Label();
            this.lbBarcodeLive = new System.Windows.Forms.Label();
            this.txLive = new System.Windows.Forms.TextBox();
            this.panelGallery = new System.Windows.Forms.Panel();
            this.btnCercaGallery = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btGallery = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btreturnGallery = new System.Windows.Forms.Button();
            this.pictureGallery = new System.Windows.Forms.PictureBox();
            this.btnStartGallery = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txGallery = new System.Windows.Forms.TextBox();
            this.panelMenù = new System.Windows.Forms.Panel();
            this.lbTitoloMenù = new System.Windows.Forms.Label();
            this.btLiveMenù = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btGalleryMenù = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbMenù = new System.Windows.Forms.Label();
            this.PanelScelta = new System.Windows.Forms.Panel();
            this.btEbayScelta = new System.Windows.Forms.Button();
            this.btAmazonScelta = new System.Windows.Forms.Button();
            this.lbAmazonScontoScelta = new System.Windows.Forms.Label();
            this.lbEbayScontoScelta = new System.Windows.Forms.Label();
            this.btreturnScelta = new System.Windows.Forms.Button();
            this.lbPrezzoEbayScelta = new System.Windows.Forms.Label();
            this.lbPrezzoAmazonScelta = new System.Windows.Forms.Label();
            this.lbEbayScelta = new System.Windows.Forms.Label();
            this.lbAmazonScelta = new System.Windows.Forms.Label();
            this.OpenGallery = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).BeginInit();
            this.panelGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGallery)).BeginInit();
            this.panelMenù.SuspendLayout();
            this.PanelScelta.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelLive);
            this.flowLayoutPanel1.Controls.Add(this.panelGallery);
            this.flowLayoutPanel1.Controls.Add(this.panelMenù);
            this.flowLayoutPanel1.Controls.Add(this.PanelScelta);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 72);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(745, 676);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelLive
            // 
            this.panelLive.Controls.Add(this.btnCercaLive);
            this.panelLive.Controls.Add(this.btreturnLive);
            this.panelLive.Controls.Add(this.pbLive);
            this.panelLive.Controls.Add(this.btnStartLive);
            this.panelLive.Controls.Add(this.cmbLive);
            this.panelLive.Controls.Add(this.lbCameraLive);
            this.panelLive.Controls.Add(this.lbBarcodeLive);
            this.panelLive.Controls.Add(this.txLive);
            this.panelLive.Location = new System.Drawing.Point(2, 2);
            this.panelLive.Margin = new System.Windows.Forms.Padding(2);
            this.panelLive.Name = "panelLive";
            this.panelLive.Size = new System.Drawing.Size(371, 336);
            this.panelLive.TabIndex = 2;
            // 
            // btnCercaLive
            // 
            this.btnCercaLive.Depth = 0;
            this.btnCercaLive.Location = new System.Drawing.Point(264, 289);
            this.btnCercaLive.Margin = new System.Windows.Forms.Padding(2);
            this.btnCercaLive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCercaLive.Name = "btnCercaLive";
            this.btnCercaLive.Primary = true;
            this.btnCercaLive.Size = new System.Drawing.Size(72, 21);
            this.btnCercaLive.TabIndex = 8;
            this.btnCercaLive.Text = "RICERCA";
            this.btnCercaLive.UseVisualStyleBackColor = true;
            this.btnCercaLive.Click += new System.EventHandler(this.btnCercaLive_Click);
            // 
            // btreturnLive
            // 
            this.btreturnLive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnLive.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.mezza_bandiera1;
            this.btreturnLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btreturnLive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnLive.FlatAppearance.BorderSize = 0;
            this.btreturnLive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreturnLive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnLive.Location = new System.Drawing.Point(-2, -2);
            this.btreturnLive.Margin = new System.Windows.Forms.Padding(2);
            this.btreturnLive.Name = "btreturnLive";
            this.btreturnLive.Size = new System.Drawing.Size(37, 25);
            this.btreturnLive.TabIndex = 7;
            this.btreturnLive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnLive.UseVisualStyleBackColor = false;
            this.btreturnLive.Click += new System.EventHandler(this.btreturnLive_Click);
            // 
            // pbLive
            // 
            this.pbLive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLive.Location = new System.Drawing.Point(36, 55);
            this.pbLive.Margin = new System.Windows.Forms.Padding(2);
            this.pbLive.Name = "pbLive";
            this.pbLive.Size = new System.Drawing.Size(300, 220);
            this.pbLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLive.TabIndex = 6;
            this.pbLive.TabStop = false;
            // 
            // btnStartLive
            // 
            this.btnStartLive.Depth = 0;
            this.btnStartLive.Location = new System.Drawing.Point(264, 23);
            this.btnStartLive.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartLive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartLive.Name = "btnStartLive";
            this.btnStartLive.Primary = true;
            this.btnStartLive.Size = new System.Drawing.Size(72, 21);
            this.btnStartLive.TabIndex = 5;
            this.btnStartLive.Text = "AVVIA";
            this.btnStartLive.UseVisualStyleBackColor = true;
            this.btnStartLive.Click += new System.EventHandler(this.btnStartLive_Click);
            // 
            // cmbLive
            // 
            this.cmbLive.FormattingEnabled = true;
            this.cmbLive.Location = new System.Drawing.Point(107, 23);
            this.cmbLive.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLive.Name = "cmbLive";
            this.cmbLive.Size = new System.Drawing.Size(139, 21);
            this.cmbLive.TabIndex = 4;
            // 
            // lbCameraLive
            // 
            this.lbCameraLive.AutoSize = true;
            this.lbCameraLive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCameraLive.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCameraLive.Location = new System.Drawing.Point(34, 28);
            this.lbCameraLive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCameraLive.Name = "lbCameraLive";
            this.lbCameraLive.Size = new System.Drawing.Size(52, 12);
            this.lbCameraLive.TabIndex = 3;
            this.lbCameraLive.Text = "Camera:";
            // 
            // lbBarcodeLive
            // 
            this.lbBarcodeLive.AutoSize = true;
            this.lbBarcodeLive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcodeLive.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBarcodeLive.Location = new System.Drawing.Point(39, 293);
            this.lbBarcodeLive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBarcodeLive.Name = "lbBarcodeLive";
            this.lbBarcodeLive.Size = new System.Drawing.Size(56, 12);
            this.lbBarcodeLive.TabIndex = 2;
            this.lbBarcodeLive.Text = "Barcode:";
            // 
            // txLive
            // 
            this.txLive.Location = new System.Drawing.Point(107, 290);
            this.txLive.Margin = new System.Windows.Forms.Padding(2);
            this.txLive.Name = "txLive";
            this.txLive.Size = new System.Drawing.Size(139, 20);
            this.txLive.TabIndex = 1;
            // 
            // panelGallery
            // 
            this.panelGallery.Controls.Add(this.button1);
            this.panelGallery.Controls.Add(this.btnCercaGallery);
            this.panelGallery.Controls.Add(this.btGallery);
            this.panelGallery.Controls.Add(this.btreturnGallery);
            this.panelGallery.Controls.Add(this.pictureGallery);
            this.panelGallery.Controls.Add(this.btnStartGallery);
            this.panelGallery.Controls.Add(this.txGallery);
            this.panelGallery.Location = new System.Drawing.Point(377, 2);
            this.panelGallery.Margin = new System.Windows.Forms.Padding(2);
            this.panelGallery.Name = "panelGallery";
            this.panelGallery.Size = new System.Drawing.Size(352, 336);
            this.panelGallery.TabIndex = 3;
            // 
            // btnCercaGallery
            // 
            this.btnCercaGallery.Depth = 0;
            this.btnCercaGallery.Location = new System.Drawing.Point(259, 289);
            this.btnCercaGallery.Margin = new System.Windows.Forms.Padding(2);
            this.btnCercaGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCercaGallery.Name = "btnCercaGallery";
            this.btnCercaGallery.Primary = true;
            this.btnCercaGallery.Size = new System.Drawing.Size(69, 20);
            this.btnCercaGallery.TabIndex = 10;
            this.btnCercaGallery.Text = "RICERCA";
            this.btnCercaGallery.UseVisualStyleBackColor = true;
            this.btnCercaGallery.Click += new System.EventHandler(this.btnCercaGallery_Click);
            // 
            // btGallery
            // 
            this.btGallery.Depth = 0;
            this.btGallery.Location = new System.Drawing.Point(94, 23);
            this.btGallery.Margin = new System.Windows.Forms.Padding(2);
            this.btGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGallery.Name = "btGallery";
            this.btGallery.Primary = true;
            this.btGallery.Size = new System.Drawing.Size(168, 21);
            this.btGallery.TabIndex = 9;
            this.btGallery.Text = "SELEZIONE IMMAGINE";
            this.btGallery.UseVisualStyleBackColor = true;
            this.btGallery.Click += new System.EventHandler(this.btGallery_Click);
            // 
            // btreturnGallery
            // 
            this.btreturnGallery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnGallery.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.mezza_bandiera1;
            this.btreturnGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btreturnGallery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnGallery.FlatAppearance.BorderSize = 0;
            this.btreturnGallery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreturnGallery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnGallery.Location = new System.Drawing.Point(2, 2);
            this.btreturnGallery.Margin = new System.Windows.Forms.Padding(2);
            this.btreturnGallery.Name = "btreturnGallery";
            this.btreturnGallery.Size = new System.Drawing.Size(37, 25);
            this.btreturnGallery.TabIndex = 8;
            this.btreturnGallery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnGallery.UseVisualStyleBackColor = false;
            this.btreturnGallery.Click += new System.EventHandler(this.btreturnGallery_Click);
            // 
            // pictureGallery
            // 
            this.pictureGallery.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureGallery.Location = new System.Drawing.Point(28, 55);
            this.pictureGallery.Margin = new System.Windows.Forms.Padding(2);
            this.pictureGallery.Name = "pictureGallery";
            this.pictureGallery.Size = new System.Drawing.Size(300, 220);
            this.pictureGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGallery.TabIndex = 6;
            this.pictureGallery.TabStop = false;
            // 
            // btnStartGallery
            // 
            this.btnStartGallery.Depth = 0;
            this.btnStartGallery.Location = new System.Drawing.Point(28, 289);
            this.btnStartGallery.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartGallery.Name = "btnStartGallery";
            this.btnStartGallery.Primary = true;
            this.btnStartGallery.Size = new System.Drawing.Size(69, 20);
            this.btnStartGallery.TabIndex = 5;
            this.btnStartGallery.Text = "RILEVA";
            this.btnStartGallery.UseVisualStyleBackColor = true;
            this.btnStartGallery.Click += new System.EventHandler(this.btnStartGallery_Click);
            // 
            // txGallery
            // 
            this.txGallery.Location = new System.Drawing.Point(113, 289);
            this.txGallery.Margin = new System.Windows.Forms.Padding(2);
            this.txGallery.Name = "txGallery";
            this.txGallery.Size = new System.Drawing.Size(132, 20);
            this.txGallery.TabIndex = 1;
            // 
            // panelMenù
            // 
            this.panelMenù.Controls.Add(this.lbTitoloMenù);
            this.panelMenù.Controls.Add(this.btLiveMenù);
            this.panelMenù.Controls.Add(this.btGalleryMenù);
            this.panelMenù.Controls.Add(this.lbMenù);
            this.panelMenù.Location = new System.Drawing.Point(2, 342);
            this.panelMenù.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenù.Name = "panelMenù";
            this.panelMenù.Size = new System.Drawing.Size(364, 329);
            this.panelMenù.TabIndex = 1;
            // 
            // lbTitoloMenù
            // 
            this.lbTitoloMenù.AutoSize = true;
            this.lbTitoloMenù.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitoloMenù.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitoloMenù.Location = new System.Drawing.Point(31, 44);
            this.lbTitoloMenù.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitoloMenù.Name = "lbTitoloMenù";
            this.lbTitoloMenù.Size = new System.Drawing.Size(323, 32);
            this.lbTitoloMenù.TabIndex = 4;
            this.lbTitoloMenù.Text = "Benvenuto in BarcodEZ";
            // 
            // btLiveMenù
            // 
            this.btLiveMenù.Depth = 0;
            this.btLiveMenù.Location = new System.Drawing.Point(41, 188);
            this.btLiveMenù.Margin = new System.Windows.Forms.Padding(2);
            this.btLiveMenù.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLiveMenù.Name = "btLiveMenù";
            this.btLiveMenù.Primary = true;
            this.btLiveMenù.Size = new System.Drawing.Size(106, 39);
            this.btLiveMenù.TabIndex = 3;
            this.btLiveMenù.Text = "LIVE";
            this.btLiveMenù.UseVisualStyleBackColor = true;
            this.btLiveMenù.Click += new System.EventHandler(this.btLiveMenù_Click);
            // 
            // btGalleryMenù
            // 
            this.btGalleryMenù.Depth = 0;
            this.btGalleryMenù.Location = new System.Drawing.Point(217, 188);
            this.btGalleryMenù.Margin = new System.Windows.Forms.Padding(2);
            this.btGalleryMenù.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGalleryMenù.Name = "btGalleryMenù";
            this.btGalleryMenù.Primary = true;
            this.btGalleryMenù.Size = new System.Drawing.Size(106, 39);
            this.btGalleryMenù.TabIndex = 2;
            this.btGalleryMenù.Text = "GALLERIA";
            this.btGalleryMenù.UseVisualStyleBackColor = true;
            this.btGalleryMenù.Click += new System.EventHandler(this.btGalleryMenù_Click);
            // 
            // lbMenù
            // 
            this.lbMenù.AutoSize = true;
            this.lbMenù.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenù.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMenù.Location = new System.Drawing.Point(104, 109);
            this.lbMenù.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMenù.Name = "lbMenù";
            this.lbMenù.Size = new System.Drawing.Size(165, 18);
            this.lbMenù.TabIndex = 0;
            this.lbMenù.Text = "Premi per iniziare ...";
            // 
            // PanelScelta
            // 
            this.PanelScelta.Controls.Add(this.btEbayScelta);
            this.PanelScelta.Controls.Add(this.btAmazonScelta);
            this.PanelScelta.Controls.Add(this.lbAmazonScontoScelta);
            this.PanelScelta.Controls.Add(this.lbEbayScontoScelta);
            this.PanelScelta.Controls.Add(this.btreturnScelta);
            this.PanelScelta.Controls.Add(this.lbPrezzoEbayScelta);
            this.PanelScelta.Controls.Add(this.lbPrezzoAmazonScelta);
            this.PanelScelta.Controls.Add(this.lbEbayScelta);
            this.PanelScelta.Controls.Add(this.lbAmazonScelta);
            this.PanelScelta.Location = new System.Drawing.Point(370, 342);
            this.PanelScelta.Margin = new System.Windows.Forms.Padding(2);
            this.PanelScelta.Name = "PanelScelta";
            this.PanelScelta.Size = new System.Drawing.Size(364, 329);
            this.PanelScelta.TabIndex = 5;
            // 
            // btEbayScelta
            // 
            this.btEbayScelta.BackColor = System.Drawing.SystemColors.Control;
            this.btEbayScelta.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.logoebay;
            this.btEbayScelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEbayScelta.Location = new System.Drawing.Point(228, 208);
            this.btEbayScelta.Name = "btEbayScelta";
            this.btEbayScelta.Size = new System.Drawing.Size(103, 60);
            this.btEbayScelta.TabIndex = 13;
            this.btEbayScelta.UseVisualStyleBackColor = false;
            this.btEbayScelta.Click += new System.EventHandler(this.btEbayScelta_Click);
            // 
            // btAmazonScelta
            // 
            this.btAmazonScelta.AutoSize = true;
            this.btAmazonScelta.BackColor = System.Drawing.SystemColors.Control;
            this.btAmazonScelta.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.logoamazon;
            this.btAmazonScelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAmazonScelta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btAmazonScelta.Location = new System.Drawing.Point(44, 208);
            this.btAmazonScelta.Name = "btAmazonScelta";
            this.btAmazonScelta.Size = new System.Drawing.Size(103, 60);
            this.btAmazonScelta.TabIndex = 12;
            this.btAmazonScelta.UseVisualStyleBackColor = false;
            this.btAmazonScelta.Click += new System.EventHandler(this.btAmazonScelta_Click);
            // 
            // lbAmazonScontoScelta
            // 
            this.lbAmazonScontoScelta.AutoSize = true;
            this.lbAmazonScontoScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmazonScontoScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAmazonScontoScelta.Location = new System.Drawing.Point(80, 149);
            this.lbAmazonScontoScelta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAmazonScontoScelta.Name = "lbAmazonScontoScelta";
            this.lbAmazonScontoScelta.Size = new System.Drawing.Size(11, 15);
            this.lbAmazonScontoScelta.TabIndex = 11;
            this.lbAmazonScontoScelta.Text = ".";
            // 
            // lbEbayScontoScelta
            // 
            this.lbEbayScontoScelta.AutoSize = true;
            this.lbEbayScontoScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEbayScontoScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbEbayScontoScelta.Location = new System.Drawing.Point(283, 149);
            this.lbEbayScontoScelta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEbayScontoScelta.Name = "lbEbayScontoScelta";
            this.lbEbayScontoScelta.Size = new System.Drawing.Size(11, 15);
            this.lbEbayScontoScelta.TabIndex = 10;
            this.lbEbayScontoScelta.Text = ".";
            // 
            // btreturnScelta
            // 
            this.btreturnScelta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnScelta.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.mezza_bandiera1;
            this.btreturnScelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btreturnScelta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnScelta.FlatAppearance.BorderSize = 0;
            this.btreturnScelta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnScelta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreturnScelta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnScelta.Location = new System.Drawing.Point(2, 2);
            this.btreturnScelta.Margin = new System.Windows.Forms.Padding(2);
            this.btreturnScelta.Name = "btreturnScelta";
            this.btreturnScelta.Size = new System.Drawing.Size(37, 25);
            this.btreturnScelta.TabIndex = 9;
            this.btreturnScelta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnScelta.UseVisualStyleBackColor = false;
            this.btreturnScelta.Click += new System.EventHandler(this.btreturnScelta_Click);
            // 
            // lbPrezzoEbayScelta
            // 
            this.lbPrezzoEbayScelta.AutoSize = true;
            this.lbPrezzoEbayScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezzoEbayScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPrezzoEbayScelta.Location = new System.Drawing.Point(281, 92);
            this.lbPrezzoEbayScelta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrezzoEbayScelta.Name = "lbPrezzoEbayScelta";
            this.lbPrezzoEbayScelta.Size = new System.Drawing.Size(26, 28);
            this.lbPrezzoEbayScelta.TabIndex = 8;
            this.lbPrezzoEbayScelta.Text = "0";
            // 
            // lbPrezzoAmazonScelta
            // 
            this.lbPrezzoAmazonScelta.AutoSize = true;
            this.lbPrezzoAmazonScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezzoAmazonScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPrezzoAmazonScelta.Location = new System.Drawing.Point(78, 92);
            this.lbPrezzoAmazonScelta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrezzoAmazonScelta.Name = "lbPrezzoAmazonScelta";
            this.lbPrezzoAmazonScelta.Size = new System.Drawing.Size(26, 28);
            this.lbPrezzoAmazonScelta.TabIndex = 7;
            this.lbPrezzoAmazonScelta.Text = "0";
            // 
            // lbEbayScelta
            // 
            this.lbEbayScelta.AutoSize = true;
            this.lbEbayScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEbayScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbEbayScelta.Location = new System.Drawing.Point(242, 44);
            this.lbEbayScelta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEbayScelta.Name = "lbEbayScelta";
            this.lbEbayScelta.Size = new System.Drawing.Size(106, 18);
            this.lbEbayScelta.TabIndex = 6;
            this.lbEbayScelta.Text = "Prezzo Ebay";
            // 
            // lbAmazonScelta
            // 
            this.lbAmazonScelta.AutoSize = true;
            this.lbAmazonScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmazonScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAmazonScelta.Location = new System.Drawing.Point(24, 44);
            this.lbAmazonScelta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAmazonScelta.Name = "lbAmazonScelta";
            this.lbAmazonScelta.Size = new System.Drawing.Size(130, 18);
            this.lbAmazonScelta.TabIndex = 5;
            this.lbAmazonScelta.Text = "Prezzo Amazon";
            // 
            // OpenGallery
            // 
            this.OpenGallery.FileName = "OpenGallery";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Location = new System.Drawing.Point(294, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "•••";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.Immagine;
            this.ClientSize = new System.Drawing.Size(750, 749);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodEZ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelLive.ResumeLayout(false);
            this.panelLive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).EndInit();
            this.panelGallery.ResumeLayout(false);
            this.panelGallery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGallery)).EndInit();
            this.panelMenù.ResumeLayout(false);
            this.panelMenù.PerformLayout();
            this.PanelScelta.ResumeLayout(false);
            this.PanelScelta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelMenù;
        private System.Windows.Forms.Panel panelLive;
        private System.Windows.Forms.ComboBox cmbLive;
        private System.Windows.Forms.Label lbCameraLive;
        private System.Windows.Forms.Label lbBarcodeLive;
        private System.Windows.Forms.TextBox txLive;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartLive;
        private System.Windows.Forms.PictureBox pbLive;
        private System.Windows.Forms.Label lbMenù;
        private MaterialSkin.Controls.MaterialRaisedButton btLiveMenù;
        private MaterialSkin.Controls.MaterialRaisedButton btGalleryMenù;
        private System.Windows.Forms.Panel panelGallery;
        private System.Windows.Forms.PictureBox pictureGallery;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartGallery;
        private System.Windows.Forms.TextBox txGallery;
        private System.Windows.Forms.Button btreturnLive;
        private System.Windows.Forms.Label lbTitoloMenù;
        private System.Windows.Forms.Button btreturnGallery;
        private System.Windows.Forms.OpenFileDialog OpenGallery;
        private MaterialSkin.Controls.MaterialRaisedButton btGallery;
        private MaterialSkin.Controls.MaterialRaisedButton btnCercaLive;
        private System.Windows.Forms.Panel PanelScelta;
        private MaterialSkin.Controls.MaterialRaisedButton btnCercaGallery;
        private System.Windows.Forms.Label lbPrezzoEbayScelta;
        private System.Windows.Forms.Label lbPrezzoAmazonScelta;
        private System.Windows.Forms.Label lbEbayScelta;
        private System.Windows.Forms.Label lbAmazonScelta;
        private System.Windows.Forms.Button btreturnScelta;
        private System.Windows.Forms.Label lbAmazonScontoScelta;
        private System.Windows.Forms.Label lbEbayScontoScelta;
        private System.Windows.Forms.Button btEbayScelta;
        private System.Windows.Forms.Button btAmazonScelta;
        private System.Windows.Forms.Button button1;
    }
}

