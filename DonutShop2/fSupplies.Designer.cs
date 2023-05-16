
namespace DonutShop2
{
    partial class fSupplies
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
            this.btnfilter = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvSuplise = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSuplise)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfilter
            // 
            this.btnfilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfilter.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnfilter.FlatAppearance.BorderSize = 2;
            this.btnfilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilter.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.ForeColor = System.Drawing.Color.Blue;
            this.btnfilter.Image = global::DonutShop2.Properties.Resources.filter;
            this.btnfilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfilter.Location = new System.Drawing.Point(21, 243);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnfilter.Size = new System.Drawing.Size(385, 50);
            this.btnfilter.TabIndex = 24;
            this.btnfilter.Text = "Filter Supllies";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // btndel
            // 
            this.btndel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btndel.FlatAppearance.BorderSize = 2;
            this.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.Blue;
            this.btndel.Image = global::DonutShop2.Properties.Resources.delete;
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(21, 299);
            this.btndel.Name = "btndel";
            this.btndel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btndel.Size = new System.Drawing.Size(385, 50);
            this.btndel.TabIndex = 23;
            this.btndel.Text = "Delete Supllies";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnadd.FlatAppearance.BorderSize = 2;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Blue;
            this.btnadd.Image = global::DonutShop2.Properties.Resources.plus;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(21, 187);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnadd.Size = new System.Drawing.Size(385, 50);
            this.btnadd.TabIndex = 22;
            this.btnadd.Text = "Add Supllies";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtsl
            // 
            this.txtsl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsl.BackColor = System.Drawing.SystemColors.Control;
            this.txtsl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsl.Location = new System.Drawing.Point(102, 125);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(304, 22);
            this.txtsl.TabIndex = 21;
            this.txtsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsl_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Number :";
            // 
            // dtgvSuplise
            // 
            this.dtgvSuplise.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvSuplise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSuplise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSuplise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSuplise.Location = new System.Drawing.Point(0, 0);
            this.dtgvSuplise.Name = "dtgvSuplise";
            this.dtgvSuplise.RowHeadersWidth = 51;
            this.dtgvSuplise.RowTemplate.Height = 24;
            this.dtgvSuplise.Size = new System.Drawing.Size(482, 650);
            this.dtgvSuplise.TabIndex = 19;
            this.dtgvSuplise.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSuplise_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.txtsl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(482, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 650);
            this.panel1.TabIndex = 25;
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.BackColor = System.Drawing.SystemColors.Control;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(102, 81);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(304, 22);
            this.txtname.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name :";
            // 
            // fSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.dtgvSuplise);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSupplies";
            this.Text = "fSupplies";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSuplise)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvSuplise;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
    }
}