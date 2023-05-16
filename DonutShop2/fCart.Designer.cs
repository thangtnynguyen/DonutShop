
namespace DonutShop2
{
    partial class fCart
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
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flgvCart = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btndel.Location = new System.Drawing.Point(624, 430);
            this.btndel.Name = "btndel";
            this.btndel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btndel.Size = new System.Drawing.Size(264, 51);
            this.btndel.TabIndex = 30;
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
            this.btnupdate.Image = global::DonutShop2.Properties.Resources.plus;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(624, 373);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnupdate.Size = new System.Drawing.Size(264, 51);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.Text = "Complete Donut";
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
            this.btnadd.Image = global::DonutShop2.Properties.Resources.add_to_cart1;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(624, 316);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnadd.Size = new System.Drawing.Size(264, 51);
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "Buy Donut";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtprice
            // 
            this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtprice.BackColor = System.Drawing.SystemColors.Control;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Location = new System.Drawing.Point(702, 119);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(186, 22);
            this.txtprice.TabIndex = 27;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Number :";
            // 
            // txtnumber
            // 
            this.txtnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtnumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumber.Location = new System.Drawing.Point(702, 82);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(186, 22);
            this.txtnumber.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Status :";
            // 
            // txtidname
            // 
            this.txtidname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtidname.BackColor = System.Drawing.SystemColors.Control;
            this.txtidname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidname.Location = new System.Drawing.Point(702, 45);
            this.txtidname.Name = "txtidname";
            this.txtidname.Size = new System.Drawing.Size(186, 22);
            this.txtidname.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name :";
            // 
            // flgvCart
            // 
            this.flgvCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flgvCart.Location = new System.Drawing.Point(0, 0);
            this.flgvCart.Name = "flgvCart";
            this.flgvCart.Size = new System.Drawing.Size(607, 650);
            this.flgvCart.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbprice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(607, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 650);
            this.panel1.TabIndex = 31;
            // 
            // lbprice
            // 
            this.lbprice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprice.Location = new System.Drawing.Point(115, 144);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(0, 22);
            this.lbprice.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "$";
            // 
            // fCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flgvCart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCart";
            this.Text = "fCart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flgvCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label label7;
    }
}