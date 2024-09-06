namespace UsandoComponentes
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
            this.btnWeb = new System.Windows.Forms.Button();
            this.btnWmp = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeb
            // 
            this.btnWeb.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeb.Location = new System.Drawing.Point(59, 48);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(250, 100);
            this.btnWeb.TabIndex = 0;
            this.btnWeb.Text = "&WEB";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // btnWmp
            // 
            this.btnWmp.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWmp.Location = new System.Drawing.Point(59, 173);
            this.btnWmp.Name = "btnWmp";
            this.btnWmp.Size = new System.Drawing.Size(250, 100);
            this.btnWmp.TabIndex = 1;
            this.btnWmp.Text = "&WMP";
            this.btnWmp.UseVisualStyleBackColor = true;
            this.btnWmp.Click += new System.EventHandler(this.btnWmp_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.Location = new System.Drawing.Point(59, 295);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(250, 100);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "&PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnWmp);
            this.Controls.Add(this.btnWeb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Button btnWmp;
        private System.Windows.Forms.Button btnPdf;
    }
}

