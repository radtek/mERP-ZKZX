﻿namespace Zkzx.Forms
{
    partial class 作业过程监控
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl监控区 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnl监控区);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 392);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "作业监控区";
            // 
            // pnl监控区
            // 
            this.pnl监控区.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl监控区.Location = new System.Drawing.Point(3, 17);
            this.pnl监控区.Margin = new System.Windows.Forms.Padding(0);
            this.pnl监控区.Name = "pnl监控区";
            this.pnl监控区.Size = new System.Drawing.Size(1002, 372);
            this.pnl监控区.TabIndex = 0;
            // 
            // 作业过程监控
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 392);
            this.Controls.Add(this.groupBox1);
            this.Name = "作业过程监控";
            this.Text = "作业过程监控";
            this.Load += new System.EventHandler(this.作业过程监控_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl监控区;
        private System.Windows.Forms.Timer timer1;
    }
}