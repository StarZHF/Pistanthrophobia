
namespace Pistanthrophobia
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCheat = new System.Windows.Forms.Button();
            this.lblGhostInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheat
            // 
            this.btnCheat.Location = new System.Drawing.Point(25, 77);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(75, 23);
            this.btnCheat.TabIndex = 0;
            this.btnCheat.Text = "Cheat";
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // lblGhostInfo
            // 
            this.lblGhostInfo.AutoSize = true;
            this.lblGhostInfo.Location = new System.Drawing.Point(12, 9);
            this.lblGhostInfo.Name = "lblGhostInfo";
            this.lblGhostInfo.Size = new System.Drawing.Size(0, 13);
            this.lblGhostInfo.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 108);
            this.Controls.Add(this.lblGhostInfo);
            this.Controls.Add(this.btnCheat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Pistanthrophobia | UID: 69588";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheat;
        private System.Windows.Forms.Label lblGhostInfo;
    }
}

