﻿
namespace PhamTriDat.Solution
{
    partial class baitap4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMCD = new System.Windows.Forms.TextBox();
            this.xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã công dân: ";
            // 
            // textBoxMCD
            // 
            this.textBoxMCD.Location = new System.Drawing.Point(120, 38);
            this.textBoxMCD.Name = "textBoxMCD";
            this.textBoxMCD.Size = new System.Drawing.Size(100, 23);
            this.textBoxMCD.TabIndex = 1;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(12, 34);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 30);
            this.xoa.TabIndex = 3;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // baitap4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 94);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.textBoxMCD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "baitap4";
            this.Text = "baitap4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMCD;
        private System.Windows.Forms.Button xoa;
    }
}