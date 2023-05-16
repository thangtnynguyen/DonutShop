
namespace DonutShop2
{
    partial class fHome
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
            this.plcontrol = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.plmenu = new System.Windows.Forms.Panel();
            this.btnaccount = new System.Windows.Forms.Button();
            this.btnIngredient = new System.Windows.Forms.Button();
            this.btnstatistical = new System.Windows.Forms.Button();
            this.btndetail = new System.Windows.Forms.Button();
            this.btngiohang = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnvattu = new System.Windows.Forms.Button();
            this.btnDonut = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.plactive = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.plcontrol.SuspendLayout();
            this.plmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // plcontrol
            // 
            this.plcontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.plcontrol.Controls.Add(this.title);
            this.plcontrol.Controls.Add(this.btnMin);
            this.plcontrol.Controls.Add(this.btnMax);
            this.plcontrol.Controls.Add(this.btnClose);
            this.plcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.plcontrol.Location = new System.Drawing.Point(0, 0);
            this.plcontrol.Name = "plcontrol";
            this.plcontrol.Size = new System.Drawing.Size(1100, 50);
            this.plcontrol.TabIndex = 0;
            this.plcontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plcontrol_MouseDown);
            this.plcontrol.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plcontrol_MouseMove);
            this.plcontrol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plcontrol_MouseUp);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(26, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 37);
            this.title.TabIndex = 7;
            this.title.Text = "Donut Shop";
            // 
            // plmenu
            // 
            this.plmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.plmenu.Controls.Add(this.btnaccount);
            this.plmenu.Controls.Add(this.btnIngredient);
            this.plmenu.Controls.Add(this.btnstatistical);
            this.plmenu.Controls.Add(this.btndetail);
            this.plmenu.Controls.Add(this.btngiohang);
            this.plmenu.Controls.Add(this.btnHoadon);
            this.plmenu.Controls.Add(this.btnvattu);
            this.plmenu.Controls.Add(this.btnDonut);
            this.plmenu.Controls.Add(this.btnHome);
            this.plmenu.Controls.Add(this.pbLogo);
            this.plmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plmenu.Location = new System.Drawing.Point(0, 50);
            this.plmenu.Name = "plmenu";
            this.plmenu.Size = new System.Drawing.Size(200, 650);
            this.plmenu.TabIndex = 1;
            // 
            // btnaccount
            // 
            this.btnaccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnaccount.FlatAppearance.BorderSize = 0;
            this.btnaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccount.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccount.ForeColor = System.Drawing.Color.White;
            this.btnaccount.Location = new System.Drawing.Point(0, 518);
            this.btnaccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnaccount.Name = "btnaccount";
            this.btnaccount.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnaccount.Size = new System.Drawing.Size(200, 52);
            this.btnaccount.TabIndex = 19;
            this.btnaccount.Text = "Account";
            this.btnaccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaccount.UseVisualStyleBackColor = true;
            this.btnaccount.Click += new System.EventHandler(this.btnaccount_Click);
            // 
            // btnIngredient
            // 
            this.btnIngredient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngredient.FlatAppearance.BorderSize = 0;
            this.btnIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngredient.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredient.ForeColor = System.Drawing.Color.White;
            this.btnIngredient.Location = new System.Drawing.Point(0, 466);
            this.btnIngredient.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngredient.Name = "btnIngredient";
            this.btnIngredient.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnIngredient.Size = new System.Drawing.Size(200, 52);
            this.btnIngredient.TabIndex = 18;
            this.btnIngredient.Text = "Ingredient";
            this.btnIngredient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngredient.UseVisualStyleBackColor = true;
            this.btnIngredient.Visible = false;
            this.btnIngredient.Click += new System.EventHandler(this.btnIngredient_Click);
            // 
            // btnstatistical
            // 
            this.btnstatistical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnstatistical.FlatAppearance.BorderSize = 0;
            this.btnstatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstatistical.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstatistical.ForeColor = System.Drawing.Color.White;
            this.btnstatistical.Location = new System.Drawing.Point(0, 414);
            this.btnstatistical.Margin = new System.Windows.Forms.Padding(0);
            this.btnstatistical.Name = "btnstatistical";
            this.btnstatistical.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnstatistical.Size = new System.Drawing.Size(200, 52);
            this.btnstatistical.TabIndex = 17;
            this.btnstatistical.Text = "Statistical";
            this.btnstatistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstatistical.UseVisualStyleBackColor = true;
            this.btnstatistical.Visible = false;
            this.btnstatistical.Click += new System.EventHandler(this.btnstatistical_Click);
            // 
            // btndetail
            // 
            this.btndetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndetail.FlatAppearance.BorderSize = 0;
            this.btndetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetail.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetail.ForeColor = System.Drawing.Color.White;
            this.btndetail.Location = new System.Drawing.Point(0, 362);
            this.btndetail.Margin = new System.Windows.Forms.Padding(0);
            this.btndetail.Name = "btndetail";
            this.btndetail.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btndetail.Size = new System.Drawing.Size(200, 52);
            this.btndetail.TabIndex = 16;
            this.btndetail.Text = "Details";
            this.btndetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndetail.UseVisualStyleBackColor = true;
            this.btndetail.Visible = false;
            this.btndetail.Click += new System.EventHandler(this.btndetail_Click);
            // 
            // btngiohang
            // 
            this.btngiohang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngiohang.FlatAppearance.BorderSize = 0;
            this.btngiohang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiohang.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiohang.ForeColor = System.Drawing.Color.White;
            this.btngiohang.Location = new System.Drawing.Point(0, 310);
            this.btngiohang.Margin = new System.Windows.Forms.Padding(0);
            this.btngiohang.Name = "btngiohang";
            this.btngiohang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btngiohang.Size = new System.Drawing.Size(200, 52);
            this.btngiohang.TabIndex = 15;
            this.btngiohang.Text = "Cart";
            this.btngiohang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiohang.UseVisualStyleBackColor = true;
            this.btngiohang.Click += new System.EventHandler(this.btngiohang_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoadon.FlatAppearance.BorderSize = 0;
            this.btnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadon.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.ForeColor = System.Drawing.Color.White;
            this.btnHoadon.Location = new System.Drawing.Point(0, 258);
            this.btnHoadon.Margin = new System.Windows.Forms.Padding(0);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHoadon.Size = new System.Drawing.Size(200, 52);
            this.btnHoadon.TabIndex = 14;
            this.btnHoadon.Text = "Bill";
            this.btnHoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadon.UseVisualStyleBackColor = true;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnvattu
            // 
            this.btnvattu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvattu.FlatAppearance.BorderSize = 0;
            this.btnvattu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvattu.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvattu.ForeColor = System.Drawing.Color.White;
            this.btnvattu.Location = new System.Drawing.Point(0, 206);
            this.btnvattu.Margin = new System.Windows.Forms.Padding(0);
            this.btnvattu.Name = "btnvattu";
            this.btnvattu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnvattu.Size = new System.Drawing.Size(200, 52);
            this.btnvattu.TabIndex = 12;
            this.btnvattu.Text = "Supplies";
            this.btnvattu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvattu.UseVisualStyleBackColor = true;
            this.btnvattu.Click += new System.EventHandler(this.btnvattu_Click);
            // 
            // btnDonut
            // 
            this.btnDonut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonut.FlatAppearance.BorderSize = 0;
            this.btnDonut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonut.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonut.ForeColor = System.Drawing.Color.White;
            this.btnDonut.Location = new System.Drawing.Point(0, 154);
            this.btnDonut.Margin = new System.Windows.Forms.Padding(0);
            this.btnDonut.Name = "btnDonut";
            this.btnDonut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDonut.Size = new System.Drawing.Size(200, 52);
            this.btnDonut.TabIndex = 11;
            this.btnDonut.Text = "Donut";
            this.btnDonut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonut.UseVisualStyleBackColor = true;
            this.btnDonut.Click += new System.EventHandler(this.btnDonut_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 102);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 52);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // plactive
            // 
            this.plactive.BackgroundImage = global::DonutShop2.Properties.Resources.R__1_;
            this.plactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plactive.Location = new System.Drawing.Point(200, 50);
            this.plactive.Name = "plactive";
            this.plactive.Size = new System.Drawing.Size(900, 650);
            this.plactive.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::DonutShop2.Properties.Resources.logo_design;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 102);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::DonutShop2.Properties.Resources.minimize__1_;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.Location = new System.Drawing.Point(908, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(64, 50);
            this.btnMin.TabIndex = 6;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::DonutShop2.Properties.Resources.maximize__1_;
            this.btnMax.Location = new System.Drawing.Point(972, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(64, 50);
            this.btnMax.TabIndex = 5;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DonutShop2.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1036, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.plactive);
            this.Controls.Add(this.plmenu);
            this.Controls.Add(this.plcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fHome_Load);
            this.plcontrol.ResumeLayout(false);
            this.plcontrol.PerformLayout();
            this.plmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plcontrol;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel plmenu;
        private System.Windows.Forms.Panel plactive;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnIngredient;
        private System.Windows.Forms.Button btnstatistical;
        private System.Windows.Forms.Button btndetail;
        private System.Windows.Forms.Button btngiohang;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnvattu;
        private System.Windows.Forms.Button btnDonut;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnaccount;
    }
}

