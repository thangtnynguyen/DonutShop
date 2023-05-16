
namespace DonutShop2
{
    partial class fBill
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
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.dgvdetailsbill = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbdate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupllies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btndeletebill = new System.Windows.Forms.Button();
            this.btnaddbill = new System.Windows.Forms.Button();
            this.btndeletedetails = new System.Windows.Forms.Button();
            this.btnadddetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailsbill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbill
            // 
            this.dgvbill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Location = new System.Drawing.Point(12, 12);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.RowHeadersWidth = 51;
            this.dgvbill.RowTemplate.Height = 24;
            this.dgvbill.Size = new System.Drawing.Size(427, 356);
            this.dgvbill.TabIndex = 0;
            this.dgvbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellClick);
            // 
            // dgvdetailsbill
            // 
            this.dgvdetailsbill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvdetailsbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetailsbill.Location = new System.Drawing.Point(461, 12);
            this.dgvdetailsbill.Name = "dgvdetailsbill";
            this.dgvdetailsbill.RowHeadersWidth = 51;
            this.dgvdetailsbill.RowTemplate.Height = 24;
            this.dgvdetailsbill.Size = new System.Drawing.Size(427, 356);
            this.dgvdetailsbill.TabIndex = 1;
            this.dgvdetailsbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetailsbill_CellClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(153, 406);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(286, 22);
            this.txtid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bill id :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date :";
            // 
            // mtbdate
            // 
            this.mtbdate.Location = new System.Drawing.Point(153, 446);
            this.mtbdate.Mask = "00/00/0000";
            this.mtbdate.Name = "mtbdate";
            this.mtbdate.Size = new System.Drawing.Size(286, 22);
            this.mtbdate.TabIndex = 23;
            this.mtbdate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Supllies :";
            // 
            // txtSupllies
            // 
            this.txtSupllies.Location = new System.Drawing.Point(602, 404);
            this.txtSupllies.Name = "txtSupllies";
            this.txtSupllies.Size = new System.Drawing.Size(286, 22);
            this.txtSupllies.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Number :";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(602, 444);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(286, 22);
            this.txtnumber.TabIndex = 26;
            this.txtnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(535, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Price :";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(602, 484);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(286, 22);
            this.txtprice.TabIndex = 28;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // btndeletebill
            // 
            this.btndeletebill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndeletebill.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btndeletebill.FlatAppearance.BorderSize = 2;
            this.btndeletebill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndeletebill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletebill.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletebill.ForeColor = System.Drawing.Color.Blue;
            this.btndeletebill.Image = global::DonutShop2.Properties.Resources.delete;
            this.btndeletebill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeletebill.Location = new System.Drawing.Point(54, 549);
            this.btndeletebill.Name = "btndeletebill";
            this.btndeletebill.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btndeletebill.Size = new System.Drawing.Size(385, 50);
            this.btndeletebill.TabIndex = 33;
            this.btndeletebill.Text = "Delete Bill";
            this.btndeletebill.UseVisualStyleBackColor = true;
            this.btndeletebill.Click += new System.EventHandler(this.btndeletebill_Click);
            // 
            // btnaddbill
            // 
            this.btnaddbill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddbill.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnaddbill.FlatAppearance.BorderSize = 2;
            this.btnaddbill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnaddbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddbill.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbill.ForeColor = System.Drawing.Color.Blue;
            this.btnaddbill.Image = global::DonutShop2.Properties.Resources.plus;
            this.btnaddbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddbill.Location = new System.Drawing.Point(54, 493);
            this.btnaddbill.Name = "btnaddbill";
            this.btnaddbill.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnaddbill.Size = new System.Drawing.Size(385, 50);
            this.btnaddbill.TabIndex = 32;
            this.btnaddbill.Text = "Add Bill";
            this.btnaddbill.UseVisualStyleBackColor = true;
            this.btnaddbill.Click += new System.EventHandler(this.btnaddbill_Click);
            // 
            // btndeletedetails
            // 
            this.btndeletedetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndeletedetails.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btndeletedetails.FlatAppearance.BorderSize = 2;
            this.btndeletedetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndeletedetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletedetails.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletedetails.ForeColor = System.Drawing.Color.Blue;
            this.btndeletedetails.Image = global::DonutShop2.Properties.Resources.delete;
            this.btndeletedetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeletedetails.Location = new System.Drawing.Point(686, 549);
            this.btndeletedetails.Name = "btndeletedetails";
            this.btndeletedetails.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btndeletedetails.Size = new System.Drawing.Size(202, 50);
            this.btndeletedetails.TabIndex = 31;
            this.btndeletedetails.Text = "Delete Details";
            this.btndeletedetails.UseVisualStyleBackColor = true;
            this.btndeletedetails.Click += new System.EventHandler(this.btndeletedetails_Click);
            // 
            // btnadddetails
            // 
            this.btnadddetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadddetails.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnadddetails.FlatAppearance.BorderSize = 2;
            this.btnadddetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnadddetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadddetails.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadddetails.ForeColor = System.Drawing.Color.Blue;
            this.btnadddetails.Image = global::DonutShop2.Properties.Resources.plus;
            this.btnadddetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadddetails.Location = new System.Drawing.Point(478, 549);
            this.btnadddetails.Name = "btnadddetails";
            this.btnadddetails.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnadddetails.Size = new System.Drawing.Size(202, 50);
            this.btnadddetails.TabIndex = 30;
            this.btnadddetails.Text = "Add Details";
            this.btnadddetails.UseVisualStyleBackColor = true;
            this.btnadddetails.Click += new System.EventHandler(this.btnadddetails_Click);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btndeletebill);
            this.Controls.Add(this.btnaddbill);
            this.Controls.Add(this.btndeletedetails);
            this.Controls.Add(this.btnadddetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupllies);
            this.Controls.Add(this.mtbdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgvdetailsbill);
            this.Controls.Add(this.dgvbill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBill";
            this.Text = "fBill";
            this.Load += new System.EventHandler(this.fBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailsbill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.DataGridView dgvdetailsbill;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupllies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btndeletedetails;
        private System.Windows.Forms.Button btnadddetails;
        private System.Windows.Forms.Button btndeletebill;
        private System.Windows.Forms.Button btnaddbill;
    }
}