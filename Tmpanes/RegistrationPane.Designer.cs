﻿
namespace FTI.Trialmax.Panes
{
    public partial class RegistrationPane : FTI.Trialmax.Panes.CBasePane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(35, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 360);
            this.panel1.TabIndex = 2;
            // 
            // RegistrationPane
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationPane";
            this.Size = new System.Drawing.Size(860, 509);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.RegistrationPane_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.RegistrationPane_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
    }
}