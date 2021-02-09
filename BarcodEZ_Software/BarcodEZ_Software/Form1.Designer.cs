
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
            this.lbPhoto = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.pictureBarcodEZ = new System.Windows.Forms.PictureBox();
            this.lbBarcode = new MaterialSkin.Controls.MaterialLabel();
            this.txBarcode = new System.Windows.Forms.TextBox();
            this.btStart = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarcodEZ)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPhoto
            // 
            this.lbPhoto.AutoSize = true;
            this.lbPhoto.Depth = 0;
            this.lbPhoto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPhoto.Location = new System.Drawing.Point(57, 73);
            this.lbPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPhoto.Name = "lbPhoto";
            this.lbPhoto.Size = new System.Drawing.Size(53, 19);
            this.lbPhoto.TabIndex = 0;
            this.lbPhoto.Text = "Photo:";
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Items.AddRange(new object[] {
            "Gallery",
            "Camera"});
            this.cmbCamera.Location = new System.Drawing.Point(153, 71);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(198, 21);
            this.cmbCamera.TabIndex = 1;
            // 
            // pictureBarcodEZ
            // 
            this.pictureBarcodEZ.Location = new System.Drawing.Point(13, 108);
            this.pictureBarcodEZ.Name = "pictureBarcodEZ";
            this.pictureBarcodEZ.Size = new System.Drawing.Size(421, 255);
            this.pictureBarcodEZ.TabIndex = 2;
            this.pictureBarcodEZ.TabStop = false;
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Depth = 0;
            this.lbBarcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBarcode.Location = new System.Drawing.Point(38, 383);
            this.lbBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(68, 19);
            this.lbBarcode.TabIndex = 3;
            this.lbBarcode.Text = "Barcode:";
            // 
            // txBarcode
            // 
            this.txBarcode.Location = new System.Drawing.Point(134, 381);
            this.txBarcode.Name = "txBarcode";
            this.txBarcode.Size = new System.Drawing.Size(198, 20);
            this.txBarcode.TabIndex = 4;
            // 
            // btStart
            // 
            this.btStart.AutoSize = true;
            this.btStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btStart.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btStart.Depth = 0;
            this.btStart.Location = new System.Drawing.Point(363, 372);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btStart.Name = "btStart";
            this.btStart.Primary = false;
            this.btStart.Size = new System.Drawing.Size(55, 36);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            // 
            // BarcodEZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 423);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.txBarcode);
            this.Controls.Add(this.lbBarcode);
            this.Controls.Add(this.pictureBarcodEZ);
            this.Controls.Add(this.cmbCamera);
            this.Controls.Add(this.lbPhoto);
            this.Name = "BarcodEZ";
            this.Text = "BarcodEZ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarcodEZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbPhoto;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.PictureBox pictureBarcodEZ;
        private MaterialSkin.Controls.MaterialLabel lbBarcode;
        private System.Windows.Forms.TextBox txBarcode;
        private MaterialSkin.Controls.MaterialFlatButton btStart;
    }
}

