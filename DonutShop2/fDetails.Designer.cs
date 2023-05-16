
namespace DonutShop2
{
    partial class fDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ccbbillid = new System.Windows.Forms.ComboBox();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.dgvdetailsbill = new System.Windows.Forms.DataGridView();
            this.btnfill = new System.Windows.Forms.Button();
            this.ccbuserid = new System.Windows.Forms.ComboBox();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailsbill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bill id :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "User id :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date :";
            // 
            // ccbbillid
            // 
            this.ccbbillid.FormattingEnabled = true;
            this.ccbbillid.Location = new System.Drawing.Point(118, 31);
            this.ccbbillid.Name = "ccbbillid";
            this.ccbbillid.Size = new System.Drawing.Size(242, 24);
            this.ccbbillid.TabIndex = 28;
            // 
            // dgvbill
            // 
            this.dgvbill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Location = new System.Drawing.Point(3, 215);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.RowHeadersWidth = 51;
            this.dgvbill.RowTemplate.Height = 24;
            this.dgvbill.Size = new System.Drawing.Size(357, 409);
            this.dgvbill.TabIndex = 29;
            this.dgvbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellClick);
            // 
            // dgvdetailsbill
            // 
            this.dgvdetailsbill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvdetailsbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetailsbill.Location = new System.Drawing.Point(382, 13);
            this.dgvdetailsbill.Name = "dgvdetailsbill";
            this.dgvdetailsbill.RowHeadersWidth = 51;
            this.dgvdetailsbill.RowTemplate.Height = 24;
            this.dgvdetailsbill.Size = new System.Drawing.Size(506, 611);
            this.dgvdetailsbill.TabIndex = 30;
            // 
            // btnfill
            // 
            this.btnfill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfill.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnfill.FlatAppearance.BorderSize = 2;
            this.btnfill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnfill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfill.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfill.ForeColor = System.Drawing.Color.Blue;
            this.btnfill.Image = global::DonutShop2.Properties.Resources.filter;
            this.btnfill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfill.Location = new System.Drawing.Point(3, 153);
            this.btnfill.Name = "btnfill";
            this.btnfill.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnfill.Size = new System.Drawing.Size(357, 50);
            this.btnfill.TabIndex = 33;
            this.btnfill.Text = "Filter Bill";
            this.btnfill.UseVisualStyleBackColor = true;
            this.btnfill.Click += new System.EventHandler(this.btnfill_Click);
            // 
            // ccbuserid
            // 
            this.ccbuserid.FormattingEnabled = true;
            this.ccbuserid.Location = new System.Drawing.Point(118, 72);
            this.ccbuserid.Name = "ccbuserid";
            this.ccbuserid.Size = new System.Drawing.Size(242, 24);
            this.ccbuserid.TabIndex = 34;
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(118, 109);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(242, 22);
            this.mtbDate.TabIndex = 35;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // fDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.ccbuserid);
            this.Controls.Add(this.btnfill);
            this.Controls.Add(this.dgvdetailsbill);
            this.Controls.Add(this.dgvbill);
            this.Controls.Add(this.ccbbillid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDetails";
            this.Text = "fDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailsbill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ccbbillid;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.DataGridView dgvdetailsbill;
        private System.Windows.Forms.Button btnfill;
        private System.Windows.Forms.ComboBox ccbuserid;
        private System.Windows.Forms.MaskedTextBox mtbDate;
    }
}