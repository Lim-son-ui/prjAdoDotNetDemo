
namespace 訂房系統
{
    partial class Frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.水平排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平排列ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直排列ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.階梯式排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關閉目前視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關閉所有視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(188, 54);
            this.toolStripButton4.Text = "toolStripButton1";
            this.toolStripButton4.Click += new System.EventHandler(this.show_productedit_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(188, 54);
            this.toolStripButton3.Text = "toolStripButton1";
            this.toolStripButton3.Click += new System.EventHandler(this.show_productlist_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(188, 54);
            this.toolStripButton2.Text = "toolStripButton1";
            this.toolStripButton2.Click += new System.EventHandler(this.form_close_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(188, 54);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平排列ToolStripMenuItem,
            this.垂直排列ToolStripMenuItem,
            this.檢示ToolStripMenuItem,
            this.視窗ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 水平排列ToolStripMenuItem
            // 
            this.水平排列ToolStripMenuItem.Name = "水平排列ToolStripMenuItem";
            this.水平排列ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.水平排列ToolStripMenuItem.Text = "檔案";
            this.水平排列ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // 垂直排列ToolStripMenuItem
            // 
            this.垂直排列ToolStripMenuItem.Name = "垂直排列ToolStripMenuItem";
            this.垂直排列ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.垂直排列ToolStripMenuItem.Text = "編輯";
            this.垂直排列ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // 檢示ToolStripMenuItem
            // 
            this.檢示ToolStripMenuItem.Name = "檢示ToolStripMenuItem";
            this.檢示ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.檢示ToolStripMenuItem.Text = "檢視";
            // 
            // 視窗ToolStripMenuItem
            // 
            this.視窗ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平排列ToolStripMenuItem1,
            this.垂直排列ToolStripMenuItem1,
            this.階梯式排列ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.關閉目前視窗ToolStripMenuItem,
            this.關閉所有視窗ToolStripMenuItem});
            this.視窗ToolStripMenuItem.Name = "視窗ToolStripMenuItem";
            this.視窗ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.視窗ToolStripMenuItem.Text = "視窗";
            // 
            // 水平排列ToolStripMenuItem1
            // 
            this.水平排列ToolStripMenuItem1.Name = "水平排列ToolStripMenuItem1";
            this.水平排列ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.水平排列ToolStripMenuItem1.Text = "水平排列";
            this.水平排列ToolStripMenuItem1.Click += new System.EventHandler(this.水平排列ToolStripMenuItem1_Click);
            // 
            // 垂直排列ToolStripMenuItem1
            // 
            this.垂直排列ToolStripMenuItem1.Name = "垂直排列ToolStripMenuItem1";
            this.垂直排列ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.垂直排列ToolStripMenuItem1.Text = "垂直排列";
            this.垂直排列ToolStripMenuItem1.Click += new System.EventHandler(this.垂直排列ToolStripMenuItem1_Click);
            // 
            // 階梯式排列ToolStripMenuItem
            // 
            this.階梯式排列ToolStripMenuItem.Name = "階梯式排列ToolStripMenuItem";
            this.階梯式排列ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.階梯式排列ToolStripMenuItem.Text = "階梯式排列";
            this.階梯式排列ToolStripMenuItem.Click += new System.EventHandler(this.階梯式排列ToolStripMenuItem_Click);
            // 
            // 關閉目前視窗ToolStripMenuItem
            // 
            this.關閉目前視窗ToolStripMenuItem.Name = "關閉目前視窗ToolStripMenuItem";
            this.關閉目前視窗ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.關閉目前視窗ToolStripMenuItem.Text = "關閉目前視窗";
            this.關閉目前視窗ToolStripMenuItem.Click += new System.EventHandler(this.關閉目前視窗ToolStripMenuItem_Click);
            // 
            // 關閉所有視窗ToolStripMenuItem
            // 
            this.關閉所有視窗ToolStripMenuItem.Name = "關閉所有視窗ToolStripMenuItem";
            this.關閉所有視窗ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.關閉所有視窗ToolStripMenuItem.Text = "關閉所有視窗";
            this.關閉所有視窗ToolStripMenuItem.Click += new System.EventHandler(this.關閉所有視窗ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_main";
            this.Text = "Frm_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 水平排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平排列ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 垂直排列ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 階梯式排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 關閉目前視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關閉所有視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
    }
}