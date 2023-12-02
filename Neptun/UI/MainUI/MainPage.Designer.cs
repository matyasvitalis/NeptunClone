namespace NeptunClone.UI.MainUI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            targyakMenu = new ToolStripDropDownButton();
            felvettTárgyakToolStripMenuItem = new ToolStripMenuItem();
            felvettKurzusokToolStripMenuItem = new ToolStripMenuItem();
            tárgyfelvételToolStripMenuItem = new ToolStripMenuItem();
            OrarendButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(78, 17);
            toolStripStatusLabel1.Text = "WelcomeText";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(103, 20);
            toolStripDropDownButton1.Text = "Kijelentkezés";
            toolStripDropDownButton1.ToolTipText = "Kijelentkezés";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, targyakMenu, OrarendButton, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // targyakMenu
            // 
            targyakMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            targyakMenu.DropDownItems.AddRange(new ToolStripItem[] { felvettTárgyakToolStripMenuItem, felvettKurzusokToolStripMenuItem, tárgyfelvételToolStripMenuItem });
            targyakMenu.Image = (Image)resources.GetObject("targyakMenu.Image");
            targyakMenu.ImageTransparentColor = Color.Magenta;
            targyakMenu.Name = "targyakMenu";
            targyakMenu.Size = new Size(60, 22);
            targyakMenu.Text = "Tárgyak";
            targyakMenu.ToolTipText = "Tárgyak";
            // 
            // felvettTárgyakToolStripMenuItem
            // 
            felvettTárgyakToolStripMenuItem.Name = "felvettTárgyakToolStripMenuItem";
            felvettTárgyakToolStripMenuItem.Size = new Size(180, 22);
            felvettTárgyakToolStripMenuItem.Text = "Felvett tárgyak";
            // 
            // felvettKurzusokToolStripMenuItem
            // 
            felvettKurzusokToolStripMenuItem.Name = "felvettKurzusokToolStripMenuItem";
            felvettKurzusokToolStripMenuItem.Size = new Size(180, 22);
            felvettKurzusokToolStripMenuItem.Text = "Felvett kurzusok";
            // 
            // tárgyfelvételToolStripMenuItem
            // 
            tárgyfelvételToolStripMenuItem.Name = "tárgyfelvételToolStripMenuItem";
            tárgyfelvételToolStripMenuItem.Size = new Size(180, 22);
            tárgyfelvételToolStripMenuItem.Text = "Tárgyfelvétel";
            // 
            // OrarendButton
            // 
            OrarendButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OrarendButton.Image = (Image)resources.GetObject("OrarendButton.Image");
            OrarendButton.ImageTransparentColor = Color.Magenta;
            OrarendButton.Name = "OrarendButton";
            OrarendButton.Size = new Size(54, 22);
            OrarendButton.Text = "Órarend";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Name = "MainPage";
            Text = "NEPTUN(clone)";
            Load += MainPage_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripDropDownButton targyakMenu;
        private ToolStripMenuItem felvettTárgyakToolStripMenuItem;
        private ToolStripMenuItem felvettKurzusokToolStripMenuItem;
        private ToolStripMenuItem tárgyfelvételToolStripMenuItem;
        private ToolStripButton OrarendButton;
        private ToolStripSeparator toolStripSeparator2;
    }
}