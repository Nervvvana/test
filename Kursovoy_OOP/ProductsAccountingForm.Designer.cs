
namespace Kursovoy_OOP
{
    partial class ProductsAccountingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsAccountingForm));
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.ToMainFormButton = new System.Windows.Forms.Button();
            this.CreateProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ClearProductsButton = new System.Windows.Forms.Button();
            this.SellProductButton = new System.Windows.Forms.Button();
            this.SearchProductButton = new System.Windows.Forms.Button();
            this.totalCountTextBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.StorageTimeAnalyseButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // productsTable
            // 
            this.productsTable.AllowUserToAddRows = false;
            this.productsTable.AllowUserToDeleteRows = false;
            this.productsTable.AllowUserToResizeColumns = false;
            this.productsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsTable.Location = new System.Drawing.Point(21, 34);
            this.productsTable.MultiSelect = false;
            this.productsTable.Name = "productsTable";
            this.productsTable.ReadOnly = true;
            this.productsTable.RowHeadersWidth = 51;
            this.productsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsTable.RowTemplate.Height = 24;
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(1077, 262);
            this.productsTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Серийный номер";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название детали";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Производитель";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Кол-во на складе";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Срок хранения, д";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Цена, руб";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Всего деталей";
            // 
            // filterLabel
            // 
            this.filterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(1204, 34);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(59, 17);
            this.filterLabel.TabIndex = 2;
            this.filterLabel.Text = "Фильтр";
            // 
            // filterComboBox
            // 
            this.filterComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Сериный номер",
            "Название детали",
            "Производитель",
            "Кол-во на складе",
            "Срок хранения",
            "Цена"});
            this.filterComboBox.Location = new System.Drawing.Point(1156, 102);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(160, 24);
            this.filterComboBox.TabIndex = 4;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterTextBox.Location = new System.Drawing.Point(1156, 64);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(160, 22);
            this.filterTextBox.TabIndex = 5;
            this.filterTextBox.TextChanged += new System.EventHandler(this.FilterTextChanged_Click);
            // 
            // ToMainFormButton
            // 
            this.ToMainFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToMainFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ToMainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainFormButton.Location = new System.Drawing.Point(1209, 333);
            this.ToMainFormButton.Name = "ToMainFormButton";
            this.ToMainFormButton.Size = new System.Drawing.Size(107, 29);
            this.ToMainFormButton.TabIndex = 9;
            this.ToMainFormButton.Text = "Назад";
            this.ToMainFormButton.UseVisualStyleBackColor = false;
            this.ToMainFormButton.Click += new System.EventHandler(this.ToMainFormButton_Click);
            // 
            // CreateProductButton
            // 
            this.CreateProductButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreateProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateProductButton.Location = new System.Drawing.Point(487, 318);
            this.CreateProductButton.Name = "CreateProductButton";
            this.CreateProductButton.Size = new System.Drawing.Size(143, 44);
            this.CreateProductButton.TabIndex = 10;
            this.CreateProductButton.Text = "Добавить деталь";
            this.CreateProductButton.UseVisualStyleBackColor = false;
            this.CreateProductButton.Click += new System.EventHandler(this.CreateProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProductButton.Location = new System.Drawing.Point(797, 318);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(143, 44);
            this.DeleteProductButton.TabIndex = 11;
            this.DeleteProductButton.Text = "Удалить деталь";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ClearProductsButton
            // 
            this.ClearProductsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearProductsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClearProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearProductsButton.Location = new System.Drawing.Point(955, 318);
            this.ClearProductsButton.Name = "ClearProductsButton";
            this.ClearProductsButton.Size = new System.Drawing.Size(143, 44);
            this.ClearProductsButton.TabIndex = 12;
            this.ClearProductsButton.Text = "Очистить все";
            this.ClearProductsButton.UseVisualStyleBackColor = false;
            this.ClearProductsButton.Click += new System.EventHandler(this.ClearProductsButton_Click);
            // 
            // SellProductButton
            // 
            this.SellProductButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SellProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SellProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellProductButton.Location = new System.Drawing.Point(175, 318);
            this.SellProductButton.Name = "SellProductButton";
            this.SellProductButton.Size = new System.Drawing.Size(143, 44);
            this.SellProductButton.TabIndex = 13;
            this.SellProductButton.Text = "Продать деталь";
            this.SellProductButton.UseVisualStyleBackColor = false;
            this.SellProductButton.Click += new System.EventHandler(this.SellProductButton_Click);
            // 
            // SearchProductButton
            // 
            this.SearchProductButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SearchProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchProductButton.Location = new System.Drawing.Point(21, 318);
            this.SearchProductButton.Name = "SearchProductButton";
            this.SearchProductButton.Size = new System.Drawing.Size(143, 44);
            this.SearchProductButton.TabIndex = 14;
            this.SearchProductButton.Text = "Найти деталь";
            this.SearchProductButton.UseVisualStyleBackColor = false;
            this.SearchProductButton.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // totalCountTextBox
            // 
            this.totalCountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalCountTextBox.Location = new System.Drawing.Point(128, 6);
            this.totalCountTextBox.Name = "totalCountTextBox";
            this.totalCountTextBox.ReadOnly = true;
            this.totalCountTextBox.Size = new System.Drawing.Size(93, 22);
            this.totalCountTextBox.TabIndex = 15;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.Location = new System.Drawing.Point(1156, 142);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(160, 39);
            this.FilterButton.TabIndex = 16;
            this.FilterButton.Text = "Фильтровать";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // StorageTimeAnalyseButton
            // 
            this.StorageTimeAnalyseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StorageTimeAnalyseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StorageTimeAnalyseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageTimeAnalyseButton.Location = new System.Drawing.Point(640, 318);
            this.StorageTimeAnalyseButton.Name = "StorageTimeAnalyseButton";
            this.StorageTimeAnalyseButton.Size = new System.Drawing.Size(143, 44);
            this.StorageTimeAnalyseButton.TabIndex = 17;
            this.StorageTimeAnalyseButton.Text = "Анализ сроков хранения";
            this.StorageTimeAnalyseButton.UseVisualStyleBackColor = false;
            this.StorageTimeAnalyseButton.Click += new System.EventHandler(this.StorageTimeAnalyseButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditProductButton.Location = new System.Drawing.Point(330, 318);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(143, 44);
            this.EditProductButton.TabIndex = 18;
            this.EditProductButton.Text = "Редактировать";
            this.EditProductButton.UseVisualStyleBackColor = false;
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // ProductsAccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1374, 402);
            this.Controls.Add(this.EditProductButton);
            this.Controls.Add(this.StorageTimeAnalyseButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.totalCountTextBox);
            this.Controls.Add(this.SearchProductButton);
            this.Controls.Add(this.SellProductButton);
            this.Controls.Add(this.ClearProductsButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.CreateProductButton);
            this.Controls.Add(this.ToMainFormButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsAccountingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет товаров";
            this.Load += new System.EventHandler(this.ProductsAccountingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToMainFormButton;
        private System.Windows.Forms.Button CreateProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ClearProductsButton;
        private System.Windows.Forms.Button SellProductButton;
        private System.Windows.Forms.Button SearchProductButton;
        private System.Windows.Forms.TextBox totalCountTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button StorageTimeAnalyseButton;
        private System.Windows.Forms.Button EditProductButton;
    }
}