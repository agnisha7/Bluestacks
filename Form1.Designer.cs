
namespace FileDownloader
{
    partial class frmFileDownloader
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
            this.pbDwnload = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDwnload = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblDwnloadPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDwnload
            // 
            this.pbDwnload.Location = new System.Drawing.Point(33, 313);
            this.pbDwnload.Name = "pbDwnload";
            this.pbDwnload.Size = new System.Drawing.Size(688, 18);
            this.pbDwnload.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Place your download URL here:";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(33, 84);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(587, 20);
            this.tbURL.TabIndex = 2;
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(33, 150);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(587, 20);
            this.tbDestination.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Download this file to:";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(643, 80);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Go";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(643, 146);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDwnload
            // 
            this.btnDwnload.Location = new System.Drawing.Point(557, 207);
            this.btnDwnload.Name = "btnDwnload";
            this.btnDwnload.Size = new System.Drawing.Size(161, 35);
            this.btnDwnload.TabIndex = 7;
            this.btnDwnload.Text = "Download";
            this.btnDwnload.UseVisualStyleBackColor = true;
            this.btnDwnload.Click += new System.EventHandler(this.btnDwnload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Downloads:";
            // 
            // lblDwnloadPercent
            // 
            this.lblDwnloadPercent.AutoSize = true;
            this.lblDwnloadPercent.Location = new System.Drawing.Point(30, 284);
            this.lblDwnloadPercent.Name = "lblDwnloadPercent";
            this.lblDwnloadPercent.Size = new System.Drawing.Size(75, 13);
            this.lblDwnloadPercent.TabIndex = 9;
            this.lblDwnloadPercent.Text = "Downloading -";
            this.lblDwnloadPercent.Visible = false;
            // 
            // frmFileDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 367);
            this.Controls.Add(this.lblDwnloadPercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDwnload);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDwnload);
            this.Name = "frmFileDownloader";
            this.Text = "File Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbDwnload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDwnload;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDwnloadPercent;
    }
}

