namespace StockManagementSystemUI.StokOut.UI
{
    partial class StockOutUi
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
            this.components = new System.ComponentModel.Container();
            this.stockOutQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.availableQuantityLabel = new System.Windows.Forms.Label();
            this.reOrderLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemStockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOutQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellButton = new System.Windows.Forms.Button();
            this.LostButton = new System.Windows.Forms.Button();
            this.DamageButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reOrderAvailableQtyMsgLabel = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockOutDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockOutQuantityTextBox
            // 
            this.stockOutQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutQuantityTextBox.Location = new System.Drawing.Point(221, 218);
            this.stockOutQuantityTextBox.Name = "stockOutQuantityTextBox";
            this.stockOutQuantityTextBox.Size = new System.Drawing.Size(193, 22);
            this.stockOutQuantityTextBox.TabIndex = 36;
            this.stockOutQuantityTextBox.TextChanged += new System.EventHandler(this.stockOutQuantityTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Stock Out Quantity";
            // 
            // availableQuantityLabel
            // 
            this.availableQuantityLabel.AutoSize = true;
            this.availableQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQuantityLabel.Location = new System.Drawing.Point(218, 185);
            this.availableQuantityLabel.Name = "availableQuantityLabel";
            this.availableQuantityLabel.Size = new System.Drawing.Size(49, 16);
            this.availableQuantityLabel.TabIndex = 34;
            this.availableQuantityLabel.Text = "<view>";
            // 
            // reOrderLabel
            // 
            this.reOrderLabel.AutoSize = true;
            this.reOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reOrderLabel.Location = new System.Drawing.Point(218, 156);
            this.reOrderLabel.Name = "reOrderLabel";
            this.reOrderLabel.Size = new System.Drawing.Size(49, 16);
            this.reOrderLabel.TabIndex = 33;
            this.reOrderLabel.Text = "<view>";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(221, 111);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(193, 26);
            this.itemComboBox.TabIndex = 32;
            this.itemComboBox.ValueMember = "Id";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystemUI.Model.Item);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Item";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(221, 276);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(77, 31);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.Text = "Add";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Reorder Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Available Quantity";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(221, 33);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(193, 26);
            this.companyComboBox.TabIndex = 27;
            this.companyComboBox.ValueMember = "Id";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystemUI.Model.Company);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(130, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(134, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(221, 70);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(193, 26);
            this.categoryComboBox.TabIndex = 24;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystemUI.Model.Category);
            // 
            // itemStockOutDataGridView
            // 
            this.itemStockOutDataGridView.AllowUserToAddRows = false;
            this.itemStockOutDataGridView.AllowUserToDeleteRows = false;
            this.itemStockOutDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemStockOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemStockOutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.ItemName,
            this.CompanyName,
            this.CategoryName,
            this.StockOutQuantity});
            this.itemStockOutDataGridView.Location = new System.Drawing.Point(12, 345);
            this.itemStockOutDataGridView.Name = "itemStockOutDataGridView";
            this.itemStockOutDataGridView.ReadOnly = true;
            this.itemStockOutDataGridView.Size = new System.Drawing.Size(735, 189);
            this.itemStockOutDataGridView.TabIndex = 37;
            this.itemStockOutDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.itemStockOutDataGridView_RowPostPaint);
            // 
            // SL
            // 
            this.SL.FillWeight = 76.14214F;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.FillWeight = 105.9645F;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.FillWeight = 105.9645F;
            this.CompanyName.HeaderText = "Company";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.FillWeight = 105.9645F;
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // StockOutQuantity
            // 
            this.StockOutQuantity.DataPropertyName = "StockOutQuantity";
            this.StockOutQuantity.FillWeight = 105.9645F;
            this.StockOutQuantity.HeaderText = "Quantity";
            this.StockOutQuantity.Name = "StockOutQuantity";
            this.StockOutQuantity.ReadOnly = true;
            // 
            // SellButton
            // 
            this.SellButton.BackColor = System.Drawing.Color.Transparent;
            this.SellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellButton.Location = new System.Drawing.Point(360, 542);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(96, 31);
            this.SellButton.TabIndex = 38;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = false;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // LostButton
            // 
            this.LostButton.BackColor = System.Drawing.Color.Transparent;
            this.LostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostButton.Location = new System.Drawing.Point(605, 542);
            this.LostButton.Name = "LostButton";
            this.LostButton.Size = new System.Drawing.Size(96, 31);
            this.LostButton.TabIndex = 40;
            this.LostButton.Text = "Lost";
            this.LostButton.UseVisualStyleBackColor = false;
            this.LostButton.Click += new System.EventHandler(this.LostButton_Click);
            // 
            // DamageButton
            // 
            this.DamageButton.BackColor = System.Drawing.Color.Transparent;
            this.DamageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageButton.Location = new System.Drawing.Point(485, 542);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(96, 31);
            this.DamageButton.TabIndex = 41;
            this.DamageButton.Text = "Damage";
            this.DamageButton.UseVisualStyleBackColor = false;
            this.DamageButton.Click += new System.EventHandler(this.DamageButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(337, 276);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 31);
            this.CancelButton.TabIndex = 42;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reOrderAvailableQtyMsgLabel);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.msgLabel);
            this.groupBox1.Controls.Add(this.stockOutQuantityTextBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.companyComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.availableQuantityLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.reOrderLabel);
            this.groupBox1.Controls.Add(this.itemComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(98, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 313);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Out ";
            // 
            // reOrderAvailableQtyMsgLabel
            // 
            this.reOrderAvailableQtyMsgLabel.AutoSize = true;
            this.reOrderAvailableQtyMsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reOrderAvailableQtyMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.reOrderAvailableQtyMsgLabel.Location = new System.Drawing.Point(407, 185);
            this.reOrderAvailableQtyMsgLabel.Name = "reOrderAvailableQtyMsgLabel";
            this.reOrderAvailableQtyMsgLabel.Size = new System.Drawing.Size(0, 16);
            this.reOrderAvailableQtyMsgLabel.TabIndex = 38;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel.ForeColor = System.Drawing.Color.Maroon;
            this.msgLabel.Location = new System.Drawing.Point(218, 243);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 16);
            this.msgLabel.TabIndex = 37;
            // 
            // StockOutUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DamageButton);
            this.Controls.Add(this.LostButton);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.itemStockOutDataGridView);
            this.Name = "StockOutUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokOutUi";
            this.Load += new System.EventHandler(this.StockOutUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockOutDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox stockOutQuantityTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label availableQuantityLabel;
        private System.Windows.Forms.Label reOrderLabel;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DataGridView itemStockOutDataGridView;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button LostButton;
        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Label reOrderAvailableQtyMsgLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOutQuantity;
    }
}