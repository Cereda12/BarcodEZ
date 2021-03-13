
namespace BarcodEZ_Software
{
    partial class BarcodEZ
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLive = new System.Windows.Forms.Panel();
            this.btReturnLive = new System.Windows.Forms.Button();
            this.btStartLive = new MaterialSkin.Controls.MaterialFlatButton();
            this.txStart = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panelMenù = new System.Windows.Forms.Panel();
            this.btLive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btGallery = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbMenù = new System.Windows.Forms.Label();
            this.panelGallery = new System.Windows.Forms.Panel();
            this.btStartGallery = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btReturnGallery = new System.Windows.Forms.Button();
            this.pictStart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLive.SuspendLayout();
            this.panelMenù.SuspendLayout();
            this.panelGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelLive);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 519);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelLive
            // 
            this.panelLive.Controls.Add(this.btReturnLive);
            this.panelLive.Controls.Add(this.btStartLive);
            this.panelLive.Controls.Add(this.txStart);
            this.panelLive.Controls.Add(this.materialLabel3);
            this.panelLive.Controls.Add(this.pictStart);
            this.panelLive.Controls.Add(this.cmbCamera);
            this.panelLive.Controls.Add(this.materialLabel4);
            this.panelLive.Location = new System.Drawing.Point(3, 3);
            this.panelLive.Name = "panelLive";
            this.panelLive.Size = new System.Drawing.Size(691, 512);
            this.panelLive.TabIndex = 43;
            // 
            // btReturnLive
            // 
            this.btReturnLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturnLive.Location = new System.Drawing.Point(5, 7);
            this.btReturnLive.Name = "btReturnLive";
            this.btReturnLive.Size = new System.Drawing.Size(103, 51);
            this.btReturnLive.TabIndex = 43;
            this.btReturnLive.Text = "<==";
            this.btReturnLive.UseVisualStyleBackColor = true;
            this.btReturnLive.Click += new System.EventHandler(this.btReturnLive_Click);
            // 
            // btStartLive
            // 
            this.btStartLive.AutoSize = true;
            this.btStartLive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btStartLive.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btStartLive.Depth = 0;
            this.btStartLive.Location = new System.Drawing.Point(567, 464);
            this.btStartLive.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btStartLive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btStartLive.Name = "btStartLive";
            this.btStartLive.Primary = false;
            this.btStartLive.Size = new System.Drawing.Size(66, 36);
            this.btStartLive.TabIndex = 41;
            this.btStartLive.Text = "START";
            this.btStartLive.UseVisualStyleBackColor = false;
            // 
            // txStart
            // 
            this.txStart.Location = new System.Drawing.Point(190, 471);
            this.txStart.Margin = new System.Windows.Forms.Padding(4);
            this.txStart.Name = "txStart";
            this.txStart.Size = new System.Drawing.Size(277, 22);
            this.txStart.TabIndex = 40;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(72, 469);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 24);
            this.materialLabel3.TabIndex = 39;
            this.materialLabel3.Text = "Barcode:";
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(287, 27);
            this.cmbCamera.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(346, 24);
            this.cmbCamera.TabIndex = 37;
            this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.cmbCamera_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(146, 26);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(81, 24);
            this.materialLabel4.TabIndex = 36;
            this.materialLabel4.Text = "Camera:";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(567, 464);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(66, 36);
            this.materialFlatButton1.TabIndex = 41;
            this.materialFlatButton1.Text = "START";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 471);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 40;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(72, 469);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 24);
            this.materialLabel1.TabIndex = 39;
            this.materialLabel1.Text = "Barcode:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gallery",
            "Camera"});
            this.comboBox1.Location = new System.Drawing.Point(190, 20);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(49, 19);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(80, 24);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "Camera:";
            // 
            // panelMenù
            // 
            this.panelMenù.Controls.Add(this.btLive);
            this.panelMenù.Controls.Add(this.btGallery);
            this.panelMenù.Controls.Add(this.lbMenù);
            this.panelMenù.Location = new System.Drawing.Point(4, 171);
            this.panelMenù.Name = "panelMenù";
            this.panelMenù.Size = new System.Drawing.Size(694, 413);
            this.panelMenù.TabIndex = 44;
            // 
            // btLive
            // 
            this.btLive.Depth = 0;
            this.btLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLive.Location = new System.Drawing.Point(93, 234);
            this.btLive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLive.Name = "btLive";
            this.btLive.Primary = true;
            this.btLive.Size = new System.Drawing.Size(191, 71);
            this.btLive.TabIndex = 3;
            this.btLive.Text = "LIVE";
            this.btLive.UseVisualStyleBackColor = true;
            this.btLive.Click += new System.EventHandler(this.btLive_Click);
            // 
            // btGallery
            // 
            this.btGallery.Depth = 0;
            this.btGallery.Location = new System.Drawing.Point(388, 234);
            this.btGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGallery.Name = "btGallery";
            this.btGallery.Primary = true;
            this.btGallery.Size = new System.Drawing.Size(191, 71);
            this.btGallery.TabIndex = 2;
            this.btGallery.Text = "GALLERY";
            this.btGallery.UseVisualStyleBackColor = true;
            this.btGallery.Click += new System.EventHandler(this.btGallery_Click);
            // 
            // lbMenù
            // 
            this.lbMenù.AutoSize = true;
            this.lbMenù.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenù.Location = new System.Drawing.Point(215, 93);
            this.lbMenù.Name = "lbMenù";
            this.lbMenù.Size = new System.Drawing.Size(241, 29);
            this.lbMenù.TabIndex = 0;
            this.lbMenù.Text = "Premi per iniziare...";
            // 
            // panelGallery
            // 
            this.panelGallery.Controls.Add(this.btReturnGallery);
            this.panelGallery.Controls.Add(this.btStartGallery);
            this.panelGallery.Controls.Add(this.textBox3);
            this.panelGallery.Controls.Add(this.materialLabel5);
            this.panelGallery.Location = new System.Drawing.Point(12, 74);
            this.panelGallery.Name = "panelGallery";
            this.panelGallery.Size = new System.Drawing.Size(686, 513);
            this.panelGallery.TabIndex = 44;
            // 
            // btStartGallery
            // 
            this.btStartGallery.AutoSize = true;
            this.btStartGallery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btStartGallery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btStartGallery.Depth = 0;
            this.btStartGallery.Location = new System.Drawing.Point(551, 464);
            this.btStartGallery.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btStartGallery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btStartGallery.Name = "btStartGallery";
            this.btStartGallery.Primary = false;
            this.btStartGallery.Size = new System.Drawing.Size(66, 36);
            this.btStartGallery.TabIndex = 41;
            this.btStartGallery.Text = "START";
            this.btStartGallery.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 471);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 22);
            this.textBox3.TabIndex = 40;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(72, 469);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 24);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Barcode:";
            // 
            // btReturnGallery
            // 
            this.btReturnGallery.BackgroundImage = global::BarcodEZ_Software.Properties.Resources.mezza_bandiera;
            this.btReturnGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btReturnGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturnGallery.Location = new System.Drawing.Point(3, 4);
            this.btReturnGallery.Name = "btReturnGallery";
            this.btReturnGallery.Size = new System.Drawing.Size(135, 119);
            this.btReturnGallery.TabIndex = 42;
            this.btReturnGallery.UseVisualStyleBackColor = true;
            this.btReturnGallery.Click += new System.EventHandler(this.btReturnGallery_Click);
            // 
            // pictStart
            // 
            this.pictStart.Location = new System.Drawing.Point(28, 80);
            this.pictStart.Margin = new System.Windows.Forms.Padding(4);
            this.pictStart.Name = "pictStart";
            this.pictStart.Size = new System.Drawing.Size(576, 314);
            this.pictStart.TabIndex = 38;
            this.pictStart.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 314);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // BarcodEZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 589);
            this.Controls.Add(this.panelMenù);
            this.Controls.Add(this.panelGallery);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BarcodEZ";
            this.Text = "BarcodEZ";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelLive.ResumeLayout(false);
            this.panelLive.PerformLayout();
            this.panelMenù.ResumeLayout(false);
            this.panelMenù.PerformLayout();
            this.panelGallery.ResumeLayout(false);
            this.panelGallery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panelLive;
        private System.Windows.Forms.ComboBox cmbCamera;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel panelGallery;
        private MaterialSkin.Controls.MaterialFlatButton btStartGallery;
        private System.Windows.Forms.TextBox textBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panelMenù;
        private System.Windows.Forms.Label lbMenù;
        private MaterialSkin.Controls.MaterialFlatButton btStartLive;
        private System.Windows.Forms.TextBox txStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pictStart;
        private MaterialSkin.Controls.MaterialRaisedButton btLive;
        private MaterialSkin.Controls.MaterialRaisedButton btGallery;
        private System.Windows.Forms.Button btReturnGallery;
        private System.Windows.Forms.Button btReturnLive;
    }
}

