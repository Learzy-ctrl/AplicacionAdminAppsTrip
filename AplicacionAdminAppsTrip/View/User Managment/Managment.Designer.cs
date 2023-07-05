namespace AplicacionAdminAppsTrip.View.User_Managment
{
    partial class Managment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.txtConsultation = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.CBMain = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadingGif = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LoadingGif);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CBRol);
            this.panel2.Controls.Add(this.txtConsultation);
            this.panel2.Controls.Add(this.btnCreateUser);
            this.panel2.Controls.Add(this.CBMain);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.txtCount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(36, 156);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 654);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Buscar por:";
            // 
            // CBRol
            // 
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(292, 14);
            this.CBRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(160, 24);
            this.CBRol.TabIndex = 10;
            this.CBRol.SelectedIndexChanged += new System.EventHandler(this.CBRol_SelectedIndexChanged);
            // 
            // txtConsultation
            // 
            this.txtConsultation.Location = new System.Drawing.Point(292, 14);
            this.txtConsultation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsultation.Name = "txtConsultation";
            this.txtConsultation.Size = new System.Drawing.Size(184, 22);
            this.txtConsultation.TabIndex = 9;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(1207, 11);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(87, 28);
            this.btnCreateUser.TabIndex = 8;
            this.btnCreateUser.Text = "Nuevo";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // CBMain
            // 
            this.CBMain.FormattingEnabled = true;
            this.CBMain.Location = new System.Drawing.Point(109, 14);
            this.CBMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBMain.Name = "CBMain";
            this.CBMain.Size = new System.Drawing.Size(160, 24);
            this.CBMain.TabIndex = 7;
            this.CBMain.SelectedIndexChanged += new System.EventHandler(this.CBMain_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(503, 11);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Buscar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(561, 604);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(19, 20);
            this.txtCount.TabIndex = 5;
            this.txtCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 604);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registros Encontrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userKey,
            this.Names,
            this.LastName,
            this.Rol,
            this.PhoneNumber,
            this.Email,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1332, 537);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Configuracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(275, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Usuarios";
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Location = new System.Drawing.Point(39, 76);
            this.BackToMenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(84, 28);
            this.BackToMenuBtn.TabIndex = 9;
            this.BackToMenuBtn.Text = "Menu 🛖";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BackToMenuBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 127);
            this.panel1.TabIndex = 12;
            // 
            // userKey
            // 
            this.userKey.HeaderText = "userKey";
            this.userKey.MinimumWidth = 6;
            this.userKey.Name = "userKey";
            this.userKey.Visible = false;
            this.userKey.Width = 125;
            // 
            // Names
            // 
            this.Names.HeaderText = "Nombre";
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.Width = 170;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Apellidos";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 165;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.Width = 170;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Numero Celular";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 160;
            // 
            // Email
            // 
            this.Email.HeaderText = "Correo Electronico";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 230;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Borrar";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacionAdminAppsTrip.Properties.Resources.LOGOTRIP;
            this.pictureBox1.Location = new System.Drawing.Point(1296, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingGif
            // 
            this.LoadingGif.Image = global::AplicacionAdminAppsTrip.Properties.Resources.loading;
            this.LoadingGif.Location = new System.Drawing.Point(592, 222);
            this.LoadingGif.Name = "LoadingGif";
            this.LoadingGif.Size = new System.Drawing.Size(97, 99);
            this.LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingGif.TabIndex = 18;
            this.LoadingGif.TabStop = false;
            // 
            // Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1423, 842);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Managment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Managment_FormClosed);
            this.Load += new System.EventHandler(this.Managment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBMain;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.TextBox txtConsultation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackToMenuBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn userKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.PictureBox LoadingGif;
    }
}