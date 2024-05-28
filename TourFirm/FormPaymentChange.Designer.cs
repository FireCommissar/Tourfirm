namespace TourFirm
{
    partial class FormPaymentChange
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
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVoucher = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(670, 216);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(340, 31);
            this.tbDeposit.TabIndex = 73;
            // 
            // datePayment
            // 
            this.datePayment.Location = new System.Drawing.Point(670, 141);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(340, 31);
            this.datePayment.TabIndex = 72;
            // 
            // comboBoxVoucher
            // 
            this.comboBoxVoucher.FormattingEnabled = true;
            this.comboBoxVoucher.Location = new System.Drawing.Point(670, 64);
            this.comboBoxVoucher.Name = "comboBoxVoucher";
            this.comboBoxVoucher.Size = new System.Drawing.Size(340, 33);
            this.comboBoxVoucher.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Сумма платежа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Дата платежа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Путёвка (id)";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(860, 595);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 50);
            this.btnChange.TabIndex = 67;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(670, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 66;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.RowHeadersWidth = 82;
            this.dataGridViewPayment.RowTemplate.Height = 33;
            this.dataGridViewPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPayment.Size = new System.Drawing.Size(607, 633);
            this.dataGridViewPayment.TabIndex = 65;
            this.dataGridViewPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPayment_CellClick);
            // 
            // FormPaymentChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1073, 657);
            this.Controls.Add(this.tbDeposit);
            this.Controls.Add(this.datePayment);
            this.Controls.Add(this.comboBoxVoucher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewPayment);
            this.Name = "FormPaymentChange";
            this.Text = "FormPaymentChange";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.ComboBox comboBoxVoucher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewPayment;
    }
}