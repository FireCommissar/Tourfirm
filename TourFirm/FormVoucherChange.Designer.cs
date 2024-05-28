namespace TourFirm
{
    partial class FormVoucherChange
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
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.comboBoxTourist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewVoucher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Location = new System.Drawing.Point(670, 142);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(340, 33);
            this.comboBoxSeason.TabIndex = 62;
            // 
            // comboBoxTourist
            // 
            this.comboBoxTourist.FormattingEnabled = true;
            this.comboBoxTourist.Location = new System.Drawing.Point(670, 67);
            this.comboBoxTourist.Name = "comboBoxTourist";
            this.comboBoxTourist.Size = new System.Drawing.Size(340, 33);
            this.comboBoxTourist.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Сезон (id)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Турист (id)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(860, 595);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Изменить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(670, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewVoucher
            // 
            this.dataGridViewVoucher.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dataGridViewVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoucher.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVoucher.Name = "dataGridViewVoucher";
            this.dataGridViewVoucher.RowHeadersWidth = 82;
            this.dataGridViewVoucher.RowTemplate.Height = 33;
            this.dataGridViewVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVoucher.Size = new System.Drawing.Size(607, 633);
            this.dataGridViewVoucher.TabIndex = 56;
            this.dataGridViewVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVoucher_CellClick_1);
            // 
            // FormVoucherChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1073, 657);
            this.Controls.Add(this.comboBoxSeason);
            this.Controls.Add(this.comboBoxTourist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewVoucher);
            this.Name = "FormVoucherChange";
            this.Text = "FormVoucherChange";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSeason;
        private System.Windows.Forms.ComboBox comboBoxTourist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewVoucher;
    }
}