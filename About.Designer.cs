
namespace AeroShot
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AeroShotCREHeader = new System.Windows.Forms.Label();
            this.AeroShotCREStrapline = new System.Windows.Forms.Label();
            this.AeroShotCREStrapline2 = new System.Windows.Forms.Label();
            this.AeroShotCREStrapline3 = new System.Windows.Forms.Label();
            this.AeroShotCREOKButton = new System.Windows.Forms.Button();
            this.AeroShotCRELicenseNotice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AeroShotCREHeader
            // 
            this.AeroShotCREHeader.AutoSize = true;
            this.AeroShotCREHeader.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.AeroShotCREHeader.Location = new System.Drawing.Point(-6, -4);
            this.AeroShotCREHeader.Name = "AeroShotCREHeader";
            this.AeroShotCREHeader.Size = new System.Drawing.Size(429, 86);
            this.AeroShotCREHeader.TabIndex = 0;
            this.AeroShotCREHeader.Text = "AeroShot CRE";
            // 
            // AeroShotCREStrapline
            // 
            this.AeroShotCREStrapline.AutoSize = true;
            this.AeroShotCREStrapline.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AeroShotCREStrapline.Location = new System.Drawing.Point(3, 67);
            this.AeroShotCREStrapline.Name = "AeroShotCREStrapline";
            this.AeroShotCREStrapline.Size = new System.Drawing.Size(360, 30);
            this.AeroShotCREStrapline.TabIndex = 1;
            this.AeroShotCREStrapline.Text = "Copyright © 2021 Cvolton, starfrost";
            // 
            // AeroShotCREStrapline2
            // 
            this.AeroShotCREStrapline2.AutoSize = true;
            this.AeroShotCREStrapline2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AeroShotCREStrapline2.Location = new System.Drawing.Point(3, 97);
            this.AeroShotCREStrapline2.Name = "AeroShotCREStrapline2";
            this.AeroShotCREStrapline2.Size = new System.Drawing.Size(332, 30);
            this.AeroShotCREStrapline2.TabIndex = 2;
            this.AeroShotCREStrapline2.Text = "Copyright © 2015 toe_head2001";
            // 
            // AeroShotCREStrapline3
            // 
            this.AeroShotCREStrapline3.AutoSize = true;
            this.AeroShotCREStrapline3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AeroShotCREStrapline3.Location = new System.Drawing.Point(3, 127);
            this.AeroShotCREStrapline3.Name = "AeroShotCREStrapline3";
            this.AeroShotCREStrapline3.Size = new System.Drawing.Size(323, 30);
            this.AeroShotCREStrapline3.TabIndex = 3;
            this.AeroShotCREStrapline3.Text = "Copyright © 2012 Caleb Joseph";
            // 
            // AeroShotCREOKButton
            // 
            this.AeroShotCREOKButton.Location = new System.Drawing.Point(544, 316);
            this.AeroShotCREOKButton.Name = "AeroShotCREOKButton";
            this.AeroShotCREOKButton.Size = new System.Drawing.Size(75, 23);
            this.AeroShotCREOKButton.TabIndex = 5;
            this.AeroShotCREOKButton.Text = "OK";
            this.AeroShotCREOKButton.UseVisualStyleBackColor = true;
            this.AeroShotCREOKButton.Click += new System.EventHandler(this.AeroShotCREOKButton_Click);
            // 
            // AeroShotCRELicenseNotice
            // 
            this.AeroShotCRELicenseNotice.AutoSize = true;
            this.AeroShotCRELicenseNotice.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AeroShotCRELicenseNotice.Location = new System.Drawing.Point(-6, 167);
            this.AeroShotCRELicenseNotice.Name = "AeroShotCRELicenseNotice";
            this.AeroShotCRELicenseNotice.Size = new System.Drawing.Size(379, 156);
            this.AeroShotCRELicenseNotice.TabIndex = 6;
            this.AeroShotCRELicenseNotice.Text = resources.GetString("AeroShotCRELicenseNotice.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 351);
            this.Controls.Add(this.AeroShotCRELicenseNotice);
            this.Controls.Add(this.AeroShotCREOKButton);
            this.Controls.Add(this.AeroShotCREStrapline3);
            this.Controls.Add(this.AeroShotCREStrapline2);
            this.Controls.Add(this.AeroShotCREStrapline);
            this.Controls.Add(this.AeroShotCREHeader);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AeroShotCREHeader;
        private System.Windows.Forms.Label AeroShotCREStrapline;
        private System.Windows.Forms.Label AeroShotCREStrapline2;
        private System.Windows.Forms.Label AeroShotCREStrapline3;
        private System.Windows.Forms.Button AeroShotCREOKButton;
        private System.Windows.Forms.Label AeroShotCRELicenseNotice;
    }
}