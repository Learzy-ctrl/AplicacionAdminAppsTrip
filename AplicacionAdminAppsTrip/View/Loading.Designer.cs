namespace AplicacionAdminAppsTrip.View
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Loadingimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Loadingimg)).BeginInit();
            this.SuspendLayout();
            // 
            // Loadingimg
            // 
            this.Loadingimg.Image = global::AplicacionAdminAppsTrip.Properties.Resources.loading;
            this.Loadingimg.Location = new System.Drawing.Point(44, 12);
            this.Loadingimg.Name = "Loadingimg";
            this.Loadingimg.Size = new System.Drawing.Size(127, 117);
            this.Loadingimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loadingimg.TabIndex = 0;
            this.Loadingimg.TabStop = false;
            this.Loadingimg.Click += new System.EventHandler(this.Loadingimg_Click);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(208, 147);
            this.Controls.Add(this.Loadingimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)(this.Loadingimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Loadingimg;
    }
}