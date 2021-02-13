
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
            this.p = new System.Windows.Forms.TableLayoutPanel();
            this.pWebcam = new System.Windows.Forms.Panel();
            this.btStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.txBarcode = new System.Windows.Forms.TextBox();
            this.lbBarcode = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBarcodEZ = new System.Windows.Forms.PictureBox();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.lbPhoto = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.p.SuspendLayout();
            this.pWebcam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarcodEZ)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.p);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(913, 580);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // p
            // 
            this.p.ColumnCount = 2;
            this.p.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.p.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.p.Controls.Add(this.pWebcam, 0, 0);
            this.p.Location = new System.Drawing.Point(3, 3);
            this.p.Name = "p";
            this.p.RowCount = 2;
            this.p.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.2981F));
            this.p.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.70191F));
            this.p.Size = new System.Drawing.Size(901, 577);
            this.p.TabIndex = 1;
            // 
            // pWebcam
            // 
            this.pWebcam.Controls.Add(this.btStart);
            this.pWebcam.Controls.Add(this.txBarcode);
            this.pWebcam.Controls.Add(this.lbBarcode);
            this.pWebcam.Controls.Add(this.pictureBarcodEZ);
            this.pWebcam.Controls.Add(this.cmbCamera);
            this.pWebcam.Controls.Add(this.lbPhoto);
            this.pWebcam.Location = new System.Drawing.Point(3, 3);
            this.pWebcam.Name = "pWebcam";
            this.pWebcam.Size = new System.Drawing.Size(441, 364);
            this.pWebcam.TabIndex = 0;
            // 
            // btStart
            // 
            this.btStart.AutoSize = true;
            this.btStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btStart.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btStart.Depth = 0;
            this.btStart.Location = new System.Drawing.Point(368, 315);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btStart.Name = "btStart";
            this.btStart.Primary = false;
            this.btStart.Size = new System.Drawing.Size(55, 36);
            this.btStart.TabIndex = 29;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            // 
            // txBarcode
            // 
            this.txBarcode.Location = new System.Drawing.Point(123, 323);
            this.txBarcode.Name = "txBarcode";
            this.txBarcode.Size = new System.Drawing.Size(198, 20);
            this.txBarcode.TabIndex = 28;
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Depth = 0;
            this.lbBarcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBarcode.Location = new System.Drawing.Point(49, 323);
            this.lbBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(68, 19);
            this.lbBarcode.TabIndex = 27;
            this.lbBarcode.Text = "Barcode:";
            // 
            // pictureBarcodEZ
            // 
            this.pictureBarcodEZ.Location = new System.Drawing.Point(17, 58);
            this.pictureBarcodEZ.Name = "pictureBarcodEZ";
            this.pictureBarcodEZ.Size = new System.Drawing.Size(421, 255);
            this.pictureBarcodEZ.TabIndex = 26;
            this.pictureBarcodEZ.TabStop = false;
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Items.AddRange(new object[] {
            "Gallery",
            "Camera"});
            this.cmbCamera.Location = new System.Drawing.Point(123, 22);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(198, 21);
            this.cmbCamera.TabIndex = 25;
            // 
            // lbPhoto
            // 
            this.lbPhoto.AutoSize = true;
            this.lbPhoto.Depth = 0;
            this.lbPhoto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPhoto.Location = new System.Drawing.Point(38, 21);
            this.lbPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPhoto.Name = "lbPhoto";
            this.lbPhoto.Size = new System.Drawing.Size(65, 19);
            this.lbPhoto.TabIndex = 24;
            this.lbPhoto.Text = "Camera:";
            // 
            // BarcodEZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 650);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BarcodEZ";
            this.Text = "BarcodEZ";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.p.ResumeLayout(false);
            this.pWebcam.ResumeLayout(false);
            this.pWebcam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarcodEZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel p;
        private System.Windows.Forms.Panel pWebcam;
        private MaterialSkin.Controls.MaterialFlatButton btStart;
        private System.Windows.Forms.TextBox txBarcode;
        private MaterialSkin.Controls.MaterialLabel lbBarcode;
        private System.Windows.Forms.PictureBox pictureBarcodEZ;
        private System.Windows.Forms.ComboBox cmbCamera;
        private MaterialSkin.Controls.MaterialLabel lbPhoto;
    }
}

