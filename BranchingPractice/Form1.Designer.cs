﻿namespace BranchingPractice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDisplayGreeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 0;
            // 
            // btnDisplayGreeting
            // 
            this.btnDisplayGreeting.Location = new System.Drawing.Point(91, 118);
            this.btnDisplayGreeting.Name = "btnDisplayGreeting";
            this.btnDisplayGreeting.Size = new System.Drawing.Size(125, 62);
            this.btnDisplayGreeting.TabIndex = 1;
            this.btnDisplayGreeting.Text = "DIsplay Greeting";
            this.btnDisplayGreeting.UseVisualStyleBackColor = true;
            this.btnDisplayGreeting.Click += new System.EventHandler(this.btnDisplayGreeting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 286);
            this.Controls.Add(this.btnDisplayGreeting);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Branching Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtName;
        private Button btnDisplayGreeting;
    }
}