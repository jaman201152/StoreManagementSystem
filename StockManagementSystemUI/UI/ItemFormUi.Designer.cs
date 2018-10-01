namespace StockManagementSystemUI.Item.UI
{
    partial class ItemFormUi
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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recorderTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemNmeLevel = new System.Windows.Forms.Label();
            this.reorderlevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(212, 52);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(179, 26);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystemUI.Model.Category);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(212, 149);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(179, 24);
            this.itemNameTextBox.TabIndex = 2;
            this.itemNameTextBox.TextChanged += new System.EventHandler(this.itemNameTextBox_TextChanged);
            this.itemNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemNameTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(212, 101);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(179, 26);
            this.companyComboBox.TabIndex = 4;
            this.companyComboBox.ValueMember = "Id";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystemUI.Model.Company);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reorder Label";
            // 
            // recorderTextBox
            // 
            this.recorderTextBox.Location = new System.Drawing.Point(212, 199);
            this.recorderTextBox.Name = "recorderTextBox";
            this.recorderTextBox.Size = new System.Drawing.Size(179, 24);
            this.recorderTextBox.TabIndex = 7;
            this.recorderTextBox.TextChanged += new System.EventHandler(this.recorderTextBox_TextChanged);
            this.recorderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recorderTextBox_KeyPress);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(212, 241);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 31);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(315, 241);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(76, 31);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemNmeLevel);
            this.groupBox1.Controls.Add(this.reorderlevel);
            this.groupBox1.Controls.Add(this.companyComboBox);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.recorderTextBox);
            this.groupBox1.Controls.Add(this.itemNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 312);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Item ";
            // 
            // itemNmeLevel
            // 
            this.itemNmeLevel.AutoSize = true;
            this.itemNmeLevel.Location = new System.Drawing.Point(398, 155);
            this.itemNmeLevel.Name = "itemNmeLevel";
            this.itemNmeLevel.Size = new System.Drawing.Size(0, 18);
            this.itemNmeLevel.TabIndex = 15;
            // 
            // reorderlevel
            // 
            this.reorderlevel.AutoSize = true;
            this.reorderlevel.Location = new System.Drawing.Point(398, 190);
            this.reorderlevel.Name = "reorderlevel";
            this.reorderlevel.Size = new System.Drawing.Size(0, 18);
            this.reorderlevel.TabIndex = 14;
            // 
            // ItemFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 397);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemFormUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemFormUi";
            this.Load += new System.EventHandler(this.ItemFormUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recorderTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label reorderlevel;
        private System.Windows.Forms.Label itemNmeLevel;
    }
}