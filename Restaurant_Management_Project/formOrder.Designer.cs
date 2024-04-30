namespace Restaurant_Management_Project
{
    partial class formOrder
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelOrders = new System.Windows.Forms.Label();
            this.textboxSearch2 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOrderManagement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewShowActiveOrder = new System.Windows.Forms.DataGridView();
            this.labelActiveOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClearActiveOrder = new System.Windows.Forms.Button();
            this.buttonRemoveActiveOrder = new System.Windows.Forms.Button();
            this.buttonAddActiveOrder = new System.Windows.Forms.Button();
            this.labelActiveOrderPrice = new System.Windows.Forms.Label();
            this.labelOrderPrice = new System.Windows.Forms.Label();
            this.labelOrderQuantity = new System.Windows.Forms.Label();
            this.numericupdownActiveOrderQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelActiveFoodName = new System.Windows.Forms.Label();
            this.labelOrderName = new System.Windows.Forms.Label();
            this.comboboxActiveOrderFoodID = new System.Windows.Forms.ComboBox();
            this.labelFoodID = new System.Windows.Forms.Label();
            this.listboxOrderDetail = new System.Windows.Forms.ComboBox();
            this.labelOrderProductType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonReceiptActiveOrder = new System.Windows.Forms.Button();
            this.buttonPayActiveOrder = new System.Windows.Forms.Button();
            this.labelOrderChange = new System.Windows.Forms.Label();
            this.labelActiveOrderChange = new System.Windows.Forms.Label();
            this.labelActiveOrderAmount = new System.Windows.Forms.Label();
            this.labelOrderPrices = new System.Windows.Forms.Label();
            this.labelOrderActivePrice = new System.Windows.Forms.Label();
            this.labelTotalOrder = new System.Windows.Forms.Label();
            this.labelOrderAmounts = new System.Windows.Forms.TextBox();
            this.datagridviewShowTotalOrder = new System.Windows.Forms.DataGridView();
            this.comboBoxActiveOrderTable = new System.Windows.Forms.ComboBox();
            this.labelOrderTable = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowActiveOrder)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownActiveOrderQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowTotalOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.labelOrders);
            this.panel4.Controls.Add(this.textboxSearch2);
            this.panel4.Controls.Add(this.buttonExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 80);
            this.panel4.TabIndex = 30;
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrders.Location = new System.Drawing.Point(29, 12);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(205, 49);
            this.labelOrders.TabIndex = 20;
            this.labelOrders.Text = "Siparişler";
            // 
            // textboxSearch2
            // 
            this.textboxSearch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.textboxSearch2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSearch2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxSearch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.textboxSearch2.Location = new System.Drawing.Point(550, 26);
            this.textboxSearch2.Multiline = true;
            this.textboxSearch2.Name = "textboxSearch2";
            this.textboxSearch2.Size = new System.Drawing.Size(354, 25);
            this.textboxSearch2.TabIndex = 21;
            this.textboxSearch2.Text = "    Sistem içinde ara...";
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::Restaurant_Management_Project.Properties.Resources.close;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(910, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 34);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOrderManagement
            // 
            this.buttonOrderManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.buttonOrderManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.buttonOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.buttonOrderManagement.Location = new System.Drawing.Point(681, 96);
            this.buttonOrderManagement.Name = "buttonOrderManagement";
            this.buttonOrderManagement.Size = new System.Drawing.Size(230, 43);
            this.buttonOrderManagement.TabIndex = 40;
            this.buttonOrderManagement.Text = " Siparişleri Yönet";
            this.buttonOrderManagement.UseVisualStyleBackColor = false;
            this.buttonOrderManagement.Click += new System.EventHandler(this.buttonOrderManagement_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.datagridviewShowActiveOrder);
            this.panel1.Controls.Add(this.labelActiveOrder);
            this.panel1.Location = new System.Drawing.Point(16, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 350);
            this.panel1.TabIndex = 43;
            // 
            // datagridviewShowActiveOrder
            // 
            this.datagridviewShowActiveOrder.AllowUserToAddRows = false;
            this.datagridviewShowActiveOrder.AllowUserToDeleteRows = false;
            this.datagridviewShowActiveOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewShowActiveOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.datagridviewShowActiveOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewShowActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewShowActiveOrder.DefaultCellStyle = dataGridViewCellStyle11;
            this.datagridviewShowActiveOrder.EnableHeadersVisualStyles = false;
            this.datagridviewShowActiveOrder.Location = new System.Drawing.Point(10, 36);
            this.datagridviewShowActiveOrder.Name = "datagridviewShowActiveOrder";
            this.datagridviewShowActiveOrder.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewShowActiveOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.datagridviewShowActiveOrder.Size = new System.Drawing.Size(560, 292);
            this.datagridviewShowActiveOrder.TabIndex = 4;
            // 
            // labelActiveOrder
            // 
            this.labelActiveOrder.AutoSize = true;
            this.labelActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelActiveOrder.Location = new System.Drawing.Point(18, 14);
            this.labelActiveOrder.Name = "labelActiveOrder";
            this.labelActiveOrder.Size = new System.Drawing.Size(114, 19);
            this.labelActiveOrder.TabIndex = 3;
            this.labelActiveOrder.Text = "Aktif Siparişler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.comboBoxActiveOrderTable);
            this.panel2.Controls.Add(this.labelOrderTable);
            this.panel2.Controls.Add(this.buttonClearActiveOrder);
            this.panel2.Controls.Add(this.buttonRemoveActiveOrder);
            this.panel2.Controls.Add(this.buttonAddActiveOrder);
            this.panel2.Controls.Add(this.labelActiveOrderPrice);
            this.panel2.Controls.Add(this.labelOrderPrice);
            this.panel2.Controls.Add(this.labelOrderQuantity);
            this.panel2.Controls.Add(this.numericupdownActiveOrderQuantity);
            this.panel2.Controls.Add(this.labelActiveFoodName);
            this.panel2.Controls.Add(this.labelOrderName);
            this.panel2.Controls.Add(this.comboboxActiveOrderFoodID);
            this.panel2.Controls.Add(this.labelFoodID);
            this.panel2.Controls.Add(this.listboxOrderDetail);
            this.panel2.Controls.Add(this.labelOrderProductType);
            this.panel2.Location = new System.Drawing.Point(16, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 274);
            this.panel2.TabIndex = 44;
            // 
            // buttonClearActiveOrder
            // 
            this.buttonClearActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonClearActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonClearActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonClearActiveOrder.Location = new System.Drawing.Point(400, 207);
            this.buttonClearActiveOrder.Name = "buttonClearActiveOrder";
            this.buttonClearActiveOrder.Size = new System.Drawing.Size(138, 46);
            this.buttonClearActiveOrder.TabIndex = 20;
            this.buttonClearActiveOrder.Text = "Temizle";
            this.buttonClearActiveOrder.UseVisualStyleBackColor = false;
            // 
            // buttonRemoveActiveOrder
            // 
            this.buttonRemoveActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonRemoveActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonRemoveActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRemoveActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonRemoveActiveOrder.Location = new System.Drawing.Point(222, 207);
            this.buttonRemoveActiveOrder.Name = "buttonRemoveActiveOrder";
            this.buttonRemoveActiveOrder.Size = new System.Drawing.Size(138, 46);
            this.buttonRemoveActiveOrder.TabIndex = 19;
            this.buttonRemoveActiveOrder.Text = "Kaldır";
            this.buttonRemoveActiveOrder.UseVisualStyleBackColor = false;
            // 
            // buttonAddActiveOrder
            // 
            this.buttonAddActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonAddActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonAddActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonAddActiveOrder.Location = new System.Drawing.Point(37, 207);
            this.buttonAddActiveOrder.Name = "buttonAddActiveOrder";
            this.buttonAddActiveOrder.Size = new System.Drawing.Size(138, 46);
            this.buttonAddActiveOrder.TabIndex = 18;
            this.buttonAddActiveOrder.Text = "Ekle";
            this.buttonAddActiveOrder.UseVisualStyleBackColor = false;
            this.buttonAddActiveOrder.Click += new System.EventHandler(this.buttonAddActiveOrder_Click);
            // 
            // labelActiveOrderPrice
            // 
            this.labelActiveOrderPrice.AutoSize = true;
            this.labelActiveOrderPrice.Location = new System.Drawing.Point(100, 160);
            this.labelActiveOrderPrice.Name = "labelActiveOrderPrice";
            this.labelActiveOrderPrice.Size = new System.Drawing.Size(36, 19);
            this.labelActiveOrderPrice.TabIndex = 17;
            this.labelActiveOrderPrice.Text = "100";
            // 
            // labelOrderPrice
            // 
            this.labelOrderPrice.AutoSize = true;
            this.labelOrderPrice.Location = new System.Drawing.Point(33, 160);
            this.labelOrderPrice.Name = "labelOrderPrice";
            this.labelOrderPrice.Size = new System.Drawing.Size(58, 19);
            this.labelOrderPrice.TabIndex = 16;
            this.labelOrderPrice.Text = "Tutar : ";
            // 
            // labelOrderQuantity
            // 
            this.labelOrderQuantity.AutoSize = true;
            this.labelOrderQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderQuantity.Location = new System.Drawing.Point(341, 103);
            this.labelOrderQuantity.Name = "labelOrderQuantity";
            this.labelOrderQuantity.Size = new System.Drawing.Size(54, 19);
            this.labelOrderQuantity.TabIndex = 15;
            this.labelOrderQuantity.Text = "Adet: ";
            // 
            // numericupdownActiveOrderQuantity
            // 
            this.numericupdownActiveOrderQuantity.Location = new System.Drawing.Point(401, 101);
            this.numericupdownActiveOrderQuantity.Name = "numericupdownActiveOrderQuantity";
            this.numericupdownActiveOrderQuantity.Size = new System.Drawing.Size(137, 27);
            this.numericupdownActiveOrderQuantity.TabIndex = 14;
            // 
            // labelActiveFoodName
            // 
            this.labelActiveFoodName.AutoSize = true;
            this.labelActiveFoodName.Location = new System.Drawing.Point(100, 92);
            this.labelActiveFoodName.Name = "labelActiveFoodName";
            this.labelActiveFoodName.Size = new System.Drawing.Size(99, 19);
            this.labelActiveFoodName.TabIndex = 13;
            this.labelActiveFoodName.Text = "Test Product";
            // 
            // labelOrderName
            // 
            this.labelOrderName.AutoSize = true;
            this.labelOrderName.Location = new System.Drawing.Point(18, 92);
            this.labelOrderName.Name = "labelOrderName";
            this.labelOrderName.Size = new System.Drawing.Size(76, 19);
            this.labelOrderName.TabIndex = 12;
            this.labelOrderName.Text = "Yemek : ";
            // 
            // comboboxActiveOrderFoodID
            // 
            this.comboboxActiveOrderFoodID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxActiveOrderFoodID.DisplayMember = "department_name";
            this.comboboxActiveOrderFoodID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxActiveOrderFoodID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboboxActiveOrderFoodID.FormattingEnabled = true;
            this.comboboxActiveOrderFoodID.Location = new System.Drawing.Point(401, 30);
            this.comboboxActiveOrderFoodID.Name = "comboboxActiveOrderFoodID";
            this.comboboxActiveOrderFoodID.Size = new System.Drawing.Size(137, 27);
            this.comboboxActiveOrderFoodID.TabIndex = 11;
            this.comboboxActiveOrderFoodID.ValueMember = "department_id";
            this.comboboxActiveOrderFoodID.SelectedIndexChanged += new System.EventHandler(this.comboboxActiveOrderFoodID_SelectedIndexChanged);
            // 
            // labelFoodID
            // 
            this.labelFoodID.AutoSize = true;
            this.labelFoodID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFoodID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelFoodID.Location = new System.Drawing.Point(304, 33);
            this.labelFoodID.Name = "labelFoodID";
            this.labelFoodID.Size = new System.Drawing.Size(91, 19);
            this.labelFoodID.TabIndex = 10;
            this.labelFoodID.Text = "Yemek ID: ";
            // 
            // listboxOrderDetail
            // 
            this.listboxOrderDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listboxOrderDetail.DisplayMember = "department_name";
            this.listboxOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listboxOrderDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxOrderDetail.FormattingEnabled = true;
            this.listboxOrderDetail.Items.AddRange(new object[] {
            "Avantaj Menüleri",
            "Aperatifler",
            "Pizza",
            "Burger",
            "Kahvaltı",
            "Makarna",
            "Döner",
            "Tavuk Tabağı",
            "Tatlılar",
            "Soğuk İçecekler",
            "Sıcak İçecekler",
            "Kokteyl"});
            this.listboxOrderDetail.Location = new System.Drawing.Point(98, 30);
            this.listboxOrderDetail.Name = "listboxOrderDetail";
            this.listboxOrderDetail.Size = new System.Drawing.Size(137, 27);
            this.listboxOrderDetail.TabIndex = 9;
            this.listboxOrderDetail.ValueMember = "department_id";
            this.listboxOrderDetail.SelectedIndexChanged += new System.EventHandler(this.listboxOrderDetail_SelectedIndexChanged);
            // 
            // labelOrderProductType
            // 
            this.labelOrderProductType.AutoSize = true;
            this.labelOrderProductType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderProductType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderProductType.Location = new System.Drawing.Point(33, 33);
            this.labelOrderProductType.Name = "labelOrderProductType";
            this.labelOrderProductType.Size = new System.Drawing.Size(43, 19);
            this.labelOrderProductType.TabIndex = 4;
            this.labelOrderProductType.Text = "Tür : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.buttonReceiptActiveOrder);
            this.panel3.Controls.Add(this.buttonPayActiveOrder);
            this.panel3.Controls.Add(this.labelOrderChange);
            this.panel3.Controls.Add(this.labelActiveOrderChange);
            this.panel3.Controls.Add(this.labelActiveOrderAmount);
            this.panel3.Controls.Add(this.labelOrderPrices);
            this.panel3.Controls.Add(this.labelOrderActivePrice);
            this.panel3.Controls.Add(this.labelTotalOrder);
            this.panel3.Controls.Add(this.labelOrderAmounts);
            this.panel3.Controls.Add(this.datagridviewShowTotalOrder);
            this.panel3.Location = new System.Drawing.Point(600, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 630);
            this.panel3.TabIndex = 45;
            // 
            // buttonReceiptActiveOrder
            // 
            this.buttonReceiptActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonReceiptActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReceiptActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonReceiptActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReceiptActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonReceiptActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonReceiptActiveOrder.Location = new System.Drawing.Point(8, 564);
            this.buttonReceiptActiveOrder.Name = "buttonReceiptActiveOrder";
            this.buttonReceiptActiveOrder.Size = new System.Drawing.Size(327, 40);
            this.buttonReceiptActiveOrder.TabIndex = 24;
            this.buttonReceiptActiveOrder.Text = "FATURA";
            this.buttonReceiptActiveOrder.UseVisualStyleBackColor = false;
            // 
            // buttonPayActiveOrder
            // 
            this.buttonPayActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonPayActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonPayActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPayActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonPayActiveOrder.Location = new System.Drawing.Point(8, 512);
            this.buttonPayActiveOrder.Name = "buttonPayActiveOrder";
            this.buttonPayActiveOrder.Size = new System.Drawing.Size(327, 40);
            this.buttonPayActiveOrder.TabIndex = 23;
            this.buttonPayActiveOrder.Text = "ÖDE";
            this.buttonPayActiveOrder.UseVisualStyleBackColor = false;
            // 
            // labelOrderChange
            // 
            this.labelOrderChange.AutoSize = true;
            this.labelOrderChange.Location = new System.Drawing.Point(200, 459);
            this.labelOrderChange.Name = "labelOrderChange";
            this.labelOrderChange.Size = new System.Drawing.Size(18, 19);
            this.labelOrderChange.TabIndex = 22;
            this.labelOrderChange.Text = "0";
            // 
            // labelActiveOrderChange
            // 
            this.labelActiveOrderChange.AutoSize = true;
            this.labelActiveOrderChange.Location = new System.Drawing.Point(99, 459);
            this.labelActiveOrderChange.Name = "labelActiveOrderChange";
            this.labelActiveOrderChange.Size = new System.Drawing.Size(92, 19);
            this.labelActiveOrderChange.TabIndex = 21;
            this.labelActiveOrderChange.Text = "Pasa üstü : ";
            // 
            // labelActiveOrderAmount
            // 
            this.labelActiveOrderAmount.AutoSize = true;
            this.labelActiveOrderAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelActiveOrderAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelActiveOrderAmount.Location = new System.Drawing.Point(132, 416);
            this.labelActiveOrderAmount.Name = "labelActiveOrderAmount";
            this.labelActiveOrderAmount.Size = new System.Drawing.Size(57, 19);
            this.labelActiveOrderAmount.TabIndex = 20;
            this.labelActiveOrderAmount.Text = "Total : ";
            // 
            // labelOrderPrices
            // 
            this.labelOrderPrices.AutoSize = true;
            this.labelOrderPrices.Location = new System.Drawing.Point(200, 375);
            this.labelOrderPrices.Name = "labelOrderPrices";
            this.labelOrderPrices.Size = new System.Drawing.Size(36, 19);
            this.labelOrderPrices.TabIndex = 19;
            this.labelOrderPrices.Text = "100";
            // 
            // labelOrderActivePrice
            // 
            this.labelOrderActivePrice.AutoSize = true;
            this.labelOrderActivePrice.Location = new System.Drawing.Point(133, 375);
            this.labelOrderActivePrice.Name = "labelOrderActivePrice";
            this.labelOrderActivePrice.Size = new System.Drawing.Size(58, 19);
            this.labelOrderActivePrice.TabIndex = 18;
            this.labelOrderActivePrice.Text = "Tutar : ";
            // 
            // labelTotalOrder
            // 
            this.labelTotalOrder.AutoSize = true;
            this.labelTotalOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelTotalOrder.Location = new System.Drawing.Point(4, 14);
            this.labelTotalOrder.Name = "labelTotalOrder";
            this.labelTotalOrder.Size = new System.Drawing.Size(66, 19);
            this.labelTotalOrder.TabIndex = 4;
            this.labelTotalOrder.Text = "Sipariş: ";
            // 
            // labelOrderAmounts
            // 
            this.labelOrderAmounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelOrderAmounts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderAmounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderAmounts.Location = new System.Drawing.Point(204, 416);
            this.labelOrderAmounts.Multiline = true;
            this.labelOrderAmounts.Name = "labelOrderAmounts";
            this.labelOrderAmounts.Size = new System.Drawing.Size(131, 22);
            this.labelOrderAmounts.TabIndex = 5;
            // 
            // datagridviewShowTotalOrder
            // 
            this.datagridviewShowTotalOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.datagridviewShowTotalOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewShowTotalOrder.Location = new System.Drawing.Point(8, 36);
            this.datagridviewShowTotalOrder.Name = "datagridviewShowTotalOrder";
            this.datagridviewShowTotalOrder.Size = new System.Drawing.Size(335, 314);
            this.datagridviewShowTotalOrder.TabIndex = 0;
            // 
            // comboBoxActiveOrderTable
            // 
            this.comboBoxActiveOrderTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxActiveOrderTable.DisplayMember = "department_name";
            this.comboBoxActiveOrderTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxActiveOrderTable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxActiveOrderTable.FormattingEnabled = true;
            this.comboBoxActiveOrderTable.Items.AddRange(new object[] {
            "Hazırlanıyor",
            "Hazır",
            "Tamamlandı"});
            this.comboBoxActiveOrderTable.Location = new System.Drawing.Point(401, 160);
            this.comboBoxActiveOrderTable.Name = "comboBoxActiveOrderTable";
            this.comboBoxActiveOrderTable.Size = new System.Drawing.Size(137, 27);
            this.comboBoxActiveOrderTable.TabIndex = 22;
            this.comboBoxActiveOrderTable.ValueMember = "department_id";
            // 
            // labelOrderTable
            // 
            this.labelOrderTable.AutoSize = true;
            this.labelOrderTable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderTable.Location = new System.Drawing.Point(336, 163);
            this.labelOrderTable.Name = "labelOrderTable";
            this.labelOrderTable.Size = new System.Drawing.Size(59, 19);
            this.labelOrderTable.TabIndex = 21;
            this.labelOrderTable.Text = "Masa :";
            // 
            // formOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOrderManagement);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formOrder";
            this.Size = new System.Drawing.Size(962, 800);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowActiveOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownActiveOrderQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowTotalOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.TextBox textboxSearch2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOrderManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelActiveOrder;
        private System.Windows.Forms.DataGridView datagridviewShowActiveOrder;
        private System.Windows.Forms.DataGridView datagridviewShowTotalOrder;
        private System.Windows.Forms.Label labelTotalOrder;
        private System.Windows.Forms.TextBox labelOrderAmounts;
        private System.Windows.Forms.Label labelOrderProductType;
        private System.Windows.Forms.NumericUpDown numericupdownActiveOrderQuantity;
        private System.Windows.Forms.Label labelActiveFoodName;
        private System.Windows.Forms.Label labelOrderName;
        private System.Windows.Forms.ComboBox comboboxActiveOrderFoodID;
        private System.Windows.Forms.Label labelFoodID;
        private System.Windows.Forms.ComboBox listboxOrderDetail;
        private System.Windows.Forms.Label labelActiveOrderPrice;
        private System.Windows.Forms.Label labelOrderPrice;
        private System.Windows.Forms.Label labelOrderQuantity;
        private System.Windows.Forms.Button buttonClearActiveOrder;
        private System.Windows.Forms.Button buttonRemoveActiveOrder;
        private System.Windows.Forms.Button buttonAddActiveOrder;
        private System.Windows.Forms.Label labelActiveOrderAmount;
        private System.Windows.Forms.Label labelOrderPrices;
        private System.Windows.Forms.Label labelOrderActivePrice;
        private System.Windows.Forms.Button buttonReceiptActiveOrder;
        private System.Windows.Forms.Button buttonPayActiveOrder;
        private System.Windows.Forms.Label labelOrderChange;
        private System.Windows.Forms.Label labelActiveOrderChange;
        private System.Windows.Forms.ComboBox comboBoxActiveOrderTable;
        private System.Windows.Forms.Label labelOrderTable;
    }
}
