﻿
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
            this.lbCronologia = new System.Windows.Forms.Label();
            this.lbTitoloMenù = new System.Windows.Forms.Label();
            this.btLiveMenù = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btGalleryMenù = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbMenù = new System.Windows.Forms.Label();
            this.panelScelta = new System.Windows.Forms.Panel();
            this.lbTitoloEbay = new System.Windows.Forms.Label();
            this.lbTitoloAmazon = new System.Windows.Forms.Label();
            this.lbPrezzoNoScontoEbayScelta = new System.Windows.Forms.Label();
            this.lbPrezzoNoScontoAmazonScelta = new System.Windows.Forms.Label();
            this.btEbayScelta = new System.Windows.Forms.Button();
            this.btAmazonScelta = new System.Windows.Forms.Button();
            this.btreturnScelta = new System.Windows.Forms.Button();
            this.lbPrezzoEbayScelta = new System.Windows.Forms.Label();
            this.lbPrezzoAmazonScelta = new System.Windows.Forms.Label();
            this.lbEbayScelta = new System.Windows.Forms.Label();
            this.lbAmazonScelta = new System.Windows.Forms.Label();
            this.panelCronologia = new System.Windows.Forms.Panel();
            this.btCronologia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GridCronologia = new System.Windows.Forms.DataGridView();
            this.btreturnCronologia = new System.Windows.Forms.Button();
            this.OpenGallery = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).BeginInit();
            this.panelGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGallery)).BeginInit();
            this.panelMenù.SuspendLayout();
            this.panelScelta.SuspendLayout();
            this.panelCronologia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCronologia)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelLive);
            this.flowLayoutPanel1.Controls.Add(this.panelGallery);
            this.flowLayoutPanel1.Controls.Add(this.panelMenù);
            this.flowLayoutPanel1.Controls.Add(this.panelScelta);
            this.flowLayoutPanel1.Controls.Add(this.panelCronologia);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1650, 1029);
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
            this.panelLive.Location = new System.Drawing.Point(3, 3);
            this.panelLive.Name = "panelLive";
            this.panelLive.Size = new System.Drawing.Size(556, 517);
            this.panelLive.TabIndex = 2;
            // 
            // btnCercaLive
            // 
            this.btnCercaLive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCercaLive.Depth = 0;
            this.btnCercaLive.Location = new System.Drawing.Point(396, 445);
            this.btnCercaLive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCercaLive.Name = "btnCercaLive";
            this.btnCercaLive.Primary = true;
            this.btnCercaLive.Size = new System.Drawing.Size(108, 32);
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
            this.btreturnLive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btreturnLive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnLive.FlatAppearance.BorderSize = 0;
            this.btreturnLive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreturnLive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnLive.Location = new System.Drawing.Point(-3, -3);
            this.btreturnLive.Name = "btreturnLive";
            this.btreturnLive.Size = new System.Drawing.Size(56, 38);
            this.btreturnLive.TabIndex = 7;
            this.btreturnLive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnLive.UseVisualStyleBackColor = false;
            this.btreturnLive.Click += new System.EventHandler(this.btreturnLive_Click);
            // 
            // pbLive
            // 
            this.pbLive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLive.Location = new System.Drawing.Point(54, 85);
            this.pbLive.Name = "pbLive";
            this.pbLive.Size = new System.Drawing.Size(450, 338);
            this.pbLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLive.TabIndex = 6;
            this.pbLive.TabStop = false;
            // 
            // btnStartLive
            // 
            this.btnStartLive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartLive.Depth = 0;
            this.btnStartLive.Location = new System.Drawing.Point(396, 35);
            this.btnStartLive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartLive.Name = "btnStartLive";
            this.btnStartLive.Primary = true;
            this.btnStartLive.Size = new System.Drawing.Size(108, 32);
            this.btnStartLive.TabIndex = 5;
            this.btnStartLive.Text = "AVVIA";
            this.btnStartLive.UseVisualStyleBackColor = true;
            this.btnStartLive.Click += new System.EventHandler(this.btnStartLive_Click);
            // 
            // cmbLive
            // 
            this.cmbLive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLive.FormattingEnabled = true;
            this.cmbLive.Location = new System.Drawing.Point(160, 35);
            this.cmbLive.Name = "cmbLive";
            this.cmbLive.Size = new System.Drawing.Size(206, 28);
            this.cmbLive.TabIndex = 4;
            // 
            // lbCameraLive
            // 
            this.lbCameraLive.AutoSize = true;
            this.lbCameraLive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCameraLive.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCameraLive.Location = new System.Drawing.Point(51, 43);
            this.lbCameraLive.Name = "lbCameraLive";
            this.lbCameraLive.Size = new System.Drawing.Size(76, 18);
            this.lbCameraLive.TabIndex = 3;
            this.lbCameraLive.Text = "Camera:";
            // 
            // lbBarcodeLive
            // 
            this.lbBarcodeLive.AutoSize = true;
            this.lbBarcodeLive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcodeLive.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBarcodeLive.Location = new System.Drawing.Point(58, 451);
            this.lbBarcodeLive.Name = "lbBarcodeLive";
            this.lbBarcodeLive.Size = new System.Drawing.Size(82, 18);
            this.lbBarcodeLive.TabIndex = 2;
            this.lbBarcodeLive.Text = "Barcode:";
            // 
            // txLive
            // 
            this.txLive.Location = new System.Drawing.Point(160, 446);
            this.txLive.Name = "txLive";
            this.txLive.ReadOnly = true;
            this.txLive.Size = new System.Drawing.Size(206, 26);
            this.txLive.TabIndex = 1;
            // 
            // panelGallery
            // 
            this.panelGallery.Controls.Add(this.btnCercaGallery);
            this.panelGallery.Controls.Add(this.btGallery);
            this.panelGallery.Controls.Add(this.btreturnGallery);
            this.panelGallery.Controls.Add(this.pictureGallery);
            this.panelGallery.Controls.Add(this.btnStartGallery);
            this.panelGallery.Controls.Add(this.txGallery);
            this.panelGallery.Location = new System.Drawing.Point(565, 3);
            this.panelGallery.Name = "panelGallery";
            this.panelGallery.Size = new System.Drawing.Size(528, 517);
            this.panelGallery.TabIndex = 3;
            // 
            // btnCercaGallery
            // 
            this.btnCercaGallery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCercaGallery.Depth = 0;
            this.btnCercaGallery.Location = new System.Drawing.Point(388, 445);
            this.btnCercaGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCercaGallery.Name = "btnCercaGallery";
            this.btnCercaGallery.Primary = true;
            this.btnCercaGallery.Size = new System.Drawing.Size(104, 31);
            this.btnCercaGallery.TabIndex = 10;
            this.btnCercaGallery.Text = "RICERCA";
            this.btnCercaGallery.UseVisualStyleBackColor = true;
            this.btnCercaGallery.Click += new System.EventHandler(this.btnCercaGallery_Click);
            // 
            // btGallery
            // 
            this.btGallery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGallery.Depth = 0;
            this.btGallery.Location = new System.Drawing.Point(141, 35);
            this.btGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGallery.Name = "btGallery";
            this.btGallery.Primary = true;
            this.btGallery.Size = new System.Drawing.Size(252, 32);
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
            this.btreturnGallery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btreturnGallery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnGallery.FlatAppearance.BorderSize = 0;
            this.btreturnGallery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreturnGallery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnGallery.Location = new System.Drawing.Point(3, 3);
            this.btreturnGallery.Name = "btreturnGallery";
            this.btreturnGallery.Size = new System.Drawing.Size(56, 38);
            this.btreturnGallery.TabIndex = 8;
            this.btreturnGallery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnGallery.UseVisualStyleBackColor = false;
            this.btreturnGallery.Click += new System.EventHandler(this.btreturnGallery_Click);
            // 
            // pictureGallery
            // 
            this.pictureGallery.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureGallery.Location = new System.Drawing.Point(42, 85);
            this.pictureGallery.Name = "pictureGallery";
            this.pictureGallery.Size = new System.Drawing.Size(450, 338);
            this.pictureGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGallery.TabIndex = 6;
            this.pictureGallery.TabStop = false;
            // 
            // btnStartGallery
            // 
            this.btnStartGallery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGallery.Depth = 0;
            this.btnStartGallery.Location = new System.Drawing.Point(42, 445);
            this.btnStartGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartGallery.Name = "btnStartGallery";
            this.btnStartGallery.Primary = true;
            this.btnStartGallery.Size = new System.Drawing.Size(104, 31);
            this.btnStartGallery.TabIndex = 5;
            this.btnStartGallery.Text = "RILEVA";
            this.btnStartGallery.UseVisualStyleBackColor = true;
            this.btnStartGallery.Click += new System.EventHandler(this.btnStartGallery_Click);
            // 
            // txGallery
            // 
            this.txGallery.Location = new System.Drawing.Point(170, 445);
            this.txGallery.Name = "txGallery";
            this.txGallery.Size = new System.Drawing.Size(196, 26);
            this.txGallery.TabIndex = 1;
            // 
            // panelMenù
            // 
            this.panelMenù.Controls.Add(this.lbCronologia);
            this.panelMenù.Controls.Add(this.lbTitoloMenù);
            this.panelMenù.Controls.Add(this.btLiveMenù);
            this.panelMenù.Controls.Add(this.btGalleryMenù);
            this.panelMenù.Controls.Add(this.lbMenù);
            this.panelMenù.Location = new System.Drawing.Point(1099, 3);
            this.panelMenù.Name = "panelMenù";
            this.panelMenù.Size = new System.Drawing.Size(546, 517);
            this.panelMenù.TabIndex = 1;
            // 
            // lbCronologia
            // 
            this.lbCronologia.AutoSize = true;
            this.lbCronologia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCronologia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCronologia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCronologia.Location = new System.Drawing.Point(170, 405);
            this.lbCronologia.Name = "lbCronologia";
            this.lbCronologia.Size = new System.Drawing.Size(180, 28);
            this.lbCronologia.TabIndex = 5;
            this.lbCronologia.Text = "CRONOLOGIA";
            this.lbCronologia.Click += new System.EventHandler(this.lbCronologia_Click);
            // 
            // lbTitoloMenù
            // 
            this.lbTitoloMenù.AutoSize = true;
            this.lbTitoloMenù.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitoloMenù.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitoloMenù.Location = new System.Drawing.Point(46, 68);
            this.lbTitoloMenù.Name = "lbTitoloMenù";
            this.lbTitoloMenù.Size = new System.Drawing.Size(481, 46);
            this.lbTitoloMenù.TabIndex = 4;
            this.lbTitoloMenù.Text = "Benvenuto in BarcodEZ";
            // 
            // btLiveMenù
            // 
            this.btLiveMenù.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLiveMenù.Depth = 0;
            this.btLiveMenù.Location = new System.Drawing.Point(62, 289);
            this.btLiveMenù.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLiveMenù.Name = "btLiveMenù";
            this.btLiveMenù.Primary = true;
            this.btLiveMenù.Size = new System.Drawing.Size(159, 60);
            this.btLiveMenù.TabIndex = 3;
            this.btLiveMenù.Text = "LIVE";
            this.btLiveMenù.UseVisualStyleBackColor = true;
            this.btLiveMenù.Click += new System.EventHandler(this.btLiveMenù_Click);
            // 
            // btGalleryMenù
            // 
            this.btGalleryMenù.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGalleryMenù.Depth = 0;
            this.btGalleryMenù.Location = new System.Drawing.Point(326, 289);
            this.btGalleryMenù.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGalleryMenù.Name = "btGalleryMenù";
            this.btGalleryMenù.Primary = true;
            this.btGalleryMenù.Size = new System.Drawing.Size(159, 60);
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
            this.lbMenù.Location = new System.Drawing.Point(156, 168);
            this.lbMenù.Name = "lbMenù";
            this.lbMenù.Size = new System.Drawing.Size(250, 28);
            this.lbMenù.TabIndex = 0;
            this.lbMenù.Text = "Premi per iniziare ...";
            // 
            // panelScelta
            // 
            this.panelScelta.Controls.Add(this.lbTitoloEbay);
            this.panelScelta.Controls.Add(this.lbTitoloAmazon);
            this.panelScelta.Controls.Add(this.lbPrezzoNoScontoEbayScelta);
            this.panelScelta.Controls.Add(this.lbPrezzoNoScontoAmazonScelta);
            this.panelScelta.Controls.Add(this.btEbayScelta);
            this.panelScelta.Controls.Add(this.btAmazonScelta);
            this.panelScelta.Controls.Add(this.btreturnScelta);
            this.panelScelta.Controls.Add(this.lbPrezzoEbayScelta);
            this.panelScelta.Controls.Add(this.lbPrezzoAmazonScelta);
            this.panelScelta.Controls.Add(this.lbEbayScelta);
            this.panelScelta.Controls.Add(this.lbAmazonScelta);
            this.panelScelta.Location = new System.Drawing.Point(3, 526);
            this.panelScelta.Name = "panelScelta";
            this.panelScelta.Size = new System.Drawing.Size(556, 506);
            this.panelScelta.TabIndex = 5;
            // 
            // lbTitoloEbay
            // 
            this.lbTitoloEbay.AutoSize = true;
            this.lbTitoloEbay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitoloEbay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitoloEbay.Location = new System.Drawing.Point(345, 217);
            this.lbTitoloEbay.MaximumSize = new System.Drawing.Size(154, 77);
            this.lbTitoloEbay.Name = "lbTitoloEbay";
            this.lbTitoloEbay.Size = new System.Drawing.Size(21, 21);
            this.lbTitoloEbay.TabIndex = 19;
            this.lbTitoloEbay.Text = "0";
            // 
            // lbTitoloAmazon
            // 
            this.lbTitoloAmazon.AutoSize = true;
            this.lbTitoloAmazon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitoloAmazon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitoloAmazon.Location = new System.Drawing.Point(62, 217);
            this.lbTitoloAmazon.MaximumSize = new System.Drawing.Size(154, 77);
            this.lbTitoloAmazon.Name = "lbTitoloAmazon";
            this.lbTitoloAmazon.Size = new System.Drawing.Size(21, 21);
            this.lbTitoloAmazon.TabIndex = 18;
            this.lbTitoloAmazon.Text = "0";
            // 
            // lbPrezzoNoScontoEbayScelta
            // 
            this.lbPrezzoNoScontoEbayScelta.AutoSize = true;
            this.lbPrezzoNoScontoEbayScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezzoNoScontoEbayScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPrezzoNoScontoEbayScelta.Location = new System.Drawing.Point(381, 168);
            this.lbPrezzoNoScontoEbayScelta.Name = "lbPrezzoNoScontoEbayScelta";
            this.lbPrezzoNoScontoEbayScelta.Size = new System.Drawing.Size(26, 28);
            this.lbPrezzoNoScontoEbayScelta.TabIndex = 17;
            this.lbPrezzoNoScontoEbayScelta.Text = "0";
            // 
            // lbPrezzoNoScontoAmazonScelta
            // 
            this.lbPrezzoNoScontoAmazonScelta.AutoSize = true;
            this.lbPrezzoNoScontoAmazonScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezzoNoScontoAmazonScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPrezzoNoScontoAmazonScelta.Location = new System.Drawing.Point(84, 168);
            this.lbPrezzoNoScontoAmazonScelta.Name = "lbPrezzoNoScontoAmazonScelta";
            this.lbPrezzoNoScontoAmazonScelta.Size = new System.Drawing.Size(26, 28);
            this.lbPrezzoNoScontoAmazonScelta.TabIndex = 16;
            this.lbPrezzoNoScontoAmazonScelta.Text = "0";
            // 
            // btEbayScelta
            // 
            this.btEbayScelta.BackColor = System.Drawing.SystemColors.Control;
            this.btEbayScelta.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.logoebay;
            this.btEbayScelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEbayScelta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEbayScelta.Location = new System.Drawing.Point(342, 320);
            this.btEbayScelta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEbayScelta.Name = "btEbayScelta";
            this.btEbayScelta.Size = new System.Drawing.Size(154, 92);
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
            this.btAmazonScelta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAmazonScelta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btAmazonScelta.Location = new System.Drawing.Point(66, 320);
            this.btAmazonScelta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAmazonScelta.Name = "btAmazonScelta";
            this.btAmazonScelta.Size = new System.Drawing.Size(154, 92);
            this.btAmazonScelta.TabIndex = 12;
            this.btAmazonScelta.UseVisualStyleBackColor = false;
            this.btAmazonScelta.Click += new System.EventHandler(this.btAmazonScelta_Click);
            // 
            // btreturnScelta
            // 
            this.btreturnScelta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnScelta.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.mezza_bandiera1;
            this.btreturnScelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btreturnScelta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btreturnScelta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnScelta.FlatAppearance.BorderSize = 0;
            this.btreturnScelta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnScelta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreturnScelta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnScelta.Location = new System.Drawing.Point(3, 3);
            this.btreturnScelta.Name = "btreturnScelta";
            this.btreturnScelta.Size = new System.Drawing.Size(56, 38);
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
            this.lbPrezzoEbayScelta.Location = new System.Drawing.Point(368, 114);
            this.lbPrezzoEbayScelta.Name = "lbPrezzoEbayScelta";
            this.lbPrezzoEbayScelta.Size = new System.Drawing.Size(39, 42);
            this.lbPrezzoEbayScelta.TabIndex = 8;
            this.lbPrezzoEbayScelta.Text = "0";
            // 
            // lbPrezzoAmazonScelta
            // 
            this.lbPrezzoAmazonScelta.AutoSize = true;
            this.lbPrezzoAmazonScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezzoAmazonScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPrezzoAmazonScelta.Location = new System.Drawing.Point(72, 114);
            this.lbPrezzoAmazonScelta.Name = "lbPrezzoAmazonScelta";
            this.lbPrezzoAmazonScelta.Size = new System.Drawing.Size(39, 42);
            this.lbPrezzoAmazonScelta.TabIndex = 7;
            this.lbPrezzoAmazonScelta.Text = "0";
            // 
            // lbEbayScelta
            // 
            this.lbEbayScelta.AutoSize = true;
            this.lbEbayScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEbayScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbEbayScelta.Location = new System.Drawing.Point(345, 68);
            this.lbEbayScelta.Name = "lbEbayScelta";
            this.lbEbayScelta.Size = new System.Drawing.Size(157, 28);
            this.lbEbayScelta.TabIndex = 6;
            this.lbEbayScelta.Text = "Prezzo Ebay";
            // 
            // lbAmazonScelta
            // 
            this.lbAmazonScelta.AutoSize = true;
            this.lbAmazonScelta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmazonScelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAmazonScelta.Location = new System.Drawing.Point(36, 68);
            this.lbAmazonScelta.Name = "lbAmazonScelta";
            this.lbAmazonScelta.Size = new System.Drawing.Size(192, 28);
            this.lbAmazonScelta.TabIndex = 5;
            this.lbAmazonScelta.Text = "Prezzo Amazon";
            // 
            // panelCronologia
            // 
            this.panelCronologia.Controls.Add(this.btCronologia);
            this.panelCronologia.Controls.Add(this.label1);
            this.panelCronologia.Controls.Add(this.GridCronologia);
            this.panelCronologia.Controls.Add(this.btreturnCronologia);
            this.panelCronologia.Location = new System.Drawing.Point(565, 526);
            this.panelCronologia.Name = "panelCronologia";
            this.panelCronologia.Size = new System.Drawing.Size(528, 506);
            this.panelCronologia.TabIndex = 14;
            // 
            // btCronologia
            // 
            this.btCronologia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCronologia.Depth = 0;
            this.btCronologia.Location = new System.Drawing.Point(142, 455);
            this.btCronologia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCronologia.Name = "btCronologia";
            this.btCronologia.Primary = true;
            this.btCronologia.Size = new System.Drawing.Size(250, 37);
            this.btCronologia.TabIndex = 6;
            this.btCronologia.Text = "SVUOTA CRONOLOGIA";
            this.btCronologia.UseVisualStyleBackColor = true;
            this.btCronologia.Click += new System.EventHandler(this.btCronologia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(88, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Clicca due volte per eliminare...";
            // 
            // GridCronologia
            // 
            this.GridCronologia.AllowUserToAddRows = false;
            this.GridCronologia.AllowUserToDeleteRows = false;
            this.GridCronologia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCronologia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCronologia.Location = new System.Drawing.Point(4, 49);
            this.GridCronologia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridCronologia.Name = "GridCronologia";
            this.GridCronologia.ReadOnly = true;
            this.GridCronologia.RowHeadersVisible = false;
            this.GridCronologia.RowHeadersWidth = 230;
            this.GridCronologia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridCronologia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCronologia.Size = new System.Drawing.Size(519, 398);
            this.GridCronologia.TabIndex = 10;
            this.GridCronologia.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridCronologia_CellMouseDoubleClick);
            // 
            // btreturnCronologia
            // 
            this.btreturnCronologia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnCronologia.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.mezza_bandiera1;
            this.btreturnCronologia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btreturnCronologia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btreturnCronologia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnCronologia.FlatAppearance.BorderSize = 0;
            this.btreturnCronologia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnCronologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreturnCronologia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btreturnCronologia.Location = new System.Drawing.Point(3, 3);
            this.btreturnCronologia.Name = "btreturnCronologia";
            this.btreturnCronologia.Size = new System.Drawing.Size(56, 38);
            this.btreturnCronologia.TabIndex = 9;
            this.btreturnCronologia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnCronologia.UseVisualStyleBackColor = false;
            this.btreturnCronologia.Click += new System.EventHandler(this.btreturnCronologia_Click);
            // 
            // OpenGallery
            // 
            this.OpenGallery.FileName = "OpenGallery";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.Immagine;
            this.ClientSize = new System.Drawing.Size(566, 634);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 634);
            this.MinimumSize = new System.Drawing.Size(566, 634);
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
            this.panelScelta.ResumeLayout(false);
            this.panelScelta.PerformLayout();
            this.panelCronologia.ResumeLayout(false);
            this.panelCronologia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCronologia)).EndInit();
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
        private System.Windows.Forms.Panel panelScelta;
        private MaterialSkin.Controls.MaterialRaisedButton btnCercaGallery;
        private System.Windows.Forms.Label lbPrezzoEbayScelta;
        private System.Windows.Forms.Label lbPrezzoAmazonScelta;
        private System.Windows.Forms.Label lbEbayScelta;
        private System.Windows.Forms.Label lbAmazonScelta;
        private System.Windows.Forms.Button btreturnScelta;
        private System.Windows.Forms.Button btAmazonScelta;
        private System.Windows.Forms.Button btEbayScelta;
        private System.Windows.Forms.Label lbCronologia;
        private System.Windows.Forms.Panel panelCronologia;
        private System.Windows.Forms.Button btreturnCronologia;
        private System.Windows.Forms.DataGridView GridCronologia;
        private MaterialSkin.Controls.MaterialRaisedButton btCronologia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrezzoNoScontoEbayScelta;
        private System.Windows.Forms.Label lbPrezzoNoScontoAmazonScelta;
        private System.Windows.Forms.Label lbTitoloEbay;
        private System.Windows.Forms.Label lbTitoloAmazon;
    }
}

