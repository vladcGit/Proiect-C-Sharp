﻿namespace Proiect_PAW
{
    partial class FormGraficMeciuri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbareCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbareFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printareToolStripMenuItem,
            this.schimbareCuloareToolStripMenuItem,
            this.schimbareFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 70);
            // 
            // printareToolStripMenuItem
            // 
            this.printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            this.printareToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.printareToolStripMenuItem.Text = "Printare";
            this.printareToolStripMenuItem.Click += new System.EventHandler(this.printareToolStripMenuItem_Click);
            // 
            // schimbareCuloareToolStripMenuItem
            // 
            this.schimbareCuloareToolStripMenuItem.Name = "schimbareCuloareToolStripMenuItem";
            this.schimbareCuloareToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.schimbareCuloareToolStripMenuItem.Text = "Schimbare Culoare";
            this.schimbareCuloareToolStripMenuItem.Click += new System.EventHandler(this.schimbareCuloareToolStripMenuItem_Click);
            // 
            // schimbareFontToolStripMenuItem
            // 
            this.schimbareFontToolStripMenuItem.Name = "schimbareFontToolStripMenuItem";
            this.schimbareFontToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.schimbareFontToolStripMenuItem.Text = "Schimbare Font";
            this.schimbareFontToolStripMenuItem.Click += new System.EventHandler(this.schimbareFontToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FormGraficMeciuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGraficMeciuri";
            this.ShowIcon = false;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbareCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbareFontToolStripMenuItem;
    }
}