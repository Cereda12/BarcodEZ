
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.txBarcode = new System.Windows.Forms.TextBox();
            this.lbBarcode = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.lbPhoto = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBarcodEZ = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarcodEZ)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 67);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btStart);
            this.tabPage1.Controls.Add(this.txBarcode);
            this.tabPage1.Controls.Add(this.lbBarcode);
            this.tabPage1.Controls.Add(this.pictureBarcodEZ);
            this.tabPage1.Controls.Add(this.cmbCamera);
            this.tabPage1.Controls.Add(this.lbPhoto);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(625, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btStart
            // 
            this.btStart.AutoSize = true;
            this.btStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btStart.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btStart.Depth = 0;
            this.btStart.Location = new System.Drawing.Point(488, 378);
            this.btStart.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btStart.Name = "btStart";
            this.btStart.Primary = false;
            this.btStart.Size = new System.Drawing.Size(66, 36);
            this.btStart.TabIndex = 35;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            // 
            // txBarcode
            // 
            this.txBarcode.Location = new System.Drawing.Point(161, 388);
            this.txBarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txBarcode.Name = "txBarcode";
            this.txBarcode.Size = new System.Drawing.Size(277, 22);
            this.txBarcode.TabIndex = 34;
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Depth = 0;
            this.lbBarcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBarcode.Location = new System.Drawing.Point(63, 388);
            this.lbBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(85, 24);
            this.lbBarcode.TabIndex = 33;
            this.lbBarcode.Text = "Barcode:";
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Items.AddRange(new object[] {
            "Gallery",
            "Camera"});
            this.cmbCamera.Location = new System.Drawing.Point(161, 17);
            this.cmbCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(277, 24);
            this.cmbCamera.TabIndex = 31;
            // 
            // lbPhoto
            // 
            this.lbPhoto.AutoSize = true;
            this.lbPhoto.Depth = 0;
            this.lbPhoto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPhoto.Location = new System.Drawing.Point(48, 16);
            this.lbPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPhoto.Name = "lbPhoto";
            this.lbPhoto.Size = new System.Drawing.Size(80, 24);
            this.lbPhoto.TabIndex = 30;
            this.lbPhoto.Text = "Camera:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(625, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBarcodEZ
            // 
            this.pictureBarcodEZ.Location = new System.Drawing.Point(20, 62);
            this.pictureBarcodEZ.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBarcodEZ.Name = "pictureBarcodEZ";
            this.pictureBarcodEZ.Size = new System.Drawing.Size(576, 314);
            this.pictureBarcodEZ.TabIndex = 32;
            this.pictureBarcodEZ.TabStop = false;
            // 
            // BarcodEZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 556);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BarcodEZ";
            this.Text = "BarcodEZ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarcodEZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialFlatButton btStart;
        private System.Windows.Forms.TextBox txBarcode;
        private MaterialSkin.Controls.MaterialLabel lbBarcode;
        private System.Windows.Forms.ComboBox cmbCamera;
        private MaterialSkin.Controls.MaterialLabel lbPhoto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBarcodEZ;
    }
}

