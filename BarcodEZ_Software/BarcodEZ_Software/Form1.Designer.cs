
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
            this.pictureBarcodEZ = new System.Windows.Forms.PictureBox();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.lbPhoto = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarcodEZ)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 380);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(464, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btStart
            // 
            this.btStart.AutoSize = true;
            this.btStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btStart.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btStart.Depth = 0;
            this.btStart.Location = new System.Drawing.Point(366, 307);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btStart.Name = "btStart";
            this.btStart.Primary = false;
            this.btStart.Size = new System.Drawing.Size(55, 36);
            this.btStart.TabIndex = 35;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            // 
            // txBarcode
            // 
            this.txBarcode.Location = new System.Drawing.Point(121, 315);
            this.txBarcode.Name = "txBarcode";
            this.txBarcode.Size = new System.Drawing.Size(209, 20);
            this.txBarcode.TabIndex = 34;
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Depth = 0;
            this.lbBarcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBarcode.Location = new System.Drawing.Point(47, 315);
            this.lbBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(68, 19);
            this.lbBarcode.TabIndex = 33;
            this.lbBarcode.Text = "Barcode:";
            // 
            // pictureBarcodEZ
            // 
            this.pictureBarcodEZ.Location = new System.Drawing.Point(15, 50);
            this.pictureBarcodEZ.Name = "pictureBarcodEZ";
            this.pictureBarcodEZ.Size = new System.Drawing.Size(432, 255);
            this.pictureBarcodEZ.TabIndex = 32;
            this.pictureBarcodEZ.TabStop = false;
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Items.AddRange(new object[] {
            "Gallery",
            "Camera"});
            this.cmbCamera.Location = new System.Drawing.Point(121, 14);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(209, 21);
            this.cmbCamera.TabIndex = 31;
            // 
            // lbPhoto
            // 
            this.lbPhoto.AutoSize = true;
            this.lbPhoto.Depth = 0;
            this.lbPhoto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPhoto.Location = new System.Drawing.Point(36, 13);
            this.lbPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPhoto.Name = "lbPhoto";
            this.lbPhoto.Size = new System.Drawing.Size(65, 19);
            this.lbPhoto.TabIndex = 30;
            this.lbPhoto.Text = "Camera:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(464, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BarcodEZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 452);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.PictureBox pictureBarcodEZ;
        private System.Windows.Forms.ComboBox cmbCamera;
        private MaterialSkin.Controls.MaterialLabel lbPhoto;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

