﻿
namespace DBTutorial3
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
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.lstBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBox1
            // 
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.Location = new System.Drawing.Point(44, 84);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.Size = new System.Drawing.Size(194, 446);
            this.lstBox1.TabIndex = 0;
            // 
            // lstBox2
            // 
            this.lstBox2.FormattingEnabled = true;
            this.lstBox2.Location = new System.Drawing.Point(303, 86);
            this.lstBox2.Name = "lstBox2";
            this.lstBox2.Size = new System.Drawing.Size(194, 446);
            this.lstBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.lstBox2);
            this.Controls.Add(this.lstBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox1;
        private System.Windows.Forms.ListBox lstBox2;
    }
}

