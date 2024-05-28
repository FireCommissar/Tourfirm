namespace TourFirm
{
    partial class FormVoucherAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewVoucher = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTourist = new System.Windows.Forms.ComboBox();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(573, 381);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 32);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(447, 381);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewVoucher
            // 
            this.dataGridViewVoucher.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dataGridViewVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoucher.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewVoucher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewVoucher.Name = "dataGridViewVoucher";
            this.dataGridViewVoucher.RowHeadersWidth = 82;
            this.dataGridViewVoucher.RowTemplate.Height = 33;
            this.dataGridViewVoucher.Size = new System.Drawing.Size(405, 405);
            this.dataGridViewVoucher.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Турист (id)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Сезон (id)";
            // 
            // comboBoxTourist
            // 
            this.comboBoxTourist.FormattingEnabled = true;
            this.comboBoxTourist.Location = new System.Drawing.Point(447, 43);
            this.comboBoxTourist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTourist.Name = "comboBoxTourist";
            this.comboBoxTourist.Size = new System.Drawing.Size(228, 24);
            this.comboBoxTourist.TabIndex = 54;
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Location = new System.Drawing.Point(447, 91);
            this.comboBoxSeason.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(228, 24);
            this.comboBoxSeason.TabIndex = 55;
            // 
            // FormVoucherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(715, 420);
            this.Controls.Add(this.comboBoxSeason);
            this.Controls.Add(this.comboBoxTourist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewVoucher);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVoucherAdd";
            this.Text = "FormVoucherAdd";
            this.Load += new System.EventHandler(this.FormVoucherAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewVoucher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTourist;
        private System.Windows.Forms.ComboBox comboBoxSeason;
    }
}