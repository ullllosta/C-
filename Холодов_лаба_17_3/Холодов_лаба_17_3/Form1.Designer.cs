namespace Холодов_лаба_17_3
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
            this.components = new System.ComponentModel.Container();
            this.panelGraf = new System.Windows.Forms.FlowLayoutPanel();
            this.timerChangeColor = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.liftZoneColorChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightZoneColorChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothZoneColorChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerChangeFontStyle = new System.Windows.Forms.Timer(this.components);
            this.btnStartAnimation = new System.Windows.Forms.Button();
            this.btnStopAnimation = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGraf
            // 
            this.panelGraf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelGraf.Location = new System.Drawing.Point(126, 66);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(533, 353);
            this.panelGraf.TabIndex = 0;
            this.panelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraf_Paint);
            this.panelGraf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelGraf_MouseDoubleClick);
            this.panelGraf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGraf_MouseDown);
            this.panelGraf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGraf_MouseMove);
            // 
            // timerChangeColor
            // 
            this.timerChangeColor.Interval = 10;
            this.timerChangeColor.Tick += new System.EventHandler(this.timerChangeColor_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liftZoneColorChangeToolStripMenuItem,
            this.rightZoneColorChangeToolStripMenuItem,
            this.bothZoneColorChangeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(280, 76);
            // 
            // liftZoneColorChangeToolStripMenuItem
            // 
            this.liftZoneColorChangeToolStripMenuItem.Name = "liftZoneColorChangeToolStripMenuItem";
            this.liftZoneColorChangeToolStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.liftZoneColorChangeToolStripMenuItem.Text = "&Поменять цвет левой зоны";
            this.liftZoneColorChangeToolStripMenuItem.Click += new System.EventHandler(this.leftZoneColorChangeToolStripMenuItem_Click);
            // 
            // rightZoneColorChangeToolStripMenuItem
            // 
            this.rightZoneColorChangeToolStripMenuItem.Name = "rightZoneColorChangeToolStripMenuItem";
            this.rightZoneColorChangeToolStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.rightZoneColorChangeToolStripMenuItem.Text = "&Поменять цвет правой зоны";
            this.rightZoneColorChangeToolStripMenuItem.Click += new System.EventHandler(this.rightZoneColorChangeToolStripMenuItem_Click);
            // 
            // bothZoneColorChangeToolStripMenuItem
            // 
            this.bothZoneColorChangeToolStripMenuItem.Name = "bothZoneColorChangeToolStripMenuItem";
            this.bothZoneColorChangeToolStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.bothZoneColorChangeToolStripMenuItem.Text = "&Поменять цвет обеих зон";
            this.bothZoneColorChangeToolStripMenuItem.Click += new System.EventHandler(this.bothZoneColorChangeToolStripMenuItem_Click);
            // 
            // timerChangeFontStyle
            // 
            this.timerChangeFontStyle.Tick += new System.EventHandler(this.timerChangeFontStyle_Tick);
            // 
            // btnStartAnimation
            // 
            this.btnStartAnimation.Location = new System.Drawing.Point(12, 12);
            this.btnStartAnimation.Name = "btnStartAnimation";
            this.btnStartAnimation.Size = new System.Drawing.Size(75, 23);
            this.btnStartAnimation.TabIndex = 1;
            this.btnStartAnimation.Text = "Старт";
            this.btnStartAnimation.UseVisualStyleBackColor = true;
            this.btnStartAnimation.Click += new System.EventHandler(this.btnStartAnimation_Click);
            // 
            // btnStopAnimation
            // 
            this.btnStopAnimation.Location = new System.Drawing.Point(126, 12);
            this.btnStopAnimation.Name = "btnStopAnimation";
            this.btnStopAnimation.Size = new System.Drawing.Size(75, 23);
            this.btnStopAnimation.TabIndex = 2;
            this.btnStopAnimation.Text = "Стоп";
            this.btnStopAnimation.UseVisualStyleBackColor = true;
            this.btnStopAnimation.Click += new System.EventHandler(this.btnStopAnimation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnStopAnimation);
            this.Controls.Add(this.btnStartAnimation);
            this.Controls.Add(this.panelGraf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelGraf;
        private System.Windows.Forms.Timer timerChangeColor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem liftZoneColorChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightZoneColorChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothZoneColorChangeToolStripMenuItem;
        private System.Windows.Forms.Timer timerChangeFontStyle;
        private System.Windows.Forms.Button btnStartAnimation;
        private System.Windows.Forms.Button btnStopAnimation;
    }
}

