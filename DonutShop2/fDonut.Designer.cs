
namespace DonutShop2
{
    partial class fDonut
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
            this.btnupnumber = new System.Windows.Forms.Button();
            this.txtnumberad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plmanage = new System.Windows.Forms.Panel();
            this.pbview = new System.Windows.Forms.PictureBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.plBuy = new System.Windows.Forms.Panel();
            this.btnaddcart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flpDonutview = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.plmanage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbview)).BeginInit();
            this.plBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnupnumber
            // 
            this.btnupnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnupnumber.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnupnumber.FlatAppearance.BorderSize = 2;
            this.btnupnumber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnupnumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupnumber.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupnumber.ForeColor = System.Drawing.Color.Blue;
            this.btnupnumber.Image = global::DonutShop2.Properties.Resources.changes;
            this.btnupnumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupnumber.Location = new System.Drawing.Point(27, 381);
            this.btnupnumber.Name = "btnupnumber";
            this.btnupnumber.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnupnumber.Size = new System.Drawing.Size(232, 42);
            this.btnupnumber.TabIndex = 17;
            this.btnupnumber.Text = "Update Number";
            this.btnupnumber.UseVisualStyleBackColor = true;
            this.btnupnumber.Click += new System.EventHandler(this.btnupnumber_Click);
            // 
            // txtnumberad
            // 
            this.txtnumberad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtnumberad.BackColor = System.Drawing.SystemColors.Control;
            this.txtnumberad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumberad.Location = new System.Drawing.Point(97, 160);
            this.txtnumberad.Name = "txtnumberad";
            this.txtnumberad.Size = new System.Drawing.Size(189, 22);
            this.txtnumberad.TabIndex = 16;
            this.txtnumberad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number :";
            // 
            // txtprice
            // 
            this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtprice.BackColor = System.Drawing.SystemColors.Control;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Location = new System.Drawing.Point(97, 132);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(189, 22);
            this.txtprice.TabIndex = 9;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price :";
            // 
            // txtnamead
            // 
            this.txtnamead.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtnamead.BackColor = System.Drawing.SystemColors.Control;
            this.txtnamead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnamead.Location = new System.Drawing.Point(97, 26);
            this.txtnamead.Name = "txtnamead";
            this.txtnamead.Size = new System.Drawing.Size(189, 22);
            this.txtnamead.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Image :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name :";
            // 
            // txtnumber
            // 
            this.txtnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtnumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumber.Location = new System.Drawing.Point(97, 65);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(189, 22);
            this.txtnumber.TabIndex = 3;
            this.txtnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtname.BackColor = System.Drawing.SystemColors.Control;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(97, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(189, 22);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number :";
            // 
            // plmanage
            // 
            this.plmanage.Controls.Add(this.pbview);
            this.plmanage.Controls.Add(this.btnupnumber);
            this.plmanage.Controls.Add(this.txtnumberad);
            this.plmanage.Controls.Add(this.label6);
            this.plmanage.Controls.Add(this.btnBrower);
            this.plmanage.Controls.Add(this.btnfilter);
            this.plmanage.Controls.Add(this.btndel);
            this.plmanage.Controls.Add(this.btnupdate);
            this.plmanage.Controls.Add(this.btnadd);
            this.plmanage.Controls.Add(this.txtprice);
            this.plmanage.Controls.Add(this.label5);
            this.plmanage.Controls.Add(this.txtnamead);
            this.plmanage.Controls.Add(this.label3);
            this.plmanage.Controls.Add(this.label4);
            this.plmanage.Dock = System.Windows.Forms.DockStyle.Top;
            this.plmanage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plmanage.Location = new System.Drawing.Point(610, 200);
            this.plmanage.Name = "plmanage";
            this.plmanage.Size = new System.Drawing.Size(290, 450);
            this.plmanage.TabIndex = 5;
            // 
            // pbview
            // 
            this.pbview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbview.Location = new System.Drawing.Point(106, 54);
            this.pbview.Name = "pbview";
            this.pbview.Size = new System.Drawing.Size(64, 64);
            this.pbview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbview.TabIndex = 18;
            this.pbview.TabStop = false;
            // 
            // btnBrower
            // 
            this.btnBrower.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrower.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrower.FlatAppearance.BorderSize = 0;
            this.btnBrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrower.Image = global::DonutShop2.Properties.Resources.upload;
            this.btnBrower.Location = new System.Drawing.Point(213, 80);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(26, 24);
            this.btnBrower.TabIndex = 14;
            this.btnBrower.UseVisualStyleBackColor = false;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnfilter.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnfilter.FlatAppearance.BorderSize = 2;
            this.btnfilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilter.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.ForeColor = System.Drawing.Color.Blue;
            this.btnfilter.Image = global::DonutShop2.Properties.Resources.filter;
            this.btnfilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfilter.Location = new System.Drawing.Point(27, 333);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnfilter.Size = new System.Drawing.Size(232, 42);
            this.btnfilter.TabIndex = 13;
            this.btnfilter.Text = "Filter Donut";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // btndel
            // 
            this.btndel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btndel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btndel.FlatAppearance.BorderSize = 2;
            this.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.Blue;
            this.btndel.Image = global::DonutShop2.Properties.Resources.delete;
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(27, 285);
            this.btndel.Name = "btndel";
            this.btndel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btndel.Size = new System.Drawing.Size(232, 42);
            this.btndel.TabIndex = 12;
            this.btndel.Text = "Delete Donut";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnupdate.FlatAppearance.BorderSize = 2;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Image = global::DonutShop2.Properties.Resources.changes;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(27, 237);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnupdate.Size = new System.Drawing.Size(232, 42);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update Donut";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnadd.FlatAppearance.BorderSize = 2;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Blue;
            this.btnadd.Image = global::DonutShop2.Properties.Resources.plus;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(27, 189);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnadd.Size = new System.Drawing.Size(232, 42);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Add Donut";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // plBuy
            // 
            this.plBuy.Controls.Add(this.lbprice);
            this.plBuy.Controls.Add(this.label7);
            this.plBuy.Controls.Add(this.btnaddcart);
            this.plBuy.Controls.Add(this.txtnumber);
            this.plBuy.Controls.Add(this.txtname);
            this.plBuy.Controls.Add(this.label2);
            this.plBuy.Controls.Add(this.label1);
            this.plBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBuy.Location = new System.Drawing.Point(610, 0);
            this.plBuy.Name = "plBuy";
            this.plBuy.Size = new System.Drawing.Size(290, 200);
            this.plBuy.TabIndex = 4;
            // 
            // btnaddcart
            // 
            this.btnaddcart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnaddcart.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnaddcart.FlatAppearance.BorderSize = 2;
            this.btnaddcart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnaddcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddcart.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcart.ForeColor = System.Drawing.Color.Blue;
            this.btnaddcart.Image = global::DonutShop2.Properties.Resources.add_to_cart;
            this.btnaddcart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddcart.Location = new System.Drawing.Point(27, 117);
            this.btnaddcart.Name = "btnaddcart";
            this.btnaddcart.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnaddcart.Size = new System.Drawing.Size(232, 53);
            this.btnaddcart.TabIndex = 4;
            this.btnaddcart.Text = "Add Your Cart";
            this.btnaddcart.UseVisualStyleBackColor = true;
            this.btnaddcart.Click += new System.EventHandler(this.btnaddcart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // flpDonutview
            // 
            this.flpDonutview.AutoScroll = true;
            this.flpDonutview.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpDonutview.Location = new System.Drawing.Point(0, 0);
            this.flpDonutview.Name = "flpDonutview";
            this.flpDonutview.Size = new System.Drawing.Size(610, 650);
            this.flpDonutview.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "$";
            // 
            // lbprice
            // 
            this.lbprice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprice.Location = new System.Drawing.Point(121, 90);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(0, 22);
            this.lbprice.TabIndex = 6;
            // 
            // fDonut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.plmanage);
            this.Controls.Add(this.plBuy);
            this.Controls.Add(this.flpDonutview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDonut";
            this.Text = "fDonut";
            this.plmanage.ResumeLayout(false);
            this.plmanage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbview)).EndInit();
            this.plBuy.ResumeLayout(false);
            this.plBuy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbview;
        private System.Windows.Forms.Button btnupnumber;
        private System.Windows.Forms.TextBox txtnumberad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnamead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnaddcart;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plmanage;
        private System.Windows.Forms.Panel plBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpDonutview;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label label7;
    }
}