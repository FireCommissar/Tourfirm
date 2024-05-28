namespace TourFirm
{
    partial class FormSeasonChange
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbNumPlaces = new System.Windows.Forms.TextBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewSeason = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeason)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(672, 268);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 29);
            this.checkBox1.TabIndex = 72;
            this.checkBox1.Text = "Сезон закрыт";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbNumPlaces
            // 
            this.tbNumPlaces.Location = new System.Drawing.Point(672, 340);
            this.tbNumPlaces.Name = "tbNumPlaces";
            this.tbNumPlaces.Size = new System.Drawing.Size(340, 31);
            this.tbNumPlaces.TabIndex = 71;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(672, 217);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(340, 31);
            this.dateEnd.TabIndex = 70;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(672, 143);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(340, 31);
            this.dateStart.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 68;
            this.label5.Text = "Количество мест";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Дата окончания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Дата начала";
            // 
            // comboBoxTour
            // 
            this.comboBoxTour.FormattingEnabled = true;
            this.comboBoxTour.Location = new System.Drawing.Point(672, 70);
            this.comboBoxTour.Name = "comboBoxTour";
            this.comboBoxTour.Size = new System.Drawing.Size(340, 33);
            this.comboBoxTour.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Тур";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(862, 595);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 50);
            this.btnChange.TabIndex = 63;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(672, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewSeason
            // 
            this.dataGridViewSeason.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridViewSeason.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeason.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSeason.Name = "dataGridViewSeason";
            this.dataGridViewSeason.RowHeadersWidth = 82;
            this.dataGridViewSeason.RowTemplate.Height = 33;
            this.dataGridViewSeason.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeason.Size = new System.Drawing.Size(607, 633);
            this.dataGridViewSeason.TabIndex = 61;
            this.dataGridViewSeason.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeason_CellClick);
            // 
            // FormSeasonChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1073, 657);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbNumPlaces);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewSeason);
            this.Name = "FormSeasonChange";
            this.Text = "FormSeasonChange";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbNumPlaces;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewSeason;
    }
}