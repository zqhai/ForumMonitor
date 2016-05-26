namespace ForumMonitor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB自动监控 = new System.Windows.Forms.ToolStripButton();
            this.tSTB监控频率 = new System.Windows.Forms.ToolStripTextBox();
            this.tSB手动刷新 = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB自动监控,
            this.tSTB监控频率,
            this.tSB手动刷新});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(220, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSB自动监控
            // 
            //this.tSB自动监控.Image = global::ForumMonitor.Properties.Resources.start;
            this.tSB自动监控.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB自动监控.Name = "tSB自动监控";
            this.tSB自动监控.Size = new System.Drawing.Size(57, 22);
            this.tSB自动监控.Text = "Start";
            // 
            // tSTB监控频率
            // 
            this.tSTB监控频率.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tSTB监控频率.Name = "tSTB监控频率";
            this.tSTB监控频率.Size = new System.Drawing.Size(40, 25);
            this.tSTB监控频率.Text = "60";
            this.tSTB监控频率.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tSB手动刷新
            // 
            this.tSB手动刷新.BackColor = System.Drawing.SystemColors.Control;
            this.tSB手动刷新.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB手动刷新.Name = "tSB手动刷新";
            this.tSB手动刷新.Size = new System.Drawing.Size(76, 22);
            this.tSB手动刷新.Text = "手动刷新(&s)";
            this.tSB手动刷新.Click += new System.EventHandler(this.tSB手动刷新_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.ctMS;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ForumMonitor";
            this.notifyIcon1.Visible = true;
            // 
            // ctMS
            // 
            this.ctMS.Name = "ctMS";
            this.ctMS.Size = new System.Drawing.Size(61, 4);
            this.ctMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctMS_ItemClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 30);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB自动监控;
        private System.Windows.Forms.ToolStripTextBox tSTB监控频率;
        private System.Windows.Forms.ToolStripButton tSB手动刷新;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ctMS;
        private System.Windows.Forms.Timer timer1;
    }
}