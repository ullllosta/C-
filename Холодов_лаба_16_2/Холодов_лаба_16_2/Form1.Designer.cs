namespace Холодов_лаба_16_2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.srcTable = new System.Windows.Forms.DataGridView();
            this.btnLaodTable = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.maxMetrCostTable = new System.Windows.Forms.DataGridView();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.typeListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.srcTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMetrCostTable)).BeginInit();
            this.SuspendLayout();
            // 
            // srcTable
            // 
            this.srcTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.srcTable.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.srcTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.srcTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.srcTable.Location = new System.Drawing.Point(12, 12);
            this.srcTable.Name = "srcTable";
            this.srcTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.srcTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.srcTable.RowHeadersVisible = false;
            this.srcTable.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srcTable.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.srcTable.RowTemplate.Height = 24;
            this.srcTable.Size = new System.Drawing.Size(570, 209);
            this.srcTable.TabIndex = 0;
            // 
            // btnLaodTable
            // 
            this.btnLaodTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLaodTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaodTable.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLaodTable.Location = new System.Drawing.Point(12, 381);
            this.btnLaodTable.Name = "btnLaodTable";
            this.btnLaodTable.Size = new System.Drawing.Size(271, 39);
            this.btnLaodTable.TabIndex = 2;
            this.btnLaodTable.Text = "Заполнить таблицу";
            this.btnLaodTable.UseVisualStyleBackColor = false;
            this.btnLaodTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // maxMetrCostTable
            // 
            this.maxMetrCostTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.maxMetrCostTable.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.maxMetrCostTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxMetrCostTable.Location = new System.Drawing.Point(12, 251);
            this.maxMetrCostTable.Name = "maxMetrCostTable";
            this.maxMetrCostTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.maxMetrCostTable.RowHeadersVisible = false;
            this.maxMetrCostTable.RowHeadersWidth = 51;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxMetrCostTable.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.maxMetrCostTable.RowTemplate.Height = 24;
            this.maxMetrCostTable.Size = new System.Drawing.Size(570, 95);
            this.maxMetrCostTable.TabIndex = 4;
            // 
            // averageTextBox
            // 
            this.averageTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.averageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.averageTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageTextBox.Location = new System.Drawing.Point(949, 392);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(122, 21);
            this.averageTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(289, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Средняя стоимость 1 кв. м среди объктов типа ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Объект с максимальной стоимостью 1 кв. м:";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.Location = new System.Drawing.Point(1001, 12);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(70, 37);
            this.btnCloseApp.TabIndex = 8;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // typeListBox
            // 
            this.typeListBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.typeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.ItemHeight = 25;
            this.typeListBox.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Комната"});
            this.typeListBox.Location = new System.Drawing.Point(817, 363);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(126, 75);
            this.typeListBox.TabIndex = 9;
            this.typeListBox.SelectedIndexChanged += new System.EventHandler(this.typeListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.typeListBox);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.maxMetrCostTable);
            this.Controls.Add(this.btnLaodTable);
            this.Controls.Add(this.srcTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Недвижимость";
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.srcTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMetrCostTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView srcTable;
        private System.Windows.Forms.Button btnLaodTable;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView maxMetrCostTable;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.ListBox typeListBox;
    }
}

