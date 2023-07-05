namespace AplicacionAdminAppsTrip.View.Sales
{
    partial class DeclinedServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LoadingGif = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(218, 74);
            this.Refreshbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(85, 28);
            this.Refreshbtn.TabIndex = 16;
            this.Refreshbtn.Text = "Refrescar";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(34, 74);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(148, 28);
            this.Backbtn.TabIndex = 14;
            this.Backbtn.Text = "Regresar";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.userID,
            this.StartTrip,
            this.DateTime,
            this.Date,
            this.Detail});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 70;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 551);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.MinimumWidth = 6;
            this.Key.Name = "Key";
            this.Key.Visible = false;
            this.Key.Width = 125;
            // 
            // userID
            // 
            this.userID.HeaderText = "id";
            this.userID.MinimumWidth = 6;
            this.userID.Name = "userID";
            this.userID.Visible = false;
            this.userID.Width = 125;
            // 
            // StartTrip
            // 
            this.StartTrip.HeaderText = "Viaje a:";
            this.StartTrip.MinimumWidth = 6;
            this.StartTrip.Name = "StartTrip";
            this.StartTrip.Width = 245;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Fecha Cotizacion";
            this.DateTime.MinimumWidth = 6;
            this.DateTime.Name = "DateTime";
            this.DateTime.Width = 245;
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha Rechazo";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 245;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detalle";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.Width = 65;
            // 
            // LoadingGif
            // 
            this.LoadingGif.Image = global::AplicacionAdminAppsTrip.Properties.Resources.loading;
            this.LoadingGif.Location = new System.Drawing.Point(509, 185);
            this.LoadingGif.Name = "LoadingGif";
            this.LoadingGif.Size = new System.Drawing.Size(97, 99);
            this.LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingGif.TabIndex = 35;
            this.LoadingGif.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LoadingGif);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(35, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 553);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(104)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.Refreshbtn);
            this.panel3.Controls.Add(this.Backbtn);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 127);
            this.panel3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(160, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Viajes Rechazados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(27, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ventas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AplicacionAdminAppsTrip.Properties.Resources.LOGOTRIP;
            this.pictureBox2.Location = new System.Drawing.Point(1044, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // DeclinedServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 696);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeclinedServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeclinedServices";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeclinedServices_FormClosed);
            this.Load += new System.EventHandler(this.DeclinedServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox LoadingGif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}