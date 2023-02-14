namespace пз5
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
            this.dgrRaw = new System.Windows.Forms.DataGridView();
            this.dgrSummary = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrRaw
            // 
            this.dgrRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrRaw.Location = new System.Drawing.Point(12, 12);
            this.dgrRaw.Name = "dgrRaw";
            this.dgrRaw.RowHeadersWidth = 51;
            this.dgrRaw.RowTemplate.Height = 24;
            this.dgrRaw.Size = new System.Drawing.Size(688, 398);
            this.dgrRaw.TabIndex = 0;
            // 
            // dgrSummary
            // 
            this.dgrSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSummary.Location = new System.Drawing.Point(706, 12);
            this.dgrSummary.Name = "dgrSummary";
            this.dgrSummary.RowHeadersWidth = 51;
            this.dgrSummary.RowTemplate.Height = 24;
            this.dgrSummary.Size = new System.Drawing.Size(332, 398);
            this.dgrSummary.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDlg";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgrSummary);
            this.Controls.Add(this.dgrRaw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrRaw;
        private System.Windows.Forms.DataGridView dgrSummary;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

