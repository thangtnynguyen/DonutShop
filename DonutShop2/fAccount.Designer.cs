
namespace DonutShop2
{
    partial class fAccount
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
            this.plset = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpasswork = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtper = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvaccount = new System.Windows.Forms.DataGridView();
            this.plform = new System.Windows.Forms.Panel();
            this.btnSee = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccount)).BeginInit();
            this.plform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plset
            // 
            this.plset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plset.Controls.Add(this.txtid);
            this.plset.Controls.Add(this.txtpasswork);
            this.plset.Controls.Add(this.btndelete);
            this.plset.Controls.Add(this.txtper);
            this.plset.Controls.Add(this.btnupdate);
            this.plset.Controls.Add(this.txtname);
            this.plset.Location = new System.Drawing.Point(648, 50);
            this.plset.Name = "plset";
            this.plset.Size = new System.Drawing.Size(240, 306);
            this.plset.TabIndex = 48;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(15, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(210, 22);
            this.txtid.TabIndex = 37;
            this.txtid.Text = "Id";
            // 
            // txtpasswork
            // 
            this.txtpasswork.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtpasswork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpasswork.Enabled = false;
            this.txtpasswork.Location = new System.Drawing.Point(15, 75);
            this.txtpasswork.Name = "txtpasswork";
            this.txtpasswork.Size = new System.Drawing.Size(210, 22);
            this.txtpasswork.TabIndex = 35;
            this.txtpasswork.Text = "Pass";
            // 
            // btndelete
            // 
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btndelete.FlatAppearance.BorderSize = 2;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Blue;
            this.btndelete.Image = global::DonutShop2.Properties.Resources.delete;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(26, 189);
            this.btndelete.Name = "btndelete";
            this.btndelete.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btndelete.Size = new System.Drawing.Size(184, 52);
            this.btndelete.TabIndex = 39;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtper
            // 
            this.txtper.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtper.Location = new System.Drawing.Point(15, 103);
            this.txtper.Name = "txtper";
            this.txtper.Size = new System.Drawing.Size(210, 22);
            this.txtper.TabIndex = 36;
            this.txtper.Text = "Per";
            this.txtper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtper_KeyPress);
            // 
            // btnupdate
            // 
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnupdate.FlatAppearance.BorderSize = 2;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Image = global::DonutShop2.Properties.Resources.changes;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(26, 131);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnupdate.Size = new System.Drawing.Size(184, 52);
            this.btnupdate.TabIndex = 38;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(15, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(210, 22);
            this.txtname.TabIndex = 34;
            this.txtname.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name :";
            // 
            // txtidname
            // 
            this.txtidname.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtidname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidname.ForeColor = System.Drawing.Color.Salmon;
            this.txtidname.Location = new System.Drawing.Point(124, 42);
            this.txtidname.Name = "txtidname";
            this.txtidname.Size = new System.Drawing.Size(239, 15);
            this.txtidname.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password :";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.ForeColor = System.Drawing.Color.Salmon;
            this.txtpass.Location = new System.Drawing.Point(120, 79);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(239, 15);
            this.txtpass.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(119, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "____________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 37);
            this.label5.TabIndex = 47;
            this.label5.Text = "*Click logo to reload !!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(115, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "____________________________";
            // 
            // dgvaccount
            // 
            this.dgvaccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvaccount.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaccount.Location = new System.Drawing.Point(10, 12);
            this.dgvaccount.Name = "dgvaccount";
            this.dgvaccount.RowHeadersWidth = 51;
            this.dgvaccount.RowTemplate.Height = 24;
            this.dgvaccount.Size = new System.Drawing.Size(632, 371);
            this.dgvaccount.TabIndex = 49;
            this.dgvaccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvaccount_CellClick);
            // 
            // plform
            // 
            this.plform.Controls.Add(this.txtpass);
            this.plform.Controls.Add(this.label2);
            this.plform.Controls.Add(this.txtidname);
            this.plform.Controls.Add(this.label3);
            this.plform.Controls.Add(this.btnSee);
            this.plform.Controls.Add(this.label4);
            this.plform.Controls.Add(this.btnHide);
            this.plform.Controls.Add(this.label1);
            this.plform.Location = new System.Drawing.Point(231, 239);
            this.plform.Name = "plform";
            this.plform.Size = new System.Drawing.Size(411, 125);
            this.plform.TabIndex = 46;
            // 
            // btnSee
            // 
            this.btnSee.BackColor = System.Drawing.Color.Transparent;
            this.btnSee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSee.FlatAppearance.BorderSize = 0;
            this.btnSee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSee.Image = global::DonutShop2.Properties.Resources.visible1;
            this.btnSee.Location = new System.Drawing.Point(357, 79);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(22, 22);
            this.btnSee.TabIndex = 23;
            this.btnSee.UseVisualStyleBackColor = false;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = global::DonutShop2.Properties.Resources.eye;
            this.btnHide.Location = new System.Drawing.Point(357, 79);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(22, 22);
            this.btnHide.TabIndex = 22;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogout.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnlogout.FlatAppearance.BorderSize = 2;
            this.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Blue;
            this.btnlogout.Image = global::DonutShop2.Properties.Resources.exit;
            this.btnlogout.Location = new System.Drawing.Point(703, 556);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnlogout.Size = new System.Drawing.Size(185, 51);
            this.btnlogout.TabIndex = 45;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Visible = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnsignup
            // 
            this.btnsignup.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnsignup.FlatAppearance.BorderSize = 2;
            this.btnsignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignup.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.Blue;
            this.btnsignup.Image = global::DonutShop2.Properties.Resources.signup;
            this.btnsignup.Location = new System.Drawing.Point(255, 487);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnsignup.Size = new System.Drawing.Size(336, 51);
            this.btnsignup.TabIndex = 44;
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnlogin.FlatAppearance.BorderSize = 2;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Blue;
            this.btnlogin.Image = global::DonutShop2.Properties.Resources.log_in;
            this.btnlogin.Location = new System.Drawing.Point(255, 430);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnlogin.Size = new System.Drawing.Size(336, 51);
            this.btnlogin.TabIndex = 43;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::DonutShop2.Properties.Resources.logo_design;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(324, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.plset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.dgvaccount);
            this.Controls.Add(this.plform);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAccount";
            this.Text = "fAccount";
            this.plset.ResumeLayout(false);
            this.plset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccount)).EndInit();
            this.plform.ResumeLayout(false);
            this.plform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plset;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpasswork;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtper;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvaccount;
        private System.Windows.Forms.Panel plform;
    }
}