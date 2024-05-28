namespace TourFirm
{
    partial class FormTouristAdd
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
            this.dataGridViewTourist = new System.Windows.Forms.DataGridView();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTourist
            // 
            this.dataGridViewTourist.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridViewTourist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourist.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTourist.Name = "dataGridViewTourist";
            this.dataGridViewTourist.RowHeadersWidth = 82;
            this.dataGridViewTourist.RowTemplate.Height = 33;
            this.dataGridViewTourist.Size = new System.Drawing.Size(607, 633);
            this.dataGridViewTourist.TabIndex = 0;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(670, 40);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(340, 31);
            this.tbLastname.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(670, 116);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(340, 31);
            this.tbName.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(670, 188);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(340, 31);
            this.tbSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(670, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(860, 595);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Индекс";
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(670, 547);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(340, 31);
            this.tbIndex.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Номер телефона";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(670, 476);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(340, 31);
            this.tbPhoneNumber.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Страна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Город";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(669, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Данные паспорта";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(670, 404);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(340, 31);
            this.tbCountry.TabIndex = 24;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(670, 333);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(340, 31);
            this.tbCity.TabIndex = 23;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(670, 260);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(340, 31);
            this.tbPass.TabIndex = 22;
            // 
            // FormTouristAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1073, 657);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.dataGridViewTourist);
            this.Name = "FormTouristAdd";
            this.Text = "Добавление туриста";
            this.Load += new System.EventHandler(this.FormTourist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTourist;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPass;
    }
}