﻿namespace PCHUB
{
    partial class Programs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programs));
            ZAPRET = new Button();
            menuStrip1 = new MenuStrip();
            themesToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toHubToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ZAPRET
            // 
            ZAPRET.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ZAPRET.Location = new Point(12, 26);
            ZAPRET.Name = "ZAPRET";
            ZAPRET.Size = new Size(179, 66);
            ZAPRET.TabIndex = 0;
            ZAPRET.Text = "Zapret";
            ZAPRET.UseVisualStyleBackColor = true;
            ZAPRET.Click += ZAPRET_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { themesToolStripMenuItem, aboutToolStripMenuItem, toHubToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // themesToolStripMenuItem
            // 
            themesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whiteToolStripMenuItem, purpleToolStripMenuItem });
            themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            themesToolStripMenuItem.Size = new Size(61, 20);
            themesToolStripMenuItem.Text = "Themes";
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(108, 22);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // purpleToolStripMenuItem
            // 
            purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            purpleToolStripMenuItem.Size = new Size(108, 22);
            purpleToolStripMenuItem.Text = "Purple";
            purpleToolStripMenuItem.Click += purpleToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toHubToolStripMenuItem
            // 
            toHubToolStripMenuItem.Name = "toHubToolStripMenuItem";
            toHubToolStripMenuItem.Size = new Size(55, 20);
            toHubToolStripMenuItem.Text = "ToHub";
            toHubToolStripMenuItem.Click += toHubToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(197, 26);
            button1.Name = "button1";
            button1.Size = new Size(179, 66);
            button1.TabIndex = 2;
            button1.Text = "Browse in your \r\ndefoult browser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Programs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ZAPRET);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Programs";
            Text = "Programs";
            Load += Programs_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ZAPRET;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themesToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem toHubToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button button1;
    }
}