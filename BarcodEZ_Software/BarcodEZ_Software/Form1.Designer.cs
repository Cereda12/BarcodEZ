
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
            this.lbGallery = new System.Windows.Forms.Label();
            this.btGallery = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btreturnGallery = new System.Windows.Forms.Button();
            this.pictureGallery = new System.Windows.Forms.PictureBox();
            this.btnStartGallery = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txGallery = new System.Windows.Forms.TextBox();
            this.panelMenù = new System.Windows.Forms.Panel();
            this.lbTitoloMenù = new System.Windows.Forms.Label();
            this.btLiveMenù = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btGalleryMenù = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbMenù = new System.Windows.Forms.Label();
            this.OpenGallery = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).BeginInit();
            this.panelGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGallery)).BeginInit();
            this.panelMenù.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelLive);
            this.flowLayoutPanel1.Controls.Add(this.panelGallery);
            this.flowLayoutPanel1.Controls.Add(this.panelMenù);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 89);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(993, 725);
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
            this.panelLive.Location = new System.Drawing.Point(3, 2);
            this.panelLive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLive.Name = "panelLive";
            this.panelLive.Size = new System.Drawing.Size(495, 414);
            this.panelLive.TabIndex = 2;
            // 
            // btnCercaLive
            // 
            this.btnCercaLive.Depth = 0;
            this.btnCercaLive.Location = new System.Drawing.Point(336, 351);
            this.btnCercaLive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCercaLive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCercaLive.Name = "btnCercaLive";
            this.btnCercaLive.Primary = true;
            this.btnCercaLive.Size = new System.Drawing.Size(96, 26);
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
            this.btreturnLive.Location = new System.Drawing.Point(-3, -2);
            this.btreturnLive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btreturnLive.Name = "btreturnLive";
            this.btreturnLive.Size = new System.Drawing.Size(49, 31);
            this.btreturnLive.TabIndex = 7;
            this.btreturnLive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnLive.UseVisualStyleBackColor = false;
            this.btreturnLive.Click += new System.EventHandler(this.btreturnLive_Click);
            // 
            // pbLive
            // 
            this.pbLive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLive.Location = new System.Drawing.Point(48, 62);
            this.pbLive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLive.Name = "pbLive";
            this.pbLive.Size = new System.Drawing.Size(400, 271);
            this.pbLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLive.TabIndex = 6;
            this.pbLive.TabStop = false;
            // 
            // btnStartLive
            // 
            this.btnStartLive.Depth = 0;
            this.btnStartLive.Location = new System.Drawing.Point(355, 28);
            this.btnStartLive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartLive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartLive.Name = "btnStartLive";
            this.btnStartLive.Primary = true;
            this.btnStartLive.Size = new System.Drawing.Size(77, 26);
            this.btnStartLive.TabIndex = 5;
            this.btnStartLive.Text = "AVVIA";
            this.btnStartLive.UseVisualStyleBackColor = true;
            this.btnStartLive.Click += new System.EventHandler(this.btnStartLive_Click);
            // 
            // cmbLive
            // 
            this.cmbLive.FormattingEnabled = true;
            this.cmbLive.Location = new System.Drawing.Point(155, 31);
            this.cmbLive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLive.Name = "cmbLive";
            this.cmbLive.Size = new System.Drawing.Size(184, 24);
            this.cmbLive.TabIndex = 4;
            // 
            // lbCameraLive
            // 
            this.lbCameraLive.AutoSize = true;
            this.lbCameraLive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCameraLive.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCameraLive.Location = new System.Drawing.Point(45, 34);
            this.lbCameraLive.Name = "lbCameraLive";
            this.lbCameraLive.Size = new System.Drawing.Size(64, 16);
            this.lbCameraLive.TabIndex = 3;
            this.lbCameraLive.Text = "Camera:";
            // 
            // lbBarcodeLive
            // 
            this.lbBarcodeLive.AutoSize = true;
            this.lbBarcodeLive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcodeLive.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBarcodeLive.Location = new System.Drawing.Point(53, 354);
            this.lbBarcodeLive.Name = "lbBarcodeLive";
            this.lbBarcodeLive.Size = new System.Drawing.Size(69, 16);
            this.lbBarcodeLive.TabIndex = 2;
            this.lbBarcodeLive.Text = "Barcode:";
            // 
            // txLive
            // 
            this.txLive.Location = new System.Drawing.Point(163, 352);
            this.txLive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txLive.Name = "txLive";
            this.txLive.Size = new System.Drawing.Size(149, 22);
            this.txLive.TabIndex = 1;
            // 
            // panelGallery
            // 
            this.panelGallery.Controls.Add(this.lbGallery);
            this.panelGallery.Controls.Add(this.btGallery);
            this.panelGallery.Controls.Add(this.btreturnGallery);
            this.panelGallery.Controls.Add(this.pictureGallery);
            this.panelGallery.Controls.Add(this.btnStartGallery);
            this.panelGallery.Controls.Add(this.label2);
            this.panelGallery.Controls.Add(this.txGallery);
            this.panelGallery.Location = new System.Drawing.Point(504, 2);
            this.panelGallery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGallery.Name = "panelGallery";
            this.panelGallery.Size = new System.Drawing.Size(469, 414);
            this.panelGallery.TabIndex = 3;
            // 
            // lbGallery
            // 
            this.lbGallery.AutoSize = true;
            this.lbGallery.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGallery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbGallery.Location = new System.Drawing.Point(47, 52);
            this.lbGallery.Name = "lbGallery";
            this.lbGallery.Size = new System.Drawing.Size(275, 14);
            this.lbGallery.TabIndex = 5;
            this.lbGallery.Text = "Premi APRI per selezionare la tua immagine ...";
            // 
            // btGallery
            // 
            this.btGallery.Depth = 0;
            this.btGallery.Location = new System.Drawing.Point(352, 26);
            this.btGallery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGallery.Name = "btGallery";
            this.btGallery.Primary = true;
            this.btGallery.Size = new System.Drawing.Size(77, 26);
            this.btGallery.TabIndex = 9;
            this.btGallery.Text = "APRI";
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
            this.btreturnGallery.Location = new System.Drawing.Point(3, 2);
            this.btreturnGallery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btreturnGallery.Name = "btreturnGallery";
            this.btreturnGallery.Size = new System.Drawing.Size(49, 31);
            this.btreturnGallery.TabIndex = 8;
            this.btreturnGallery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnGallery.UseVisualStyleBackColor = false;
            this.btreturnGallery.Click += new System.EventHandler(this.btreturnGallery_Click);
            // 
            // pictureGallery
            // 
            this.pictureGallery.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureGallery.Location = new System.Drawing.Point(59, 94);
            this.pictureGallery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureGallery.Name = "pictureGallery";
            this.pictureGallery.Size = new System.Drawing.Size(373, 234);
            this.pictureGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGallery.TabIndex = 6;
            this.pictureGallery.TabStop = false;
            // 
            // btnStartGallery
            // 
            this.btnStartGallery.Depth = 0;
            this.btnStartGallery.Location = new System.Drawing.Point(56, 345);
            this.btnStartGallery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartGallery.Name = "btnStartGallery";
            this.btnStartGallery.Primary = true;
            this.btnStartGallery.Size = new System.Drawing.Size(77, 26);
            this.btnStartGallery.TabIndex = 5;
            this.btnStartGallery.Text = "AVVIA";
            this.btnStartGallery.UseVisualStyleBackColor = true;
            this.btnStartGallery.Click += new System.EventHandler(this.btnStartGallery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(160, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode:";
            // 
            // txGallery
            // 
            this.txGallery.Location = new System.Drawing.Point(284, 350);
            this.txGallery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txGallery.Name = "txGallery";
            this.txGallery.Size = new System.Drawing.Size(149, 22);
            this.txGallery.TabIndex = 1;
            // 
            // panelMenù
            // 
            this.panelMenù.Controls.Add(this.lbTitoloMenù);
            this.panelMenù.Controls.Add(this.btLiveMenù);
            this.panelMenù.Controls.Add(this.btGalleryMenù);
            this.panelMenù.Controls.Add(this.lbMenù);
            this.panelMenù.Location = new System.Drawing.Point(3, 420);
            this.panelMenù.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenù.Name = "panelMenù";
            this.panelMenù.Size = new System.Drawing.Size(485, 405);
            this.panelMenù.TabIndex = 1;
            // 
            // lbTitoloMenù
            // 
            this.lbTitoloMenù.AutoSize = true;
            this.lbTitoloMenù.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitoloMenù.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitoloMenù.Location = new System.Drawing.Point(41, 54);
            this.lbTitoloMenù.Name = "lbTitoloMenù";
            this.lbTitoloMenù.Size = new System.Drawing.Size(398, 38);
            this.lbTitoloMenù.TabIndex = 4;
            this.lbTitoloMenù.Text = "Benvenuto in BarcodEZ";
            // 
            // btLiveMenù
            // 
            this.btLiveMenù.Depth = 0;
            this.btLiveMenù.Location = new System.Drawing.Point(55, 231);
            this.btLiveMenù.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLiveMenù.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLiveMenù.Name = "btLiveMenù";
            this.btLiveMenù.Primary = true;
            this.btLiveMenù.Size = new System.Drawing.Size(141, 48);
            this.btLiveMenù.TabIndex = 3;
            this.btLiveMenù.Text = "LIVE";
            this.btLiveMenù.UseVisualStyleBackColor = true;
            this.btLiveMenù.Click += new System.EventHandler(this.btLiveMenù_Click);
            // 
            // btGalleryMenù
            // 
            this.btGalleryMenù.Depth = 0;
            this.btGalleryMenù.Location = new System.Drawing.Point(289, 231);
            this.btGalleryMenù.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGalleryMenù.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGalleryMenù.Name = "btGalleryMenù";
            this.btGalleryMenù.Primary = true;
            this.btGalleryMenù.Size = new System.Drawing.Size(141, 48);
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
            this.lbMenù.Location = new System.Drawing.Point(139, 134);
            this.lbMenù.Name = "lbMenù";
            this.lbMenù.Size = new System.Drawing.Size(204, 23);
            this.lbMenù.TabIndex = 0;
            this.lbMenù.Text = "Premi per iniziare ...";
            // 
            // OpenGallery
            // 
            this.OpenGallery.FileName = "OpenGallery";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.Immagine;
            this.ClientSize = new System.Drawing.Size(505, 506);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(667, 615);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txGallery;
        private System.Windows.Forms.Button btreturnLive;
        private System.Windows.Forms.Label lbTitoloMenù;
        private System.Windows.Forms.Button btreturnGallery;
        private System.Windows.Forms.OpenFileDialog OpenGallery;
        private MaterialSkin.Controls.MaterialRaisedButton btGallery;
        private System.Windows.Forms.Label lbGallery;
        private MaterialSkin.Controls.MaterialRaisedButton btnCercaLive;
    }
}

