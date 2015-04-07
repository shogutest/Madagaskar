namespace Kalkulator
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijAplikacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularz1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularz2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.zamknijAplikacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularz1ToolStripMenuItem,
            this.formularz2ToolStripMenuItem});
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.form1ToolStripMenuItem.Text = "Formularze";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // zamknijAplikacjeToolStripMenuItem
            // 
            this.zamknijAplikacjeToolStripMenuItem.Name = "zamknijAplikacjeToolStripMenuItem";
            this.zamknijAplikacjeToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.zamknijAplikacjeToolStripMenuItem.Text = "Zamknij aplikacje";
            this.zamknijAplikacjeToolStripMenuItem.Click += new System.EventHandler(this.zamknijAplikacjeToolStripMenuItem_Click);
            // 
            // formularz1ToolStripMenuItem
            // 
            this.formularz1ToolStripMenuItem.Name = "formularz1ToolStripMenuItem";
            this.formularz1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formularz1ToolStripMenuItem.Text = "Formularz1";
            this.formularz1ToolStripMenuItem.Click += new System.EventHandler(this.formularz1ToolStripMenuItem_Click);
            // 
            // formularz2ToolStripMenuItem
            // 
            this.formularz2ToolStripMenuItem.Name = "formularz2ToolStripMenuItem";
            this.formularz2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formularz2ToolStripMenuItem.Text = "Formularz2";
            this.formularz2ToolStripMenuItem.Click += new System.EventHandler(this.formularz2ToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 296);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularz1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularz2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijAplikacjeToolStripMenuItem;
    }
}