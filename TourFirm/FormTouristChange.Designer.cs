namespace TourFirm
{
    partial class FormTouristChange
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
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
            this.dataGridViewTourist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTourist.Size = new System.Drawing.Size(607, 633);
            this.dataGridViewTourist.TabIndex = 1;
            this.dataGridViewTourist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTourist_CellClick);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(862, 595);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 50);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(672, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Индекс";
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(672, 547);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(340, 31);
            this.tbIndex.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Номер телефона";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(672, 476);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(340, 31);
            this.tbPhoneNumber.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Страна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Город";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Данные паспорта";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(672, 404);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(340, 31);
            this.tbCountry.TabIndex = 40;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(672, 333);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(340, 31);
            this.tbCity.TabIndex = 39;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(672, 260);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(340, 31);
            this.tbPass.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Фамилия";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(672, 188);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(340, 31);
            this.tbSurname.TabIndex = 34;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(672, 116);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(340, 31);
            this.tbName.TabIndex = 33;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(672, 40);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(340, 31);
            this.tbLastname.TabIndex = 32;
            // 
            // FormTouristChange
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewTourist);
            this.Name = "FormTouristChange";
            this.Text = "Изменение туриста";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTourist;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastname;
    }
}