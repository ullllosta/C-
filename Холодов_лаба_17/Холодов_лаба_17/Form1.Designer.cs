namespace Холодов_лаба_17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.panelGraf = new System.Windows.Forms.Panel();
            this.btnClearPanelGraf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "График функции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Параметры";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(12, 159);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(28, 16);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "a = ";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(12, 198);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(28, 16);
            this.labelP.TabIndex = 4;
            this.labelP.Text = "p = ";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(174, 159);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(27, 16);
            this.labelK.TabIndex = 5;
            this.labelK.Text = "k = ";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(174, 198);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(28, 16);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "b = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Цвет графика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Режим вывода";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(56, 156);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(73, 22);
            this.txtA.TabIndex = 9;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(56, 195);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(73, 22);
            this.txtP.TabIndex = 10;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(229, 156);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(73, 22);
            this.txtK.TabIndex = 11;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(229, 195);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(73, 22);
            this.txtB.TabIndex = 12;
            // 
            // btnRedraw
            // 
            this.btnRedraw.Location = new System.Drawing.Point(344, 40);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(131, 45);
            this.btnRedraw.TabIndex = 13;
            this.btnRedraw.Text = "Нарисовать график";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(521, 156);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(31, 23);
            this.btnChooseColor.TabIndex = 14;
            this.btnChooseColor.Text = "...";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // comboMode
            // 
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Items.AddRange(new object[] {
            "Точки",
            "Линия"});
            this.comboMode.Location = new System.Drawing.Point(521, 195);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(121, 24);
            this.comboMode.TabIndex = 15;
            this.comboMode.SelectedIndexChanged += new System.EventHandler(this.comboMode_SelectedIndexChanged);
            // 
            // panelGraf
            // 
            this.panelGraf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelGraf.Location = new System.Drawing.Point(15, 246);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(627, 425);
            this.panelGraf.TabIndex = 16;
            // 
            // btnClearPanelGraf
            // 
            this.btnClearPanelGraf.Location = new System.Drawing.Point(545, 40);
            this.btnClearPanelGraf.Name = "btnClearPanelGraf";
            this.btnClearPanelGraf.Size = new System.Drawing.Size(106, 45);
            this.btnClearPanelGraf.TabIndex = 17;
            this.btnClearPanelGraf.Text = "Очистить график";
            this.btnClearPanelGraf.UseVisualStyleBackColor = true;
            this.btnClearPanelGraf.Click += new System.EventHandler(this.btnClearPanelGraf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 675);
            this.Controls.Add(this.btnClearPanelGraf);
            this.Controls.Add(this.panelGraf);
            this.Controls.Add(this.comboMode);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.Panel panelGraf;
        private System.Windows.Forms.Button btnClearPanelGraf;
    }
}

