namespace TourFirm
{
    partial class FormSeasonAdd
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewSeason = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbNumPlaces = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeason)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(575, 381);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 32);
            this.btnChange.TabIndex = 50;
            this.btnChange.Text = "Добавить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(448, 381);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewSeason
            // 
            this.dataGridViewSeason.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridViewSeason.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeason.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewSeason.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSeason.Name = "dataGridViewSeason";
            this.dataGridViewSeason.RowHeadersWidth = 82;
            this.dataGridViewSeason.RowTemplate.Height = 33;
            this.dataGridViewSeason.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeason.Size = new System.Drawing.Size(405, 405);
            this.dataGridViewSeason.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Тур";
            // 
            // comboBoxTour
            // 
            this.comboBoxTour.FormattingEnabled = true;
            this.comboBoxTour.Location = new System.Drawing.Point(448, 45);
            this.comboBoxTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTour.Name = "comboBoxTour";
            this.comboBoxTour.Size = new System.Drawing.Size(228, 24);
            this.comboBoxTour.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Дата начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Дата окончания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Количество мест";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(448, 92);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(228, 22);
            this.dateStart.TabIndex = 57;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(448, 139);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(228, 22);
            this.dateEnd.TabIndex = 58;
            // 
            // tbNumPlaces
            // 
            this.tbNumPlaces.Location = new System.Drawing.Point(448, 218);
            this.tbNumPlaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumPlaces.Name = "tbNumPlaces";
            this.tbNumPlaces.Size = new System.Drawing.Size(228, 22);
            this.tbNumPlaces.TabIndex = 59;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(448, 172);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 20);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "Сезон закрыт";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormSeasonAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(715, 420);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSeasonAdd";
            this.Text = "FormSeasonAdd";
            this.Load += new System.EventHandler(this.FormSeasonAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewSeason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbNumPlaces;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}