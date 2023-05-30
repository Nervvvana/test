
namespace Kursovoy_OOP
{
    partial class SalesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.salesReportTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToMainFormButton = new System.Windows.Forms.Button();
            this.DeleteSaleButton = new System.Windows.Forms.Button();
            this.ClearSalesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // salesReportTable
            // 
            this.salesReportTable.AllowUserToAddRows = false;
            this.salesReportTable.AllowUserToDeleteRows = false;
            this.salesReportTable.AllowUserToResizeColumns = false;
            this.salesReportTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salesReportTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.salesReportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesReportTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesReportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.salesReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesReportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.salesReportTable.Location = new System.Drawing.Point(12, 12);
            this.salesReportTable.MultiSelect = false;
            this.salesReportTable.Name = "salesReportTable";
            this.salesReportTable.ReadOnly = true;
            this.salesReportTable.RowHeadersWidth = 51;
            this.salesReportTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.salesReportTable.RowTemplate.Height = 24;
            this.salesReportTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesReportTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesReportTable.Size = new System.Drawing.Size(864, 335);
            this.salesReportTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата продажи";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Время продажи";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Серийный номер";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Название детали";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Производитель";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ToMainFormButton
            // 
            this.ToMainFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToMainFormButton.Location = new System.Drawing.Point(735, 366);
            this.ToMainFormButton.Name = "ToMainFormButton";
            this.ToMainFormButton.Size = new System.Drawing.Size(141, 46);
            this.ToMainFormButton.TabIndex = 1;
            this.ToMainFormButton.Text = "Назад";
            this.ToMainFormButton.UseVisualStyleBackColor = true;
            this.ToMainFormButton.Click += new System.EventHandler(this.ToMainFormButton_Click);
            // 
            // DeleteSaleButton
            // 
            this.DeleteSaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSaleButton.Location = new System.Drawing.Point(12, 366);
            this.DeleteSaleButton.Name = "DeleteSaleButton";
            this.DeleteSaleButton.Size = new System.Drawing.Size(141, 46);
            this.DeleteSaleButton.TabIndex = 2;
            this.DeleteSaleButton.Text = "Удалить запись";
            this.DeleteSaleButton.UseVisualStyleBackColor = true;
            this.DeleteSaleButton.Click += new System.EventHandler(this.DeleteSaleButton_Click);
            // 
            // ClearSalesButton
            // 
            this.ClearSalesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearSalesButton.Location = new System.Drawing.Point(172, 366);
            this.ClearSalesButton.Name = "ClearSalesButton";
            this.ClearSalesButton.Size = new System.Drawing.Size(141, 46);
            this.ClearSalesButton.TabIndex = 3;
            this.ClearSalesButton.Text = "Очистить все";
            this.ClearSalesButton.UseVisualStyleBackColor = true;
            this.ClearSalesButton.Click += new System.EventHandler(this.ClearSalesButton_Click);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(888, 431);
            this.Controls.Add(this.ClearSalesButton);
            this.Controls.Add(this.DeleteSaleButton);
            this.Controls.Add(this.ToMainFormButton);
            this.Controls.Add(this.salesReportTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о продажах";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salesReportTable;
        private System.Windows.Forms.Button ToMainFormButton;
        private System.Windows.Forms.Button DeleteSaleButton;
        private System.Windows.Forms.Button ClearSalesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}