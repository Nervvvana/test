
namespace Kursovoy_OOP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProjectName = new System.Windows.Forms.Label();
            this.ProductsAccountingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SalesReportButtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectName
            // 
            this.ProjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProjectName.AutoSize = true;
            this.ProjectName.BackColor = System.Drawing.Color.Transparent;
            this.ProjectName.Font = new System.Drawing.Font("Impact", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.ProjectName.Location = new System.Drawing.Point(126, 92);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(545, 60);
            this.ProjectName.TabIndex = 2;
            this.ProjectName.Text = "Магазин автозапчастей";
            // 
            // ProductsAccountingButton
            // 
            this.ProductsAccountingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProductsAccountingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductsAccountingButton.Location = new System.Drawing.Point(84, 362);
            this.ProductsAccountingButton.Name = "ProductsAccountingButton";
            this.ProductsAccountingButton.Size = new System.Drawing.Size(153, 40);
            this.ProductsAccountingButton.TabIndex = 3;
            this.ProductsAccountingButton.Text = "Учет товаров";
            this.ProductsAccountingButton.UseVisualStyleBackColor = false;
            this.ProductsAccountingButton.Click += new System.EventHandler(this.ProductsAccountingButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.Location = new System.Drawing.Point(573, 357);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(153, 43);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SalesReportButtton
            // 
            this.SalesReportButtton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SalesReportButtton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalesReportButtton.Location = new System.Drawing.Point(324, 358);
            this.SalesReportButtton.Name = "SalesReportButtton";
            this.SalesReportButtton.Size = new System.Drawing.Size(153, 44);
            this.SalesReportButtton.TabIndex = 5;
            this.SalesReportButtton.Text = "Отчет о продажах";
            this.SalesReportButtton.UseVisualStyleBackColor = false;
            this.SalesReportButtton.Click += new System.EventHandler(this.SalesReportButtton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursovoy_OOP.Properties.Resources.mainBG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesReportButtton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProductsAccountingButton);
            this.Controls.Add(this.ProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.Button ProductsAccountingButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SalesReportButtton;
    }
}