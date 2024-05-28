namespace TourFirm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTourist = new System.Windows.Forms.TabPage();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.btnDeleteTourist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChangeTourist = new System.Windows.Forms.Button();
            this.btnAddTourist = new System.Windows.Forms.Button();
            this.tabPageTourInfo = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageSeason = new System.Windows.Forms.TabPage();
            this.btnDeleteSeason = new System.Windows.Forms.Button();
            this.btnChangeSeason = new System.Windows.Forms.Button();
            this.btnAddSeason = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPageTour = new System.Windows.Forms.TabPage();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.btnChangeTour = new System.Windows.Forms.Button();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPageVoucher = new System.Windows.Forms.TabPage();
            this.btnDeleteVoucher = new System.Windows.Forms.Button();
            this.btnChangeVoucher = new System.Windows.Forms.Button();
            this.btnAddVoucher = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPagePayment = new System.Windows.Forms.TabPage();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnChangePayment = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabPageRequests = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImportXmlDocument = new System.Windows.Forms.Button();
            this.btnExportXmlDocument = new System.Windows.Forms.Button();
            this.btnImportXmlReader = new System.Windows.Forms.Button();
            this.btnExportXmlWriter = new System.Windows.Forms.Button();
            this.tbReq2 = new System.Windows.Forms.TextBox();
            this.tbReq1 = new System.Windows.Forms.TextBox();
            this.btnReq2 = new System.Windows.Forms.Button();
            this.btnReq1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewReq = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPageTourist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageTourInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageSeason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPageTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPageVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPagePayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPageRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReq)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTourist);
            this.tabControl1.Controls.Add(this.tabPageTourInfo);
            this.tabControl1.Controls.Add(this.tabPageSeason);
            this.tabControl1.Controls.Add(this.tabPageTour);
            this.tabControl1.Controls.Add(this.tabPageVoucher);
            this.tabControl1.Controls.Add(this.tabPagePayment);
            this.tabControl1.Controls.Add(this.tabPageRequests);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTourist
            // 
            this.tabPageTourist.Controls.Add(this.btnTrigger);
            this.tabPageTourist.Controls.Add(this.btnDeleteTourist);
            this.tabPageTourist.Controls.Add(this.dataGridView1);
            this.tabPageTourist.Controls.Add(this.btnChangeTourist);
            this.tabPageTourist.Controls.Add(this.btnAddTourist);
            this.tabPageTourist.Location = new System.Drawing.Point(4, 25);
            this.tabPageTourist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTourist.Name = "tabPageTourist";
            this.tabPageTourist.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTourist.Size = new System.Drawing.Size(855, 429);
            this.tabPageTourist.TabIndex = 0;
            this.tabPageTourist.Text = "Туристы";
            this.tabPageTourist.UseVisualStyleBackColor = true;
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(725, 377);
            this.btnTrigger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(100, 28);
            this.btnTrigger.TabIndex = 4;
            this.btnTrigger.Text = "ТРИГГЕР";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // btnDeleteTourist
            // 
            this.btnDeleteTourist.Location = new System.Drawing.Point(253, 374);
            this.btnDeleteTourist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTourist.Name = "btnDeleteTourist";
            this.btnDeleteTourist.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteTourist.TabIndex = 3;
            this.btnDeleteTourist.Text = "Удалить";
            this.btnDeleteTourist.UseVisualStyleBackColor = true;
            this.btnDeleteTourist.Click += new System.EventHandler(this.btnDeleteTourist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnChangeTourist
            // 
            this.btnChangeTourist.Location = new System.Drawing.Point(133, 374);
            this.btnChangeTourist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeTourist.Name = "btnChangeTourist";
            this.btnChangeTourist.Size = new System.Drawing.Size(100, 32);
            this.btnChangeTourist.TabIndex = 2;
            this.btnChangeTourist.Text = "Изменить";
            this.btnChangeTourist.UseVisualStyleBackColor = true;
            this.btnChangeTourist.Click += new System.EventHandler(this.btnChangeTourist_Click);
            // 
            // btnAddTourist
            // 
            this.btnAddTourist.Location = new System.Drawing.Point(16, 374);
            this.btnAddTourist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTourist.Name = "btnAddTourist";
            this.btnAddTourist.Size = new System.Drawing.Size(100, 32);
            this.btnAddTourist.TabIndex = 1;
            this.btnAddTourist.Text = "Добавить";
            this.btnAddTourist.UseVisualStyleBackColor = true;
            this.btnAddTourist.Click += new System.EventHandler(this.btnAddTourist_Click);
            // 
            // tabPageTourInfo
            // 
            this.tabPageTourInfo.Controls.Add(this.dataGridView2);
            this.tabPageTourInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageTourInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTourInfo.Name = "tabPageTourInfo";
            this.tabPageTourInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTourInfo.Size = new System.Drawing.Size(855, 429);
            this.tabPageTourInfo.TabIndex = 1;
            this.tabPageTourInfo.Text = "Информация о туристах";
            this.tabPageTourInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(844, 352);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPageSeason
            // 
            this.tabPageSeason.Controls.Add(this.btnDeleteSeason);
            this.tabPageSeason.Controls.Add(this.btnChangeSeason);
            this.tabPageSeason.Controls.Add(this.btnAddSeason);
            this.tabPageSeason.Controls.Add(this.dataGridView3);
            this.tabPageSeason.Location = new System.Drawing.Point(4, 25);
            this.tabPageSeason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSeason.Name = "tabPageSeason";
            this.tabPageSeason.Size = new System.Drawing.Size(855, 429);
            this.tabPageSeason.TabIndex = 2;
            this.tabPageSeason.Text = "Сезоны";
            this.tabPageSeason.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSeason
            // 
            this.btnDeleteSeason.Location = new System.Drawing.Point(253, 372);
            this.btnDeleteSeason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSeason.Name = "btnDeleteSeason";
            this.btnDeleteSeason.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteSeason.TabIndex = 6;
            this.btnDeleteSeason.Text = "Удалить";
            this.btnDeleteSeason.UseVisualStyleBackColor = true;
            this.btnDeleteSeason.Click += new System.EventHandler(this.btnDeleteSeason_Click);
            // 
            // btnChangeSeason
            // 
            this.btnChangeSeason.Location = new System.Drawing.Point(133, 372);
            this.btnChangeSeason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeSeason.Name = "btnChangeSeason";
            this.btnChangeSeason.Size = new System.Drawing.Size(100, 32);
            this.btnChangeSeason.TabIndex = 5;
            this.btnChangeSeason.Text = "Изменить";
            this.btnChangeSeason.UseVisualStyleBackColor = true;
            this.btnChangeSeason.Click += new System.EventHandler(this.btnChangeSeason_Click);
            // 
            // btnAddSeason
            // 
            this.btnAddSeason.Location = new System.Drawing.Point(16, 372);
            this.btnAddSeason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSeason.Name = "btnAddSeason";
            this.btnAddSeason.Size = new System.Drawing.Size(100, 32);
            this.btnAddSeason.TabIndex = 4;
            this.btnAddSeason.Text = "Добавить";
            this.btnAddSeason.UseVisualStyleBackColor = true;
            this.btnAddSeason.Click += new System.EventHandler(this.btnAddSeason_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(5, 2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(844, 352);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPageTour
            // 
            this.tabPageTour.Controls.Add(this.btnDeleteTour);
            this.tabPageTour.Controls.Add(this.btnChangeTour);
            this.tabPageTour.Controls.Add(this.btnAddTour);
            this.tabPageTour.Controls.Add(this.dataGridView4);
            this.tabPageTour.Location = new System.Drawing.Point(4, 25);
            this.tabPageTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTour.Name = "tabPageTour";
            this.tabPageTour.Size = new System.Drawing.Size(855, 429);
            this.tabPageTour.TabIndex = 3;
            this.tabPageTour.Text = "Туры";
            this.tabPageTour.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.Location = new System.Drawing.Point(253, 375);
            this.btnDeleteTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteTour.TabIndex = 6;
            this.btnDeleteTour.Text = "Удалить";
            this.btnDeleteTour.UseVisualStyleBackColor = true;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // btnChangeTour
            // 
            this.btnChangeTour.Location = new System.Drawing.Point(133, 375);
            this.btnChangeTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeTour.Name = "btnChangeTour";
            this.btnChangeTour.Size = new System.Drawing.Size(100, 32);
            this.btnChangeTour.TabIndex = 5;
            this.btnChangeTour.Text = "Изменить";
            this.btnChangeTour.UseVisualStyleBackColor = true;
            this.btnChangeTour.Click += new System.EventHandler(this.btnChangeTour_Click);
            // 
            // btnAddTour
            // 
            this.btnAddTour.Location = new System.Drawing.Point(16, 375);
            this.btnAddTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(100, 32);
            this.btnAddTour.TabIndex = 4;
            this.btnAddTour.Text = "Добавить";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(4, 2);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 82;
            this.dataGridView4.RowTemplate.Height = 33;
            this.dataGridView4.Size = new System.Drawing.Size(844, 352);
            this.dataGridView4.TabIndex = 1;
            // 
            // tabPageVoucher
            // 
            this.tabPageVoucher.Controls.Add(this.btnDeleteVoucher);
            this.tabPageVoucher.Controls.Add(this.btnChangeVoucher);
            this.tabPageVoucher.Controls.Add(this.btnAddVoucher);
            this.tabPageVoucher.Controls.Add(this.dataGridView5);
            this.tabPageVoucher.Location = new System.Drawing.Point(4, 25);
            this.tabPageVoucher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageVoucher.Name = "tabPageVoucher";
            this.tabPageVoucher.Size = new System.Drawing.Size(855, 429);
            this.tabPageVoucher.TabIndex = 4;
            this.tabPageVoucher.Text = "Путёвки";
            this.tabPageVoucher.UseVisualStyleBackColor = true;
            // 
            // btnDeleteVoucher
            // 
            this.btnDeleteVoucher.Location = new System.Drawing.Point(253, 377);
            this.btnDeleteVoucher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteVoucher.Name = "btnDeleteVoucher";
            this.btnDeleteVoucher.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteVoucher.TabIndex = 6;
            this.btnDeleteVoucher.Text = "Удалить";
            this.btnDeleteVoucher.UseVisualStyleBackColor = true;
            this.btnDeleteVoucher.Click += new System.EventHandler(this.btnDeleteVoucher_Click);
            // 
            // btnChangeVoucher
            // 
            this.btnChangeVoucher.Location = new System.Drawing.Point(133, 377);
            this.btnChangeVoucher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeVoucher.Name = "btnChangeVoucher";
            this.btnChangeVoucher.Size = new System.Drawing.Size(100, 32);
            this.btnChangeVoucher.TabIndex = 5;
            this.btnChangeVoucher.Text = "Изменить";
            this.btnChangeVoucher.UseVisualStyleBackColor = true;
            this.btnChangeVoucher.Click += new System.EventHandler(this.btnChangeVoucher_Click);
            // 
            // btnAddVoucher
            // 
            this.btnAddVoucher.Location = new System.Drawing.Point(16, 377);
            this.btnAddVoucher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddVoucher.Name = "btnAddVoucher";
            this.btnAddVoucher.Size = new System.Drawing.Size(100, 32);
            this.btnAddVoucher.TabIndex = 4;
            this.btnAddVoucher.Text = "Добавить";
            this.btnAddVoucher.UseVisualStyleBackColor = true;
            this.btnAddVoucher.Click += new System.EventHandler(this.btnAddVoucher_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(5, 2);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 82;
            this.dataGridView5.RowTemplate.Height = 33;
            this.dataGridView5.Size = new System.Drawing.Size(844, 352);
            this.dataGridView5.TabIndex = 1;
            // 
            // tabPagePayment
            // 
            this.tabPagePayment.Controls.Add(this.btnDeletePayment);
            this.tabPagePayment.Controls.Add(this.btnChangePayment);
            this.tabPagePayment.Controls.Add(this.btnAddPayment);
            this.tabPagePayment.Controls.Add(this.dataGridView6);
            this.tabPagePayment.Location = new System.Drawing.Point(4, 25);
            this.tabPagePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePayment.Name = "tabPagePayment";
            this.tabPagePayment.Size = new System.Drawing.Size(855, 429);
            this.tabPagePayment.TabIndex = 5;
            this.tabPagePayment.Text = "Оплата";
            this.tabPagePayment.UseVisualStyleBackColor = true;
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(253, 377);
            this.btnDeletePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(100, 32);
            this.btnDeletePayment.TabIndex = 6;
            this.btnDeletePayment.Text = "Удалить";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnChangePayment
            // 
            this.btnChangePayment.Location = new System.Drawing.Point(133, 377);
            this.btnChangePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePayment.Name = "btnChangePayment";
            this.btnChangePayment.Size = new System.Drawing.Size(100, 32);
            this.btnChangePayment.TabIndex = 5;
            this.btnChangePayment.Text = "Изменить";
            this.btnChangePayment.UseVisualStyleBackColor = true;
            this.btnChangePayment.Click += new System.EventHandler(this.btnChangePayment_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(15, 377);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(100, 32);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "Добавить";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(4, 2);
            this.dataGridView6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 82;
            this.dataGridView6.RowTemplate.Height = 33;
            this.dataGridView6.Size = new System.Drawing.Size(844, 352);
            this.dataGridView6.TabIndex = 1;
            // 
            // tabPageRequests
            // 
            this.tabPageRequests.Controls.Add(this.label3);
            this.tabPageRequests.Controls.Add(this.btnImportXmlDocument);
            this.tabPageRequests.Controls.Add(this.btnExportXmlDocument);
            this.tabPageRequests.Controls.Add(this.btnImportXmlReader);
            this.tabPageRequests.Controls.Add(this.btnExportXmlWriter);
            this.tabPageRequests.Controls.Add(this.tbReq2);
            this.tabPageRequests.Controls.Add(this.tbReq1);
            this.tabPageRequests.Controls.Add(this.btnReq2);
            this.tabPageRequests.Controls.Add(this.btnReq1);
            this.tabPageRequests.Controls.Add(this.label2);
            this.tabPageRequests.Controls.Add(this.label1);
            this.tabPageRequests.Controls.Add(this.dataGridViewReq);
            this.tabPageRequests.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRequests.Name = "tabPageRequests";
            this.tabPageRequests.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRequests.Size = new System.Drawing.Size(855, 429);
            this.tabPageRequests.TabIndex = 6;
            this.tabPageRequests.Text = "Запросы";
            this.tabPageRequests.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // btnImportXmlDocument
            // 
            this.btnImportXmlDocument.Location = new System.Drawing.Point(659, 292);
            this.btnImportXmlDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportXmlDocument.Name = "btnImportXmlDocument";
            this.btnImportXmlDocument.Size = new System.Drawing.Size(179, 32);
            this.btnImportXmlDocument.TabIndex = 10;
            this.btnImportXmlDocument.Text = "Импорт XmlDocument";
            this.btnImportXmlDocument.UseVisualStyleBackColor = true;
            this.btnImportXmlDocument.Click += new System.EventHandler(this.btnImportXmlDocument_Click);
            // 
            // btnExportXmlDocument
            // 
            this.btnExportXmlDocument.Location = new System.Drawing.Point(456, 292);
            this.btnExportXmlDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportXmlDocument.Name = "btnExportXmlDocument";
            this.btnExportXmlDocument.Size = new System.Drawing.Size(179, 32);
            this.btnExportXmlDocument.TabIndex = 9;
            this.btnExportXmlDocument.Text = "Экспорт XmlDocument";
            this.btnExportXmlDocument.UseVisualStyleBackColor = true;
            this.btnExportXmlDocument.Click += new System.EventHandler(this.btnExportXmlDocument_Click);
            // 
            // btnImportXmlReader
            // 
            this.btnImportXmlReader.Location = new System.Drawing.Point(659, 247);
            this.btnImportXmlReader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportXmlReader.Name = "btnImportXmlReader";
            this.btnImportXmlReader.Size = new System.Drawing.Size(179, 32);
            this.btnImportXmlReader.TabIndex = 8;
            this.btnImportXmlReader.Text = "Импорт XmlReader";
            this.btnImportXmlReader.UseVisualStyleBackColor = true;
            this.btnImportXmlReader.Click += new System.EventHandler(this.btnImportXmlReader_Click);
            // 
            // btnExportXmlWriter
            // 
            this.btnExportXmlWriter.Location = new System.Drawing.Point(456, 247);
            this.btnExportXmlWriter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportXmlWriter.Name = "btnExportXmlWriter";
            this.btnExportXmlWriter.Size = new System.Drawing.Size(179, 32);
            this.btnExportXmlWriter.TabIndex = 7;
            this.btnExportXmlWriter.Text = "Экспорт XmlWriter";
            this.btnExportXmlWriter.UseVisualStyleBackColor = true;
            this.btnExportXmlWriter.Click += new System.EventHandler(this.btnExportXmlWriter_Click);
            // 
            // tbReq2
            // 
            this.tbReq2.Location = new System.Drawing.Point(456, 165);
            this.tbReq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReq2.Name = "tbReq2";
            this.tbReq2.Size = new System.Drawing.Size(371, 22);
            this.tbReq2.TabIndex = 6;
            // 
            // tbReq1
            // 
            this.tbReq1.Location = new System.Drawing.Point(456, 52);
            this.tbReq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReq1.Name = "tbReq1";
            this.tbReq1.Size = new System.Drawing.Size(371, 22);
            this.tbReq1.TabIndex = 5;
            // 
            // btnReq2
            // 
            this.btnReq2.Location = new System.Drawing.Point(725, 202);
            this.btnReq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReq2.Name = "btnReq2";
            this.btnReq2.Size = new System.Drawing.Size(100, 32);
            this.btnReq2.TabIndex = 4;
            this.btnReq2.Text = "Выполнить";
            this.btnReq2.UseVisualStyleBackColor = true;
            this.btnReq2.Click += new System.EventHandler(this.btnReq2_Click);
            // 
            // btnReq1
            // 
            this.btnReq1.Location = new System.Drawing.Point(725, 86);
            this.btnReq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReq1.Name = "btnReq1";
            this.btnReq1.Size = new System.Drawing.Size(100, 32);
            this.btnReq1.TabIndex = 3;
            this.btnReq1.Text = "Выполнить";
            this.btnReq1.UseVisualStyleBackColor = true;
            this.btnReq1.Click += new System.EventHandler(this.btnReq1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Параметризованные запросы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Агрегированный запрос (MAX, MIN)";
            // 
            // dataGridViewReq
            // 
            this.dataGridViewReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReq.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReq.Name = "dataGridViewReq";
            this.dataGridViewReq.RowHeadersWidth = 82;
            this.dataGridViewReq.RowTemplate.Height = 33;
            this.dataGridViewReq.Size = new System.Drawing.Size(429, 420);
            this.dataGridViewReq.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.chart2);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(855, 429);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Диаграмма";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(424, 384);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(432, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(420, 384);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(909, 513);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Турфирма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTourist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageTourInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageSeason.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPageTour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPageVoucher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPagePayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPageRequests.ResumeLayout(false);
            this.tabPageRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReq)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTourist;
        private System.Windows.Forms.TabPage tabPageTourInfo;
        private System.Windows.Forms.TabPage tabPageSeason;
        private System.Windows.Forms.TabPage tabPageTour;
        private System.Windows.Forms.TabPage tabPageVoucher;
        private System.Windows.Forms.TabPage tabPagePayment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button btnAddTourist;
        private System.Windows.Forms.Button btnChangeTourist;
        private System.Windows.Forms.Button btnDeleteTourist;
        private System.Windows.Forms.Button btnDeleteSeason;
        private System.Windows.Forms.Button btnChangeSeason;
        private System.Windows.Forms.Button btnAddSeason;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.Button btnChangeTour;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.Button btnDeleteVoucher;
        private System.Windows.Forms.Button btnChangeVoucher;
        private System.Windows.Forms.Button btnAddVoucher;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnChangePayment;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.TabPage tabPageRequests;
        private System.Windows.Forms.DataGridView dataGridViewReq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReq2;
        private System.Windows.Forms.TextBox tbReq1;
        private System.Windows.Forms.Button btnReq2;
        private System.Windows.Forms.Button btnReq1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportXmlDocument;
        private System.Windows.Forms.Button btnExportXmlDocument;
        private System.Windows.Forms.Button btnImportXmlReader;
        private System.Windows.Forms.Button btnExportXmlWriter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}

