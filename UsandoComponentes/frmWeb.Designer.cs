﻿namespace UsandoComponentes
{
    partial class frmWeb
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
            this.wbbDuck = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbbDuck
            // 
            this.wbbDuck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbbDuck.Location = new System.Drawing.Point(0, 0);
            this.wbbDuck.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbbDuck.Name = "wbbDuck";
            this.wbbDuck.Size = new System.Drawing.Size(800, 450);
            this.wbbDuck.TabIndex = 0;
            // 
            // frmWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbbDuck);
            this.Name = "frmWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWeb";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWeb_FormClosed);
            this.Load += new System.EventHandler(this.frmWeb_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbbDuck;
    }
}