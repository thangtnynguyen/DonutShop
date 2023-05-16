
namespace DonutShop2
{
    partial class fIngredient
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
            this.ccbdonut = new System.Windows.Forms.ComboBox();
            this.dgvingredient = new System.Windows.Forms.DataGridView();
            this.btnfilter = new System.Windows.Forms.Button();
            this.cbbsupllies = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvingredient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // ccbdonut
            // 
            this.ccbdonut.FormattingEnabled = true;
            this.ccbdonut.Location = new System.Drawing.Point(693, 32);
            this.ccbdonut.Name = "ccbdonut";
            this.ccbdonut.Size = new System.Drawing.Size(195, 24);
            this.ccbdonut.TabIndex = 4;
            // 
            // dgvingredient
            // 
            this.dgvingredient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvingredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvingredient.Location = new System.Drawing.Point(12, 12);
            this.dgvingredient.Name = "dgvingredient";
            this.dgvingredient.RowHeadersWidth = 51;
            this.dgvingredient.RowTemplate.Height = 24;
            this.dgvingredient.Size = new System.Drawing.Size(584, 608);
            this.dgvingredient.TabIndex = 5;
            this.dgvingredient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvingredient_CellClick);
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
            this.btnfilter.Location = new System.Drawing.Point(623, 76);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnfilter.Size = new System.Drawing.Size(265, 42);
            this.btnfilter.TabIndex = 14;
            this.btnfilter.Text = "Get Donut";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // cbbsupllies
            // 
            this.cbbsupllies.FormattingEnabled = true;
            this.cbbsupllies.Location = new System.Drawing.Point(693, 147);
            this.cbbsupllies.Name = "cbbsupllies";
            this.cbbsupllies.Size = new System.Drawing.Size(195, 24);
            this.cbbsupllies.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name :";
            // 
            // txtnumber
            // 
            this.txtnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtnumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumber.Location = new System.Drawing.Point(693, 186);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(195, 22);
            this.txtnumber.TabIndex = 18;
            this.txtnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(602, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Number :";
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
            this.btndel.Location = new System.Drawing.Point(623, 288);
            this.btndel.Name = "btndel";
            this.btndel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btndel.Size = new System.Drawing.Size(265, 42);
            this.btndel.TabIndex = 20;
            this.btndel.Text = "Delete Ingredient";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
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
            this.btnadd.Location = new System.Drawing.Point(623, 231);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnadd.Size = new System.Drawing.Size(265, 42);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "Add Ingredient";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // fIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbsupllies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.dgvingredient);
            this.Controls.Add(this.ccbdonut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fIngredient";
            this.Text = "fIngredient";
            ((System.ComponentModel.ISupportInitialize)(this.dgvingredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbdonut;
        private System.Windows.Forms.DataGridView dgvingredient;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.ComboBox cbbsupllies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnadd;
    }
}