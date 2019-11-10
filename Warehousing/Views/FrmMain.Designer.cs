namespace Warehousing.Views
{
    partial class FrmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WareHousControlTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvSellProduct = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSellQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSellName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSellCode = new System.Windows.Forms.TextBox();
            this.btnChangeDecrease = new System.Windows.Forms.Button();
            this.btnChangeIncrease = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.WareHousStatusTab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WareHousStatusTab2 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvStoreStatus = new System.Windows.Forms.DataGridView();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAddProductList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddUpdateProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddSearchCode = new System.Windows.Forms.TextBox();
            this.txtAddSearchName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddProductQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddProductCode = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.WareHousControlTab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellProduct)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.WareHousStatusTab.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.WareHousStatusTab2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreStatus)).BeginInit();
            this.ProductsTab.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProductList)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.WareHousControlTab);
            this.tabControl1.Controls.Add(this.WareHousStatusTab);
            this.tabControl1.Controls.Add(this.WareHousStatusTab2);
            this.tabControl1.Controls.Add(this.ProductsTab);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 557);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // WareHousControlTab
            // 
            this.WareHousControlTab.Controls.Add(this.panel5);
            this.WareHousControlTab.Controls.Add(this.panel4);
            this.WareHousControlTab.Location = new System.Drawing.Point(4, 22);
            this.WareHousControlTab.Name = "WareHousControlTab";
            this.WareHousControlTab.Padding = new System.Windows.Forms.Padding(3);
            this.WareHousControlTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WareHousControlTab.Size = new System.Drawing.Size(1040, 531);
            this.WareHousControlTab.TabIndex = 0;
            this.WareHousControlTab.Text = "انبار ";
            this.WareHousControlTab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dgvSellProduct);
            this.panel5.Location = new System.Drawing.Point(6, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1028, 417);
            this.panel5.TabIndex = 20;
            // 
            // dgvSellProduct
            // 
            this.dgvSellProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSellProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvSellProduct.Name = "dgvSellProduct";
            this.dgvSellProduct.Size = new System.Drawing.Size(1028, 417);
            this.dgvSellProduct.TabIndex = 0;
            this.dgvSellProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellProduct_CellClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Controls.Add(this.btnChangeDecrease);
            this.panel4.Controls.Add(this.btnChangeIncrease);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 84);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.894737F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.894737F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSellQuantity, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSellName, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSellCode, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(137, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(879, 29);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(836, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "کد:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSellQuantity
            // 
            this.txtSellQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSellQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellQuantity.Location = new System.Drawing.Point(3, 2);
            this.txtSellQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSellQuantity.Name = "txtSellQuantity";
            this.txtSellQuantity.Size = new System.Drawing.Size(181, 22);
            this.txtSellQuantity.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(190, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "تعداد";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSellName
            // 
            this.txtSellName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSellName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellName.Location = new System.Drawing.Point(259, 2);
            this.txtSellName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSellName.Name = "txtSellName";
            this.txtSellName.Size = new System.Drawing.Size(271, 22);
            this.txtSellName.TabIndex = 4;
            this.txtSellName.TextChanged += new System.EventHandler(this.txtSellName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(536, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "نام:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSellCode
            // 
            this.txtSellCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSellCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSellCode.Location = new System.Drawing.Point(605, 2);
            this.txtSellCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSellCode.Name = "txtSellCode";
            this.txtSellCode.Size = new System.Drawing.Size(225, 22);
            this.txtSellCode.TabIndex = 0;
            this.txtSellCode.TextChanged += new System.EventHandler(this.txtSellCode_TextChanged);
            // 
            // btnChangeDecrease
            // 
            this.btnChangeDecrease.Location = new System.Drawing.Point(15, 24);
            this.btnChangeDecrease.Name = "btnChangeDecrease";
            this.btnChangeDecrease.Size = new System.Drawing.Size(55, 42);
            this.btnChangeDecrease.TabIndex = 0;
            this.btnChangeDecrease.Text = "کاهش";
            this.btnChangeDecrease.UseVisualStyleBackColor = true;
            this.btnChangeDecrease.Click += new System.EventHandler(this.btnChangeDecrease_Click);
            // 
            // btnChangeIncrease
            // 
            this.btnChangeIncrease.Location = new System.Drawing.Point(76, 24);
            this.btnChangeIncrease.Name = "btnChangeIncrease";
            this.btnChangeIncrease.Size = new System.Drawing.Size(55, 42);
            this.btnChangeIncrease.TabIndex = 1;
            this.btnChangeIncrease.Text = "افزایش";
            this.btnChangeIncrease.UseVisualStyleBackColor = true;
            this.btnChangeIncrease.Click += new System.EventHandler(this.btnChangeIncrease_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(897, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "افزایش یا تغییر تعداد :";
            // 
            // WareHousStatusTab
            // 
            this.WareHousStatusTab.Controls.Add(this.panel6);
            this.WareHousStatusTab.Location = new System.Drawing.Point(4, 22);
            this.WareHousStatusTab.Name = "WareHousStatusTab";
            this.WareHousStatusTab.Padding = new System.Windows.Forms.Padding(3);
            this.WareHousStatusTab.Size = new System.Drawing.Size(1040, 531);
            this.WareHousStatusTab.TabIndex = 1;
            this.WareHousStatusTab.Text = "گزارش انبار ";
            this.WareHousStatusTab.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.Chart);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1028, 519);
            this.panel6.TabIndex = 0;
            // 
            // Chart
            // 
            chartArea9.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea9);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.Chart.Legends.Add(legend9);
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Name = "Chart";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Product";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Sold";
            this.Chart.Series.Add(series17);
            this.Chart.Series.Add(series18);
            this.Chart.Size = new System.Drawing.Size(1028, 519);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // WareHousStatusTab2
            // 
            this.WareHousStatusTab2.Controls.Add(this.panel7);
            this.WareHousStatusTab2.Location = new System.Drawing.Point(4, 22);
            this.WareHousStatusTab2.Name = "WareHousStatusTab2";
            this.WareHousStatusTab2.Size = new System.Drawing.Size(1040, 531);
            this.WareHousStatusTab2.TabIndex = 3;
            this.WareHousStatusTab2.Text = "گزارش انبار 2";
            this.WareHousStatusTab2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvStoreStatus);
            this.panel7.Location = new System.Drawing.Point(14, 18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1010, 500);
            this.panel7.TabIndex = 0;
            // 
            // dgvStoreStatus
            // 
            this.dgvStoreStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoreStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoreStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvStoreStatus.Name = "dgvStoreStatus";
            this.dgvStoreStatus.Size = new System.Drawing.Size(1010, 500);
            this.dgvStoreStatus.TabIndex = 0;
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.panel3);
            this.ProductsTab.Controls.Add(this.panel2);
            this.ProductsTab.Controls.Add(this.panel1);
            this.ProductsTab.Location = new System.Drawing.Point(4, 22);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTab.Size = new System.Drawing.Size(1040, 531);
            this.ProductsTab.TabIndex = 2;
            this.ProductsTab.Text = "محصولات";
            this.ProductsTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvAddProductList);
            this.panel3.Location = new System.Drawing.Point(7, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 379);
            this.panel3.TabIndex = 3;
            // 
            // dgvAddProductList
            // 
            this.dgvAddProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddProductList.Location = new System.Drawing.Point(0, 0);
            this.dgvAddProductList.Name = "dgvAddProductList";
            this.dgvAddProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddProductList.Size = new System.Drawing.Size(1025, 379);
            this.dgvAddProductList.TabIndex = 2;
            this.dgvAddProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddProductList_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAddUpdateProduct);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(7, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 45);
            this.panel2.TabIndex = 1;
            // 
            // btnAddUpdateProduct
            // 
            this.btnAddUpdateProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddUpdateProduct.Location = new System.Drawing.Point(14, 8);
            this.btnAddUpdateProduct.Name = "btnAddUpdateProduct";
            this.btnAddUpdateProduct.Size = new System.Drawing.Size(112, 28);
            this.btnAddUpdateProduct.TabIndex = 0;
            this.btnAddUpdateProduct.Text = "حذف محصول ";
            this.btnAddUpdateProduct.UseVisualStyleBackColor = true;
            this.btnAddUpdateProduct.Click += new System.EventHandler(this.btnAddUpdateProduct_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.49319F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.50681F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAddSearchCode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAddSearchName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(307, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(708, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(581, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "جستجو با کد :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddSearchCode
            // 
            this.txtAddSearchCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddSearchCode.Location = new System.Drawing.Point(324, 3);
            this.txtAddSearchCode.Name = "txtAddSearchCode";
            this.txtAddSearchCode.Size = new System.Drawing.Size(251, 21);
            this.txtAddSearchCode.TabIndex = 0;
            this.txtAddSearchCode.TextChanged += new System.EventHandler(this.txtAddSearchCode_TextChanged);
            // 
            // txtAddSearchName
            // 
            this.txtAddSearchName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddSearchName.Location = new System.Drawing.Point(3, 3);
            this.txtAddSearchName.Name = "txtAddSearchName";
            this.txtAddSearchName.Size = new System.Drawing.Size(185, 21);
            this.txtAddSearchName.TabIndex = 1;
            this.txtAddSearchName.TextChanged += new System.EventHandler(this.txtAddSearchName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(194, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "جستجو با نام :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 69);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.894737F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.894737F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAddProductQuantity, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAddProductName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAddProductCode, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(113, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 29);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(858, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "کد:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddProductQuantity
            // 
            this.txtAddProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddProductQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddProductQuantity.Location = new System.Drawing.Point(3, 2);
            this.txtAddProductQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddProductQuantity.Name = "txtAddProductQuantity";
            this.txtAddProductQuantity.Size = new System.Drawing.Size(186, 22);
            this.txtAddProductQuantity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(195, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "تعداد";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddProductName.Location = new System.Drawing.Point(266, 2);
            this.txtAddProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(278, 22);
            this.txtAddProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "نام:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddProductCode
            // 
            this.txtAddProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddProductCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddProductCode.Location = new System.Drawing.Point(621, 2);
            this.txtAddProductCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddProductCode.Name = "txtAddProductCode";
            this.txtAddProductCode.Size = new System.Drawing.Size(231, 22);
            this.txtAddProductCode.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddProduct.Location = new System.Drawing.Point(14, 29);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(82, 29);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "افزودن";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(884, 8);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(134, 14);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "افزودن محصول جدید: ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 581);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimumSize = new System.Drawing.Size(1090, 620);
            this.Name = "FrmMain";
            this.RightToLeftLayout = true;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.WareHousControlTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellProduct)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.WareHousStatusTab.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.WareHousStatusTab2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreStatus)).EndInit();
            this.ProductsTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProductList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WareHousControlTab;
        private System.Windows.Forms.TabPage WareHousStatusTab;
        private System.Windows.Forms.TabPage ProductsTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAddProductCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddProductQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddSearchCode;
        private System.Windows.Forms.TextBox txtAddSearchName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvAddProductList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvSellProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSellQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSellName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSellCode;
        private System.Windows.Forms.Button btnChangeDecrease;
        private System.Windows.Forms.Button btnChangeIncrease;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddUpdateProduct;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.TabPage WareHousStatusTab2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvStoreStatus;
    }
}