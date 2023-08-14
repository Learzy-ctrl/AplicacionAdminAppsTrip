namespace AplicacionAdminAppsTrip.View.TripAssignment
{
    partial class TravelDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelDetail));
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCancelled = new System.Windows.Forms.Button();
            this.txtPayWay = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.btnSendAssignament = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoadingGif = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPointOfOrigin = new System.Windows.Forms.TextBox();
            this.txtDatetime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTravelTo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnCancelled);
            this.panel3.Controls.Add(this.txtPayWay);
            this.panel3.Controls.Add(this.txtOperator);
            this.panel3.Controls.Add(this.btnSendAssignament);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(469, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 237);
            this.panel3.TabIndex = 7;
            // 
            // BtnCancelled
            // 
            this.BtnCancelled.Location = new System.Drawing.Point(37, 197);
            this.BtnCancelled.Name = "BtnCancelled";
            this.BtnCancelled.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelled.TabIndex = 15;
            this.BtnCancelled.Text = "Cancelar";
            this.BtnCancelled.UseVisualStyleBackColor = true;
            this.BtnCancelled.Click += new System.EventHandler(this.BtnCancelled_Click);
            // 
            // txtPayWay
            // 
            this.txtPayWay.Location = new System.Drawing.Point(46, 98);
            this.txtPayWay.Name = "txtPayWay";
            this.txtPayWay.ReadOnly = true;
            this.txtPayWay.Size = new System.Drawing.Size(121, 20);
            this.txtPayWay.TabIndex = 14;
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(46, 34);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.ReadOnly = true;
            this.txtOperator.Size = new System.Drawing.Size(121, 20);
            this.txtOperator.TabIndex = 13;
            // 
            // btnSendAssignament
            // 
            this.btnSendAssignament.Location = new System.Drawing.Point(118, 197);
            this.btnSendAssignament.Name = "btnSendAssignament";
            this.btnSendAssignament.Size = new System.Drawing.Size(75, 23);
            this.btnSendAssignament.TabIndex = 12;
            this.btnSendAssignament.Text = "Reenviar";
            this.btnSendAssignament.UseVisualStyleBackColor = true;
            this.btnSendAssignament.Click += new System.EventHandler(this.btnSendAssignament_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total a recibir:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(46, 152);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Metodo de pago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Operador: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LoadingGif);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPhoneNumber);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtPointOfOrigin);
            this.panel2.Controls.Add(this.txtDatetime);
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.txtTravelTo);
            this.panel2.Location = new System.Drawing.Point(27, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 237);
            this.panel2.TabIndex = 6;
            // 
            // LoadingGif
            // 
            this.LoadingGif.Image = global::AplicacionAdminAppsTrip.Properties.Resources.loading;
            this.LoadingGif.Location = new System.Drawing.Point(286, 57);
            this.LoadingGif.Margin = new System.Windows.Forms.Padding(2);
            this.LoadingGif.Name = "LoadingGif";
            this.LoadingGif.Size = new System.Drawing.Size(73, 80);
            this.LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingGif.TabIndex = 36;
            this.LoadingGif.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Numero celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre del usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Punto de origen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Viaje a:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(195, 168);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(175, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 98);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtPointOfOrigin
            // 
            this.txtPointOfOrigin.Location = new System.Drawing.Point(195, 34);
            this.txtPointOfOrigin.Name = "txtPointOfOrigin";
            this.txtPointOfOrigin.ReadOnly = true;
            this.txtPointOfOrigin.Size = new System.Drawing.Size(175, 20);
            this.txtPointOfOrigin.TabIndex = 3;
            // 
            // txtDatetime
            // 
            this.txtDatetime.Location = new System.Drawing.Point(25, 168);
            this.txtDatetime.Name = "txtDatetime";
            this.txtDatetime.ReadOnly = true;
            this.txtDatetime.Size = new System.Drawing.Size(114, 20);
            this.txtDatetime.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(25, 98);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(114, 20);
            this.txtDate.TabIndex = 1;
            // 
            // txtTravelTo
            // 
            this.txtTravelTo.Location = new System.Drawing.Point(25, 34);
            this.txtTravelTo.Name = "txtTravelTo";
            this.txtTravelTo.ReadOnly = true;
            this.txtTravelTo.Size = new System.Drawing.Size(150, 20);
            this.txtTravelTo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 68);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(198, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detelle de asignacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asignaciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacionAdminAppsTrip.Properties.Resources.LOGOTRIP;
            this.pictureBox1.Location = new System.Drawing.Point(601, -12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TravelDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 335);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TravelDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle asignacion";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSendAssignament;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox LoadingGif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPointOfOrigin;
        private System.Windows.Forms.TextBox txtDatetime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTravelTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPayWay;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Button BtnCancelled;
    }
}