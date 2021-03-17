
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
            this.btreturnLive = new System.Windows.Forms.Button();
            this.pbLive = new System.Windows.Forms.PictureBox();
            this.btnStartLive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbLive = new System.Windows.Forms.ComboBox();
            this.lbCameraLive = new System.Windows.Forms.Label();
            this.lbBarcodeLive = new System.Windows.Forms.Label();
            this.txLive = new System.Windows.Forms.TextBox();
            this.panelGallery = new System.Windows.Forms.Panel();
            this.btreturnGallery = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMenù = new System.Windows.Forms.Panel();
            this.lbTitoloMenù = new System.Windows.Forms.Label();
            this.btLiveMenù = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btGalleryMenù = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbMenù = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).BeginInit();
            this.panelGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenù.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelLive);
            this.flowLayoutPanel1.Controls.Add(this.panelGallery);
            this.flowLayoutPanel1.Controls.Add(this.panelMenù);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(968, 808);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.UseWaitCursor = true;
            // 
            // panelLive
            // 
            this.panelLive.Controls.Add(this.btreturnLive);
            this.panelLive.Controls.Add(this.pbLive);
            this.panelLive.Controls.Add(this.btnStartLive);
            this.panelLive.Controls.Add(this.cmbLive);
            this.panelLive.Controls.Add(this.lbCameraLive);
            this.panelLive.Controls.Add(this.lbBarcodeLive);
            this.panelLive.Controls.Add(this.txLive);
            this.panelLive.Location = new System.Drawing.Point(3, 3);
            this.panelLive.Name = "panelLive";
            this.panelLive.Size = new System.Drawing.Size(486, 416);
            this.panelLive.TabIndex = 2;
            this.panelLive.UseWaitCursor = true;
            // 
            // btreturnLive
            // 
            this.btreturnLive.Location = new System.Drawing.Point(-3, -3);
            this.btreturnLive.Name = "btreturnLive";
            this.btreturnLive.Size = new System.Drawing.Size(49, 31);
            this.btreturnLive.TabIndex = 7;
            this.btreturnLive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnLive.UseVisualStyleBackColor = true;
            this.btreturnLive.UseWaitCursor = true;
            this.btreturnLive.Click += new System.EventHandler(this.btreturnLive_Click);
            // 
            // pbLive
            // 
            this.pbLive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLive.Location = new System.Drawing.Point(56, 81);
            this.pbLive.Name = "pbLive";
            this.pbLive.Size = new System.Drawing.Size(374, 234);
            this.pbLive.TabIndex = 6;
            this.pbLive.TabStop = false;
            this.pbLive.UseWaitCursor = true;
            // 
            // btnStartLive
            // 
            this.btnStartLive.Depth = 0;
            this.btnStartLive.Location = new System.Drawing.Point(352, 352);
            this.btnStartLive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartLive.Name = "btnStartLive";
            this.btnStartLive.Primary = true;
            this.btnStartLive.Size = new System.Drawing.Size(78, 26);
            this.btnStartLive.TabIndex = 5;
            this.btnStartLive.Text = "START";
            this.btnStartLive.UseVisualStyleBackColor = true;
            this.btnStartLive.UseWaitCursor = true;
            this.btnStartLive.Click += new System.EventHandler(this.btnStartLive_Click);
            // 
            // cmbLive
            // 
            this.cmbLive.FormattingEnabled = true;
            this.cmbLive.Location = new System.Drawing.Point(155, 31);
            this.cmbLive.Name = "cmbLive";
            this.cmbLive.Size = new System.Drawing.Size(184, 24);
            this.cmbLive.TabIndex = 4;
            this.cmbLive.UseWaitCursor = true;
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
            this.lbCameraLive.UseWaitCursor = true;
            // 
            // lbBarcodeLive
            // 
            this.lbBarcodeLive.AutoSize = true;
            this.lbBarcodeLive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcodeLive.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBarcodeLive.Location = new System.Drawing.Point(53, 355);
            this.lbBarcodeLive.Name = "lbBarcodeLive";
            this.lbBarcodeLive.Size = new System.Drawing.Size(69, 16);
            this.lbBarcodeLive.TabIndex = 2;
            this.lbBarcodeLive.Text = "Barcode:";
            this.lbBarcodeLive.UseWaitCursor = true;
            // 
            // txLive
            // 
            this.txLive.Location = new System.Drawing.Point(163, 352);
            this.txLive.Name = "txLive";
            this.txLive.Size = new System.Drawing.Size(149, 22);
            this.txLive.TabIndex = 1;
            this.txLive.UseWaitCursor = true;
            // 
            // panelGallery
            // 
            this.panelGallery.Controls.Add(this.btreturnGallery);
            this.panelGallery.Controls.Add(this.pictureBox1);
            this.panelGallery.Controls.Add(this.materialRaisedButton1);
            this.panelGallery.Controls.Add(this.label2);
            this.panelGallery.Controls.Add(this.textBox1);
            this.panelGallery.Location = new System.Drawing.Point(495, 3);
            this.panelGallery.Name = "panelGallery";
            this.panelGallery.Size = new System.Drawing.Size(469, 413);
            this.panelGallery.TabIndex = 3;
            this.panelGallery.UseWaitCursor = true;
            // 
            // btreturnGallery
            // 
            this.btreturnGallery.Location = new System.Drawing.Point(0, -3);
            this.btreturnGallery.Name = "btreturnGallery";
            this.btreturnGallery.Size = new System.Drawing.Size(49, 31);
            this.btreturnGallery.TabIndex = 8;
            this.btreturnGallery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btreturnGallery.UseVisualStyleBackColor = true;
            this.btreturnGallery.UseWaitCursor = true;
            this.btreturnGallery.Click += new System.EventHandler(this.btreturnGallery_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(59, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 234);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(355, 352);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(78, 26);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "START";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(56, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode:";
            this.label2.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseWaitCursor = true;
            // 
            // panelMenù
            // 
            this.panelMenù.Controls.Add(this.lbTitoloMenù);
            this.panelMenù.Controls.Add(this.btLiveMenù);
            this.panelMenù.Controls.Add(this.btGalleryMenù);
            this.panelMenù.Controls.Add(this.lbMenù);
            this.panelMenù.Location = new System.Drawing.Point(3, 425);
            this.panelMenù.Name = "panelMenù";
            this.panelMenù.Size = new System.Drawing.Size(486, 405);
            this.panelMenù.TabIndex = 1;
            this.panelMenù.UseWaitCursor = true;
            // 
            // lbTitoloMenù
            // 
            this.lbTitoloMenù.AutoSize = true;
            this.lbTitoloMenù.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitoloMenù.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitoloMenù.Location = new System.Drawing.Point(41, 54);
            this.lbTitoloMenù.Name = "lbTitoloMenù";
            this.lbTitoloMenù.Size = new System.Drawing.Size(387, 38);
            this.lbTitoloMenù.TabIndex = 4;
            this.lbTitoloMenù.Text = "Benvenuti in BarcodEZ";
            this.lbTitoloMenù.UseWaitCursor = true;
            // 
            // btLiveMenù
            // 
            this.btLiveMenù.Depth = 0;
            this.btLiveMenù.Location = new System.Drawing.Point(55, 231);
            this.btLiveMenù.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLiveMenù.Name = "btLiveMenù";
            this.btLiveMenù.Primary = true;
            this.btLiveMenù.Size = new System.Drawing.Size(141, 48);
            this.btLiveMenù.TabIndex = 3;
            this.btLiveMenù.Text = "LIVE";
            this.btLiveMenù.UseVisualStyleBackColor = true;
            this.btLiveMenù.UseWaitCursor = true;
            this.btLiveMenù.Click += new System.EventHandler(this.btLiveMenù_Click);
            // 
            // btGalleryMenù
            // 
            this.btGalleryMenù.Depth = 0;
            this.btGalleryMenù.Location = new System.Drawing.Point(289, 231);
            this.btGalleryMenù.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGalleryMenù.Name = "btGalleryMenù";
            this.btGalleryMenù.Primary = true;
            this.btGalleryMenù.Size = new System.Drawing.Size(141, 48);
            this.btGalleryMenù.TabIndex = 2;
            this.btGalleryMenù.Text = "GALLERY";
            this.btGalleryMenù.UseVisualStyleBackColor = true;
            this.btGalleryMenù.UseWaitCursor = true;
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
            this.lbMenù.UseWaitCursor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.Immagine;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BarcodEZ";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelLive.ResumeLayout(false);
            this.panelLive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).EndInit();
            this.panelGallery.ResumeLayout(false);
            this.panelGallery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btreturnLive;
        private System.Windows.Forms.Button btreturnGallery;
        private System.Windows.Forms.Label lbTitoloMenù;
    }
}

